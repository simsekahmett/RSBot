﻿namespace RSBot.Views
{
    partial class SplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            pictureBox1 = new System.Windows.Forms.PictureBox();
            referenceDataLoader = new System.ComponentModel.BackgroundWorker();
            logoLabel = new SDUI.Controls.Label();
            labelVersion = new SDUI.Controls.Label();
            label2 = new SDUI.Controls.Label();
            label3 = new SDUI.Controls.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.Image = Properties.Resources.app;
            pictureBox1.Location = new System.Drawing.Point(200, 0);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(128, 128);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // referenceDataLoader
            // 
            referenceDataLoader.DoWork += referenceDataLoader_DoWork;
            // 
            // logoLabel
            // 
            logoLabel.ApplyGradient = true;
            logoLabel.BackColor = System.Drawing.Color.Transparent;
            logoLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            logoLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 105F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            logoLabel.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            logoLabel.Gradient = new System.Drawing.Color[] { System.Drawing.Color.DodgerBlue, System.Drawing.Color.SlateBlue };
            logoLabel.GradientAnimation = false;
            logoLabel.Location = new System.Drawing.Point(1, 128);
            logoLabel.Name = "logoLabel";
            logoLabel.Size = new System.Drawing.Size(547, 201);
            logoLabel.TabIndex = 3;
            logoLabel.Text = "RSBOT";
            logoLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // labelVersion
            // 
            labelVersion.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            labelVersion.ApplyGradient = false;
            labelVersion.BackColor = System.Drawing.Color.Transparent;
            labelVersion.Enabled = false;
            labelVersion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelVersion.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            labelVersion.Gradient = new System.Drawing.Color[] { System.Drawing.Color.DodgerBlue, System.Drawing.Color.DeepSkyBlue };
            labelVersion.GradientAnimation = false;
            labelVersion.Location = new System.Drawing.Point(486, 0);
            labelVersion.Name = "labelVersion";
            labelVersion.Size = new System.Drawing.Size(59, 24);
            labelVersion.TabIndex = 4;
            labelVersion.Text = "v1.0.0";
            labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label2.ApplyGradient = false;
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Enabled = false;
            label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            label2.Gradient = new System.Drawing.Color[] { System.Drawing.Color.RosyBrown, System.Drawing.Color.FromArgb(74, 74, 74) };
            label2.GradientAnimation = false;
            label2.Location = new System.Drawing.Point(140, 282);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(271, 17);
            label2.TabIndex = 5;
            label2.Text = "Free powerful bot for Silkroad Online servers";
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label3.ApplyGradient = false;
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Enabled = false;
            label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            label3.Gradient = new System.Drawing.Color[] { System.Drawing.Color.Gray, System.Drawing.Color.Black };
            label3.GradientAnimation = false;
            label3.Location = new System.Drawing.Point(144, 314);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(254, 15);
            label3.TabIndex = 5;
            label3.Text = "Created with contributions from the community";
            // 
            // SplashScreen
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            ClientSize = new System.Drawing.Size(549, 330);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(labelVersion);
            Controls.Add(logoLabel);
            Cursor = System.Windows.Forms.Cursors.AppStarting;
            DrawTitleBorder = false;
            Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Hatch = System.Drawing.Drawing2D.HatchStyle.DottedGrid;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Location = new System.Drawing.Point(0, 0);
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(549, 330);
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(549, 330);
            Movable = false;
            Name = "SplashScreen";
            Padding = new System.Windows.Forms.Padding(1, 0, 1, 1);
            ShowTitle = false;
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Tag = "private";
            TopMost = true;
            Load += SplashScreen_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker referenceDataLoader;
        private SDUI.Controls.Label logoLabel;
        private SDUI.Controls.Label labelVersion;
        private SDUI.Controls.Label label2;
        private SDUI.Controls.Label label3;
    }
}