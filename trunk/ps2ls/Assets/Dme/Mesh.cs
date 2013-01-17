﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using ps2ls.Graphics.Materials;
using ps2ls.Cryptography;
using OpenTK;

namespace ps2ls.Assets.Dme
{
    public class Mesh
    {
        public List<Byte> VertexData { get; private set; }
        public Byte[] IndexData { get; private set; }

        public Vertex[] Vertices { get; private set; }
        public UInt16[] Indices { get; private set; }
        public UInt32 MaterialIndex { get; set; }
        public UInt32 Unknown1 { get; set; }
        public UInt32 Unknown2 { get; set; }
        public UInt32 Unknown3 { get; set; }
        public UInt32 Unknown4 { get; set; }
        public Int32 VertexCount { get; set; }
        public Int32 IndexCount { get; private set; }
        public Int32 BytesPerVertex { get; set; }
        public UInt32 VertexBlockCount { get; set; }

        private Mesh(Int32 vertexCount, Int32 indexCount)
        {
            VertexCount = vertexCount;
            IndexCount = indexCount;
            Vertices = new Vertex[vertexCount];
            Indices = new UInt16[indexCount];

            for (Int32 i = 0; i < vertexCount; ++i)
            {
                Vertices[i] = new Vertex();
            }
        }

        public static Mesh LoadFromStreamWithVersion(Stream stream, UInt32 version)
        {
            BinaryReader binaryReader = new BinaryReader(stream);

            UInt32 indexCount = 0;
            UInt32 vertexCount = 0;
            UInt32 bytesPerVertex = 0;
            UInt32 vertexBlockCount = 1;
            UInt32 materialIndex = 0;
            UInt32 meshUnknown1 = 0;
            UInt32 meshUnknown2 = 0;
            UInt32 meshUnknown3 = 0;
            UInt32 meshUnknown4 = 0;
            UInt32 totalBytesPerVertex = 0;
            UInt32 indexSize = 0;

            //switch on mesh header
            if (version == 3)
            {
                materialIndex = binaryReader.ReadUInt32();
                meshUnknown1 = binaryReader.ReadUInt32();
                meshUnknown2 = binaryReader.ReadUInt32();
                meshUnknown3 = binaryReader.ReadUInt32();
                bytesPerVertex = binaryReader.ReadUInt32();
                vertexCount = binaryReader.ReadUInt32();
                indexSize = binaryReader.ReadUInt32();
                indexCount = binaryReader.ReadUInt32();
            }
            else if (version == 4)
            {
                materialIndex = binaryReader.ReadUInt32();
                meshUnknown1 = binaryReader.ReadUInt32();
                meshUnknown2 = binaryReader.ReadUInt32();
                meshUnknown3 = binaryReader.ReadUInt32();
                vertexBlockCount = binaryReader.ReadUInt32();
                indexSize = binaryReader.ReadUInt32();
                indexCount = binaryReader.ReadUInt32();
                vertexCount = binaryReader.ReadUInt32();
            }
            else
            {
                return null;
            }

            totalBytesPerVertex += bytesPerVertex;

            Mesh mesh = new Mesh((Int32)vertexCount, (Int32)indexCount);

            mesh.VertexData = new List<Byte>((Int32)vertexCount * (Int32)totalBytesPerVertex);

            mesh.VertexBlockCount = vertexBlockCount;
            mesh.MaterialIndex = materialIndex;
            mesh.Unknown1 = meshUnknown1;
            mesh.Unknown2 = meshUnknown2;
            mesh.Unknown3 = meshUnknown3;
            mesh.Unknown4 = meshUnknown4;

            // read vertex data
            for (Int32 j = 0; j < vertexBlockCount; ++j)
            {
                if (version == 4)
                {
                    bytesPerVertex = binaryReader.ReadUInt32();

                    totalBytesPerVertex += bytesPerVertex;
                }

                for (Int32 k = 0; k < vertexCount; ++k)
                {
                    //mesh.Vertices[k].Data.AddRange(binaryReader.ReadBytes((Int32)bytesPerVertex));

                    mesh.VertexData.AddRange(binaryReader.ReadBytes((Int32)bytesPerVertex));
                }
            }

            mesh.BytesPerVertex = (Int32)totalBytesPerVertex;

            //TODO: fix hash function, lookups are failing
            //MaterialDefinition materialDefinition = MaterialDefinitionManager.Instance.MaterialDefinitions[model.Materials[(Int32)mesh.MaterialIndex].MaterialDefinitionHash];
            MaterialDefinition materialDefinition = MaterialDefinitionManager.Instance.MaterialDefinitions[Jenkins.OneAtATime("OcclusionModel")];
            VertexLayout vertexLayout = MaterialDefinitionManager.Instance.VertexLayouts[materialDefinition.DrawStyles[0].VertexLayoutNameHash];

            Int32 positionOffset = vertexLayout.GetOffsetFromDataUsageAndIndex(VertexLayout.Entry.DataUsages.Position, 0);

            //TODO: move this elsewhere
            // interpret vertex data
            byte[] vertexData = mesh.VertexData.ToArray();

            for (Int32 j = 0; j < vertexCount; ++j)
            {
                Vertex vertex = mesh.Vertices[j];

                //TODO: these are fucked, figure out what the deal is
                //position
                vertex.Position.X = BitConverter.ToSingle(vertexData, ((Int32)totalBytesPerVertex * j) + positionOffset + 0);
                vertex.Position.Y = BitConverter.ToSingle(vertexData, ((Int32)totalBytesPerVertex * j) + positionOffset + 4);
                vertex.Position.Z = BitConverter.ToSingle(vertexData, ((Int32)totalBytesPerVertex * j) + positionOffset + 8);
            }

            // read indices
            mesh.IndexData = binaryReader.ReadBytes((Int32)indexCount * (Int32)indexSize);

            for (Int32 j = 0; j < indexCount; ++j)
            {
                UInt16 index = 0;

                switch (indexSize)
                {
                    case 2:
                        index = BitConverter.ToUInt16(mesh.IndexData, j * 2);
                        break;
                    default:
                        throw new Exception();
                }

                mesh.Indices[j] = index;
            }

            //TODO: remove once we read these in from file
            // calculate normals
            for (Int32 j = 0; j < indexCount; )
            {
                UInt16[] faceIndices = { mesh.Indices[j++], mesh.Indices[j++], mesh.Indices[j++] };

                Vector3 vertex0 = mesh.Vertices[faceIndices[0]].Position;
                Vector3 vertex1 = mesh.Vertices[faceIndices[1]].Position;
                Vector3 vertex2 = mesh.Vertices[faceIndices[2]].Position;

                Vector3 normal = Vector3.Cross((vertex1 - vertex0), (vertex2 - vertex0));

                mesh.Vertices[faceIndices[0]].Normal += normal;
                mesh.Vertices[faceIndices[1]].Normal += normal;
                mesh.Vertices[faceIndices[2]].Normal += normal;
            }

            // normalize normals
            for (Int32 j = 0; j < vertexCount; ++j)
            {
                mesh.Vertices[j].Normal.Normalize();
            }

            return mesh;
        }
    }
}
