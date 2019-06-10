namespace Scheduller_v2
{
    partial class SchedullerForm
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
            this.components = new System.ComponentModel.Container();
            this.resetButton = new System.Windows.Forms.Button();
            this.cpulist = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.proclist = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.finalList = new System.Windows.Forms.ListView();
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.processoButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.hdlist = new System.Windows.Forms.ListView();
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ramlist = new System.Windows.Forms.ListView();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.aTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.resetButton.Location = new System.Drawing.Point(1572, 874);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(200, 75);
            this.resetButton.TabIndex = 0;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // cpulist
            // 
            this.cpulist.BackColor = System.Drawing.SystemColors.Window;
            this.cpulist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.cpulist.GridLines = true;
            this.cpulist.Location = new System.Drawing.Point(1055, 12);
            this.cpulist.Name = "cpulist";
            this.cpulist.Scrollable = false;
            this.cpulist.Size = new System.Drawing.Size(511, 937);
            this.cpulist.TabIndex = 1;
            this.cpulist.UseCompatibleStateImageBehavior = false;
            this.cpulist.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "CPU ID";
            this.columnHeader1.Width = 48;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Processo ID";
            this.columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Quantum sobrando";
            this.columnHeader3.Width = 110;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tempo faltando";
            this.columnHeader4.Width = 95;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tempo total";
            this.columnHeader5.Width = 85;
            // 
            // proclist
            // 
            this.proclist.BackColor = System.Drawing.SystemColors.Window;
            this.proclist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.proclist.GridLines = true;
            this.proclist.Location = new System.Drawing.Point(4, 49);
            this.proclist.Name = "proclist";
            this.proclist.Size = new System.Drawing.Size(274, 900);
            this.proclist.TabIndex = 4;
            this.proclist.UseCompatibleStateImageBehavior = false;
            this.proclist.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "ID";
            this.columnHeader7.Width = 25;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Tempo total";
            this.columnHeader8.Width = 68;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Tempo faltando";
            this.columnHeader9.Width = 86;
            // 
            // finalList
            // 
            this.finalList.BackColor = System.Drawing.Color.LightSalmon;
            this.finalList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader21,
            this.columnHeader22});
            this.finalList.GridLines = true;
            this.finalList.Location = new System.Drawing.Point(1572, 9);
            this.finalList.Name = "finalList";
            this.finalList.Size = new System.Drawing.Size(200, 697);
            this.finalList.TabIndex = 6;
            this.finalList.UseCompatibleStateImageBehavior = false;
            this.finalList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "Processo ID";
            this.columnHeader21.Width = 95;
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "Status";
            this.columnHeader22.Width = 100;
            // 
            // processoButton
            // 
            this.processoButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.processoButton.Location = new System.Drawing.Point(1572, 793);
            this.processoButton.Name = "processoButton";
            this.processoButton.Size = new System.Drawing.Size(200, 75);
            this.processoButton.TabIndex = 7;
            this.processoButton.Text = "Adicionar processo";
            this.processoButton.UseVisualStyleBackColor = false;
            this.processoButton.Click += new System.EventHandler(this.processoButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pauseButton.Location = new System.Drawing.Point(1572, 712);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(200, 75);
            this.pauseButton.TabIndex = 8;
            this.pauseButton.Text = "Pause/continue";
            this.pauseButton.UseVisualStyleBackColor = false;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // hdlist
            // 
            this.hdlist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19,
            this.columnHeader20});
            this.hdlist.GridLines = true;
            this.hdlist.Location = new System.Drawing.Point(665, 49);
            this.hdlist.Name = "hdlist";
            this.hdlist.Size = new System.Drawing.Size(375, 900);
            this.hdlist.TabIndex = 9;
            this.hdlist.UseCompatibleStateImageBehavior = false;
            this.hdlist.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Pagina ID";
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Bloco ID";
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Processo";
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Memoria usando";
            this.columnHeader19.Width = 100;
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "Memoria Total";
            this.columnHeader20.Width = 85;
            // 
            // ramlist
            // 
            this.ramlist.BackColor = System.Drawing.SystemColors.Window;
            this.ramlist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15});
            this.ramlist.GridLines = true;
            this.ramlist.Location = new System.Drawing.Point(284, 49);
            this.ramlist.Name = "ramlist";
            this.ramlist.Size = new System.Drawing.Size(375, 900);
            this.ramlist.TabIndex = 10;
            this.ramlist.UseCompatibleStateImageBehavior = false;
            this.ramlist.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Pagina ID";
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Bloco ID";
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Processo";
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Memoria usando";
            this.columnHeader14.Width = 100;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Memoria total";
            this.columnHeader15.Width = 85;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Lista de espera";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(280, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Memoria principal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(665, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Memoria Secundaria";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(985, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "CPU\'S";
            // 
            // aTimer
            // 
            this.aTimer.Interval = 1000;
            this.aTimer.Tick += new System.EventHandler(this.aTimer_Tick);
            // 
            // SchedullerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1784, 961);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ramlist);
            this.Controls.Add(this.hdlist);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.processoButton);
            this.Controls.Add(this.finalList);
            this.Controls.Add(this.proclist);
            this.Controls.Add(this.cpulist);
            this.Controls.Add(this.resetButton);
            this.Name = "SchedullerForm";
            this.Text = "Round Robin/ BestFit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SchedullerForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.ListView cpulist;
        private System.Windows.Forms.ListView proclist;
        private System.Windows.Forms.ListView finalList;
        private System.Windows.Forms.Button processoButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.ListView hdlist;
        private System.Windows.Forms.ListView ramlist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        public System.Windows.Forms.Timer aTimer;
    }
}