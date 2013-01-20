﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Globalization;
using OpenTK;
using ps2ls.Assets.Dma;
using ps2ls.Graphics.Materials;
using ps2ls.Cryptography;

namespace ps2ls.Assets.Dme
{
    public class Model
    {
        public UInt32 Version { get; private set; }
        public String Name { get; private set; }
        public UInt32 Unknown0 { get; private set; }
        public UInt32 Unknown1 { get; private set; }
        public UInt32 Unknown2 { get; private set; }
        private Vector3 min;
        public Vector3 Min { get { return min; } }
        private Vector3 max;
        public Vector3 Max { get { return max; } }
        public List<Material> Materials { get; private set; }
        public Mesh[] Meshes { get; private set; }

        #region Attributes
        public UInt32 VertexCount
        {
            get
            {
                UInt32 vertexCount = 0;

                for (Int32 i = 0; i < Meshes.Length; ++i)
                {
                    vertexCount += Meshes[i].VertexCount;
                }

                return vertexCount;
            }
        }
        public UInt32 IndexCount
        {
            get
            {
                UInt32 indexCount = 0;

                for (Int32 i = 0; i < Meshes.Length; ++i)
                {
                    indexCount += Meshes[i].IndexCount;
                }

                return indexCount;
            }
        }
        #endregion

        public static Model LoadFromStream(String name, Stream stream)
        {
            BinaryReader binaryReader = new BinaryReader(stream);

            //header
            byte[] magic = binaryReader.ReadBytes(4);

            if (magic[0] != 'D' ||
                magic[1] != 'M' ||
                magic[2] != 'O' ||
                magic[3] != 'D')
            {
                return null;
            }

            UInt32 dmodVersion = binaryReader.ReadUInt32();

            if (dmodVersion != 3 && dmodVersion != 4)
            {
                return null;
            }

            UInt32 modelHeaderOffset = binaryReader.ReadUInt32();

            Model model = new Model();
            model.Name = name;

            //materials
            model.Materials = new List<Material>();
            Dma.Dma.LoadFromStream(binaryReader.BaseStream, model.Materials);

            //bounding box
            model.min.X = binaryReader.ReadSingle();
            model.min.Y = binaryReader.ReadSingle();
            model.min.Z = binaryReader.ReadSingle();

            model.max.X = binaryReader.ReadSingle();
            model.max.Y = binaryReader.ReadSingle();
            model.max.Z = binaryReader.ReadSingle();

            //meshes
            UInt32 meshCount = binaryReader.ReadUInt32();

            model.Meshes = new Mesh[meshCount];

            for (Int32 i = 0; i < meshCount; ++i)
            {
                Mesh mesh = Mesh.LoadFromStreamWithVersion(binaryReader.BaseStream, dmodVersion, model.Materials);

                if (mesh != null)
                {
                    model.Meshes[i] = mesh;
                }
            }

            return model;
        }
    }
}