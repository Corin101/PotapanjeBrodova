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
            ((System.ComponentModel.ISupportInitialize)(this.brojStupacaOdabir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brojRedakaOdabir)).BeginInit();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Start.Location = new System.Drawing.Point(768, 714);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(110, 30);
            this.Start.TabIndex = 0;
            this.Start.Text = "Složi Mrežu";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // brojRedakaLabel
            // 
            this.brojRedakaLabel.AutoSize = true;
            this.brojRedakaLabel.Location = new System.Drawing.Point(30, 718);
            this.brojRedakaLabel.Name = "brojRedakaLabel";
            this.brojRedakaLabel.Size = new System.Drawing.Size(94, 17);
            this.brojRedakaLabel.TabIndex = 1;
            this.brojRedakaLabel.Text = "Broj Redaka::";
            // 
            // brojStupacaLabel
            // 
            this.brojStupacaLabel.AutoSize = true;
            this.brojStupacaLabel.Location = new System.Drawing.Point(286, 724);
            this.brojStupacaLabel.Name = "brojStupacaLabel";
            this.brojStupacaLabel.Size = new System.Drawing.Size(97, 17);
            this.brojStupacaLabel.TabIndex = 2;
            this.brojStupacaLabel.Text = "Broj Stupaca::";
            // 
            // brojStupacaOdabir
            // 
            this.brojStupacaOdabir.Location = new System.Drawing.Point(404, 722);
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
            this.brojStupacaOdabir.Size = new System.Drawing.Size(120, 22);
            this.brojStupacaOdabir.TabIndex = 3;
            this.brojStupacaOdabir.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // brojRedakaOdabir
            // 
            this.brojRedakaOdabir.Location = new System.Drawing.Point(149, 718);
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
            this.brojRedakaOdabir.Size = new System.Drawing.Size(120, 22);
            this.brojRedakaOdabir.TabIndex = 4;
            this.brojRedakaOdabir.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(905, 780);
            this.Controls.Add(this.brojRedakaOdabir);
            this.Controls.Add(this.brojStupacaOdabir);
            this.Controls.Add(this.brojStupacaLabel);
            this.Controls.Add(this.brojRedakaLabel);
            this.Controls.Add(this.Start);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.brojStupacaOdabir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brojRedakaOdabir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label brojRedakaLabel;
        private System.Windows.Forms.Label brojStupacaLabel;
        private System.Windows.Forms.NumericUpDown brojStupacaOdabir;
        private System.Windows.Forms.NumericUpDown brojRedakaOdabir;
    }
}

