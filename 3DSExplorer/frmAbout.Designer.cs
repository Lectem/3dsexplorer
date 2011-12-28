﻿using SharpGL;
using SharpGL.Controls;

namespace _3DSExplorer
{
    partial class frmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.openGLControl1 = new SharpGL.OpenGLControl();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblCred = new System.Windows.Forms.Label();
            this.btnThanks = new System.Windows.Forms.Button();
            this.lblDex = new System.Windows.Forms.Label();
            this.cmbDex = new System.Windows.Forms.ComboBox();
            this.picDex = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDex)).BeginInit();
            this.SuspendLayout();
            // 
            // openGLControl1
            // 
            this.openGLControl1.BitDepth = 24;
            this.openGLControl1.DrawFPS = false;
            this.openGLControl1.FrameRate = 29.41176F;
            this.openGLControl1.Location = new System.Drawing.Point(12, 12);
            this.openGLControl1.Name = "openGLControl1";
            this.openGLControl1.RenderContextType = SharpGL.RenderContextType.DIBSection;
            this.openGLControl1.Size = new System.Drawing.Size(128, 128);
            this.openGLControl1.TabIndex = 0;
            this.openGLControl1.OpenGLInitialized += new System.EventHandler(this.openGLControl1_OpenGLInitialized);
            this.openGLControl1.OpenGLDraw += new System.Windows.Forms.PaintEventHandler(this.openGLControl1_OpenGLDraw);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(167, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(77, 13);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "3DSExplorer";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(167, 25);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(60, 13);
            this.lblAuthor.TabIndex = 2;
            this.lblAuthor.Text = "by elisherer";
            // 
            // lblCred
            // 
            this.lblCred.AutoSize = true;
            this.lblCred.Location = new System.Drawing.Point(167, 49);
            this.lblCred.Name = "lblCred";
            this.lblCred.Size = new System.Drawing.Size(251, 91);
            this.lblCred.TabIndex = 3;
            this.lblCred.Text = "Contributions:\r\n\r\nctrtool - All-in-one tool for CTR information extraction\r\nDSDec" +
                "mp - DS Compressions C# library\r\nSharpGL - C# 3D OpenGL support\r\n\r\nand the 3DBre" +
                "w.org && GBATemp.net users!";
            // 
            // btnThanks
            // 
            this.btnThanks.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnThanks.Location = new System.Drawing.Point(403, 125);
            this.btnThanks.Name = "btnThanks";
            this.btnThanks.Size = new System.Drawing.Size(87, 26);
            this.btnThanks.TabIndex = 4;
            this.btnThanks.Text = "Thanks";
            this.btnThanks.UseVisualStyleBackColor = true;
            // 
            // lblDex
            // 
            this.lblDex.AutoSize = true;
            this.lblDex.Location = new System.Drawing.Point(424, 9);
            this.lblDex.Name = "lblDex";
            this.lblDex.Size = new System.Drawing.Size(76, 26);
            this.lblDex.TabIndex = 6;
            this.lblDex.Text = "Pokedex 3D\r\n150 AR Codes";
            this.lblDex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbDex
            // 
            this.cmbDex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDex.FormattingEnabled = true;
            this.cmbDex.Location = new System.Drawing.Point(436, 38);
            this.cmbDex.Name = "cmbDex";
            this.cmbDex.Size = new System.Drawing.Size(54, 21);
            this.cmbDex.TabIndex = 7;
            this.cmbDex.SelectedIndexChanged += new System.EventHandler(this.cmbDex_SelectedIndexChanged);
            // 
            // picDex
            // 
            this.picDex.Location = new System.Drawing.Point(436, 65);
            this.picDex.Name = "picDex";
            this.picDex.Size = new System.Drawing.Size(54, 54);
            this.picDex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDex.TabIndex = 8;
            this.picDex.TabStop = false;
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 162);
            this.Controls.Add(this.picDex);
            this.Controls.Add(this.cmbDex);
            this.Controls.Add(this.lblDex);
            this.Controls.Add(this.btnThanks);
            this.Controls.Add(this.lblCred);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.openGLControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbout";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About 3DSExplorer";
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenGLControl openGLControl1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblCred;
        private System.Windows.Forms.Button btnThanks;
        private System.Windows.Forms.Label lblDex;
        private System.Windows.Forms.ComboBox cmbDex;
        private System.Windows.Forms.PictureBox picDex;

    }
}