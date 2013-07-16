﻿namespace ps2ls.Forms
{
    partial class TextureExportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextureExportForm));
            this.textureFormatComboBox = new System.Windows.Forms.ComboBox();
            this.texturesListBox = new System.Windows.Forms.ListBox();
            this.exportButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // textureFormatComboBox
            // 
            this.textureFormatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.textureFormatComboBox.FormattingEnabled = true;
            this.textureFormatComboBox.Items.AddRange(new object[] {
            "DirectDraw Surface (*.dds)",
            "Portal Network Graphics (*.png)",
            "Truevision TGA (*.tga)"});
            this.textureFormatComboBox.Location = new System.Drawing.Point(96, 87);
            this.textureFormatComboBox.Name = "textureFormatComboBox";
            this.textureFormatComboBox.Size = new System.Drawing.Size(176, 21);
            this.textureFormatComboBox.TabIndex = 13;
            // 
            // texturesListBox
            // 
            this.texturesListBox.FormattingEnabled = true;
            this.texturesListBox.Location = new System.Drawing.Point(12, 12);
            this.texturesListBox.Name = "texturesListBox";
            this.texturesListBox.Size = new System.Drawing.Size(260, 69);
            this.texturesListBox.TabIndex = 14;
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(197, 114);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(75, 23);
            this.exportButton.TabIndex = 15;
            this.exportButton.Text = "Export";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Texture Format";
            // 
            // TextureExportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 146);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.texturesListBox);
            this.Controls.Add(this.textureFormatComboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TextureExportForm";
            this.ShowInTaskbar = false;
            this.Text = "Texture Export";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox textureFormatComboBox;
        private System.Windows.Forms.ListBox texturesListBox;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}