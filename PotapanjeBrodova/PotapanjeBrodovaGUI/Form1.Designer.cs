﻿

namespace PotapanjeBrodovaGUI
{
    partial class Form1
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
            this.Start = new System.Windows.Forms.Button();
            this.brojRedakaLabel = new System.Windows.Forms.Label();
            this.brojStupacaLabel = new System.Windows.Forms.Label();
            this.brojStupacaOdabir = new System.Windows.Forms.NumericUpDown();
            this.brojRedakaOdabir = new System.Windows.Forms.NumericUpDown();
            this.porukeLabel = new System.Windows.Forms.Label();
            this.postaviBrodoveButton = new System.Windows.Forms.Button();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.glavniPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.brojStupacaOdabir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brojRedakaOdabir)).BeginInit();
            this.controlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Start.Location = new System.Drawing.Point(555, 41);
            this.Start.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(90, 24);
            this.Start.TabIndex = 0;
            this.Start.Text = "Složi Mrežu";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // brojRedakaLabel
            // 
            this.brojRedakaLabel.AutoSize = true;
            this.brojRedakaLabel.Location = new System.Drawing.Point(16, 49);
            this.brojRedakaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.brojRedakaLabel.Name = "brojRedakaLabel";
            this.brojRedakaLabel.Size = new System.Drawing.Size(72, 13);
            this.brojRedakaLabel.TabIndex = 1;
            this.brojRedakaLabel.Text = "Broj Redaka::";
            // 
            // brojStupacaLabel
            // 
            this.brojStupacaLabel.AutoSize = true;
            this.brojStupacaLabel.Location = new System.Drawing.Point(206, 49);
            this.brojStupacaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.brojStupacaLabel.Name = "brojStupacaLabel";
            this.brojStupacaLabel.Size = new System.Drawing.Size(74, 13);
            this.brojStupacaLabel.TabIndex = 2;
            this.brojStupacaLabel.Text = "Broj Stupaca::";
            // 
            // brojStupacaOdabir
            // 
            this.brojStupacaOdabir.Location = new System.Drawing.Point(284, 45);
            this.brojStupacaOdabir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.brojStupacaOdabir.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.brojStupacaOdabir.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.brojStupacaOdabir.Name = "brojStupacaOdabir";
            this.brojStupacaOdabir.Size = new System.Drawing.Size(90, 20);
            this.brojStupacaOdabir.TabIndex = 3;
            this.brojStupacaOdabir.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // brojRedakaOdabir
            // 
            this.brojRedakaOdabir.Location = new System.Drawing.Point(91, 45);
            this.brojRedakaOdabir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.brojRedakaOdabir.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.brojRedakaOdabir.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.brojRedakaOdabir.Name = "brojRedakaOdabir";
            this.brojRedakaOdabir.Size = new System.Drawing.Size(90, 20);
            this.brojRedakaOdabir.TabIndex = 4;
            this.brojRedakaOdabir.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // porukeLabel
            // 
            this.porukeLabel.AutoSize = true;
            this.porukeLabel.Location = new System.Drawing.Point(206, 12);
            this.porukeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.porukeLabel.Name = "porukeLabel";
            this.porukeLabel.Size = new System.Drawing.Size(35, 13);
            this.porukeLabel.TabIndex = 5;
            this.porukeLabel.Text = "label1";
            this.porukeLabel.Visible = false;
            // 
            // postaviBrodoveButton
            // 
            this.postaviBrodoveButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.postaviBrodoveButton.Enabled = false;
            this.postaviBrodoveButton.Location = new System.Drawing.Point(449, 41);
            this.postaviBrodoveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.postaviBrodoveButton.Name = "postaviBrodoveButton";
            this.postaviBrodoveButton.Size = new System.Drawing.Size(90, 24);
            this.postaviBrodoveButton.TabIndex = 6;
            this.postaviBrodoveButton.Text = "Postavi Brodove";
            this.postaviBrodoveButton.UseVisualStyleBackColor = false;
            this.postaviBrodoveButton.Click += new System.EventHandler(this.postaviBrodoveButton_Click);
            // 
            // controlPanel
            // 
            this.controlPanel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.controlPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.controlPanel.Controls.Add(this.brojRedakaLabel);
            this.controlPanel.Controls.Add(this.porukeLabel);
            this.controlPanel.Controls.Add(this.postaviBrodoveButton);
            this.controlPanel.Controls.Add(this.Start);
            this.controlPanel.Controls.Add(this.brojStupacaLabel);
            this.controlPanel.Controls.Add(this.brojRedakaOdabir);
            this.controlPanel.Controls.Add(this.brojStupacaOdabir);
            this.controlPanel.Location = new System.Drawing.Point(2, 516);
            this.controlPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(660, 78);
            this.controlPanel.TabIndex = 8;
            // 
            // glavniPanel
            // 
            this.glavniPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.glavniPanel.AutoSize = true;
            this.glavniPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.glavniPanel.Location = new System.Drawing.Point(4, 2);
            this.glavniPanel.Margin = new System.Windows.Forms.Padding(0);
            this.glavniPanel.Name = "glavniPanel";
            this.glavniPanel.Size = new System.Drawing.Size(660, 571);
            this.glavniPanel.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(669, 605);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.glavniPanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.brojStupacaOdabir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brojRedakaOdabir)).EndInit();
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label brojRedakaLabel;
        private System.Windows.Forms.Label brojStupacaLabel;
        private System.Windows.Forms.NumericUpDown brojStupacaOdabir;
        private System.Windows.Forms.NumericUpDown brojRedakaOdabir;
        private System.Windows.Forms.Label porukeLabel;
        private System.Windows.Forms.Button postaviBrodoveButton;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Panel glavniPanel;
    }
}

