﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ps2ls.Properties;
using OpenTK;
using OpenTK.Input;
using OpenTK.Graphics.OpenGL;
using ps2ls.Assets;
using ps2ls.Assets.Pack;

namespace ps2ls.Forms
{
    public partial class MainForm : Form
    {
        #region Singleton
        private static MainForm instance = null;

        public static void CreateInstance()
        {
            instance = new MainForm();
        }

        public static void DeleteInstance()
        {
            instance = null;
        }

        public static MainForm Instance { get { return instance; } }
        #endregion

        private MainForm()
        {
            InitializeComponent();
        }

        private void onAssetsChanged(object sender, EventArgs e)
        {
            Refresh();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox.Instance.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AssetBrowser.CreateInstance();
            ModelBrowser.CreateInstance();
            TextureBrowser.CreateInstance();
            SoundBrowser.CreateInstance();

            //the placement of this event handler is not arbitrary, do not move it!
            AssetManager.Instance.AssetsChanged += new EventHandler(onAssetsChanged);

            ImageList imageList = new ImageList();
            imageList.Images.Add(Properties.Resources.box_small);
            imageList.Images.Add(Properties.Resources.tree_small);
            imageList.Images.Add(Properties.Resources.image);
            imageList.Images.Add(Properties.Resources.music);
            tabControl1.ImageList = imageList;

            TabPage assetBrowserTabPage = new TabPage("Asset Browser");
            assetBrowserTabPage.Controls.Add(AssetBrowser.Instance);
            assetBrowserTabPage.ImageIndex = 0;
            tabControl1.TabPages.Add(assetBrowserTabPage);

            TabPage modelBrowserTabPage = new TabPage("Model Browser");
            modelBrowserTabPage.Controls.Add(ModelBrowser.Instance);
            modelBrowserTabPage.ImageIndex = 1;
            tabControl1.TabPages.Add(modelBrowserTabPage);

            TabPage textureBrowser = new TabPage("Texture Browser");
            textureBrowser.Controls.Add(TextureBrowser.Instance);
            textureBrowser.ImageIndex = 2;
            tabControl1.TabPages.Add(textureBrowser);

            TabPage soundBrowser = new TabPage("Sound Browser");
            soundBrowser.Controls.Add(SoundBrowser.Instance);
            soundBrowser.ImageIndex = 3;
            soundBrowser.Enter += SoundBrowser.Instance.onEnter;
            tabControl1.TabPages.Add(soundBrowser);
        }

        private void reportIssueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Properties.Settings.Default.ProjectNewIssueURL);
        }

        public override void Refresh()
        {
            base.Refresh();

            foreach (Control control in tabControl1.SelectedTab.Controls)
                control.Refresh();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
