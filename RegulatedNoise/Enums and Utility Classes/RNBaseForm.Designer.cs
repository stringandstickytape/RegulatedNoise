﻿namespace RegulatedNoise.Enums_and_Utility_Classes
{
    partial class RNBaseForm
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
            this.SuspendLayout();
            // 
            // RNBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 121);
            this.Name = "RNBaseForm";
            this.Text = "RNBaseForm";
            this.ResumeLayout(false);
            this.ResizeEnd += new System.EventHandler(this.Form_ResizeEnd);
            this.Resize += new System.EventHandler(this.Form_Resize);
            this.Shown += new System.EventHandler(this.Form_Shown);

        }

        #endregion
    }
}