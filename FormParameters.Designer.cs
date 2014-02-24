﻿namespace IfcDoc
{
    partial class FormParameters
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
            this.ctlParameters = new IfcDoc.CtlParameters();
            this.SuspendLayout();
            // 
            // ctlParameters
            // 
            this.ctlParameters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctlParameters.ConceptLeaf = null;
            this.ctlParameters.ConceptRoot = null;
            this.ctlParameters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlParameters.Location = new System.Drawing.Point(0, 0);
            this.ctlParameters.Name = "ctlParameters";
            this.ctlParameters.Project = null;
            this.ctlParameters.Size = new System.Drawing.Size(624, 441);
            this.ctlParameters.TabIndex = 12;
            // 
            // FormParameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.ctlParameters);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormParameters";
            this.ShowInTaskbar = false;
            this.Text = "Parameters";
            this.ResumeLayout(false);

        }

        #endregion

        private CtlParameters ctlParameters;

    }
}