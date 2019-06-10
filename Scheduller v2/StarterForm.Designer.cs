namespace Scheduller_v2
{
    partial class StarterForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cpunumeric = new System.Windows.Forms.NumericUpDown();
            this.memorynumeric = new System.Windows.Forms.NumericUpDown();
            this.quantumnumeric = new System.Windows.Forms.NumericUpDown();
            this.processonumeric = new System.Windows.Forms.NumericUpDown();
            this.Startbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cpunumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memorynumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantumnumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processonumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Memory";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Processo init";
            // 
            // cpunumeric
            // 
            this.cpunumeric.Location = new System.Drawing.Point(106, 10);
            this.cpunumeric.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.cpunumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cpunumeric.Name = "cpunumeric";
            this.cpunumeric.Size = new System.Drawing.Size(120, 20);
            this.cpunumeric.TabIndex = 4;
            this.cpunumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // memorynumeric
            // 
            this.memorynumeric.Location = new System.Drawing.Point(106, 60);
            this.memorynumeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.memorynumeric.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.memorynumeric.Name = "memorynumeric";
            this.memorynumeric.Size = new System.Drawing.Size(120, 20);
            this.memorynumeric.TabIndex = 5;
            this.memorynumeric.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // quantumnumeric
            // 
            this.quantumnumeric.Location = new System.Drawing.Point(106, 110);
            this.quantumnumeric.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.quantumnumeric.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.quantumnumeric.Name = "quantumnumeric";
            this.quantumnumeric.Size = new System.Drawing.Size(120, 20);
            this.quantumnumeric.TabIndex = 6;
            this.quantumnumeric.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // processonumeric
            // 
            this.processonumeric.Location = new System.Drawing.Point(106, 160);
            this.processonumeric.Name = "processonumeric";
            this.processonumeric.Size = new System.Drawing.Size(120, 20);
            this.processonumeric.TabIndex = 7;
            // 
            // Startbutton
            // 
            this.Startbutton.Location = new System.Drawing.Point(12, 186);
            this.Startbutton.Name = "Startbutton";
            this.Startbutton.Size = new System.Drawing.Size(214, 70);
            this.Startbutton.TabIndex = 8;
            this.Startbutton.Text = "Start";
            this.Startbutton.UseVisualStyleBackColor = true;
            this.Startbutton.Click += new System.EventHandler(this.Startbutton_Click);
            // 
            // StarterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 268);
            this.Controls.Add(this.Startbutton);
            this.Controls.Add(this.processonumeric);
            this.Controls.Add(this.quantumnumeric);
            this.Controls.Add(this.memorynumeric);
            this.Controls.Add(this.cpunumeric);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StarterForm";
            this.Text = "RR/ Bestfit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StarterForm_FormClosing_1);
            ((System.ComponentModel.ISupportInitialize)(this.cpunumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memorynumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantumnumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processonumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown cpunumeric;
        private System.Windows.Forms.NumericUpDown memorynumeric;
        private System.Windows.Forms.NumericUpDown quantumnumeric;
        private System.Windows.Forms.NumericUpDown processonumeric;
        private System.Windows.Forms.Button Startbutton;
    }
}

