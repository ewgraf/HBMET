namespace nn4
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
            this.buttonSaveExperiment = new System.Windows.Forms.Button();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelGathered = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelSteps = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonGetNNStat = new System.Windows.Forms.Button();
            this.buttonLoadStat = new System.Windows.Forms.Button();
            this.buttonNextStep = new System.Windows.Forms.Button();
            this.buttonPrepareNeironet = new System.Windows.Forms.Button();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSaveExperiment
            // 
            this.buttonSaveExperiment.Enabled = false;
            this.buttonSaveExperiment.Location = new System.Drawing.Point(9, 133);
            this.buttonSaveExperiment.Name = "buttonSaveExperiment";
            this.buttonSaveExperiment.Size = new System.Drawing.Size(187, 23);
            this.buttonSaveExperiment.TabIndex = 2;
            this.buttonSaveExperiment.Text = "Сохранить эксперимент";
            this.buttonSaveExperiment.UseVisualStyleBackColor = true;
            this.buttonSaveExperiment.Click += new System.EventHandler(this.buttonSaveExperiment_Click);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.Enabled = false;
            this.checkBox4.Location = new System.Drawing.Point(9, 59);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(187, 17);
            this.checkBox4.TabIndex = 2;
            this.checkBox4.Text = "Автоматически сохранять ходы";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelGathered);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.labelSteps);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(381, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(204, 47);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Информация";
            // 
            // labelGathered
            // 
            this.labelGathered.AutoSize = true;
            this.labelGathered.Location = new System.Drawing.Point(163, 29);
            this.labelGathered.Name = "labelGathered";
            this.labelGathered.Size = new System.Drawing.Size(13, 13);
            this.labelGathered.TabIndex = 4;
            this.labelGathered.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Собрано целей:";
            // 
            // labelSteps
            // 
            this.labelSteps.AutoSize = true;
            this.labelSteps.Location = new System.Drawing.Point(163, 16);
            this.labelSteps.Name = "labelSteps";
            this.labelSteps.Size = new System.Drawing.Size(13, 13);
            this.labelSteps.TabIndex = 2;
            this.labelSteps.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Число ходов:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.buttonSaveExperiment);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.buttonGenerate);
            this.groupBox1.Location = new System.Drawing.Point(381, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 167);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Свойства";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 20);
            this.textBox1.TabIndex = 17;
            this.textBox1.Text = "Тигр Львович Медведев";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Enabled = false;
            this.checkBox3.Location = new System.Drawing.Point(9, 44);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(117, 17);
            this.checkBox3.TabIndex = 16;
            this.checkBox3.Text = "Случайное начало";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Enabled = false;
            this.checkBox2.Location = new System.Drawing.Point(9, 30);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(111, 17);
            this.checkBox2.TabIndex = 15;
            this.checkBox2.Text = "Случайная карта";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(9, 16);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(58, 17);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Туман";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(9, 108);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(187, 23);
            this.buttonGenerate.TabIndex = 0;
            this.buttonGenerate.Text = "Получить карту";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 360);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 382);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(593, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(77, 17);
            this.toolStripStatusLabel1.Text = "Приветствие";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonGetNNStat);
            this.groupBox3.Controls.Add(this.buttonLoadStat);
            this.groupBox3.Controls.Add(this.buttonNextStep);
            this.groupBox3.Controls.Add(this.buttonPrepareNeironet);
            this.groupBox3.Location = new System.Drawing.Point(381, 238);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(204, 134);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Нейросеть";
            // 
            // buttonGetNNStat
            // 
            this.buttonGetNNStat.Location = new System.Drawing.Point(9, 33);
            this.buttonGetNNStat.Name = "buttonGetNNStat";
            this.buttonGetNNStat.Size = new System.Drawing.Size(187, 37);
            this.buttonGetNNStat.TabIndex = 3;
            this.buttonGetNNStat.Text = "Получить статистику сети";
            this.buttonGetNNStat.UseVisualStyleBackColor = true;
            this.buttonGetNNStat.Click += new System.EventHandler(this.buttonGetNNStat_Click);
            // 
            // buttonLoadStat
            // 
            this.buttonLoadStat.Enabled = false;
            this.buttonLoadStat.Location = new System.Drawing.Point(9, 19);
            this.buttonLoadStat.Name = "buttonLoadStat";
            this.buttonLoadStat.Size = new System.Drawing.Size(187, 23);
            this.buttonLoadStat.TabIndex = 2;
            this.buttonLoadStat.Text = "Загрузить статистики";
            this.buttonLoadStat.UseVisualStyleBackColor = true;
            this.buttonLoadStat.Click += new System.EventHandler(this.buttonLoadStat_Click);
            // 
            // buttonNextStep
            // 
            this.buttonNextStep.Enabled = false;
            this.buttonNextStep.Location = new System.Drawing.Point(9, 105);
            this.buttonNextStep.Name = "buttonNextStep";
            this.buttonNextStep.Size = new System.Drawing.Size(187, 23);
            this.buttonNextStep.TabIndex = 1;
            this.buttonNextStep.Text = "Следующий ход сети";
            this.buttonNextStep.UseVisualStyleBackColor = true;
            this.buttonNextStep.Click += new System.EventHandler(this.buttonNextStep_Click);
            // 
            // buttonPrepareNeironet
            // 
            this.buttonPrepareNeironet.Enabled = false;
            this.buttonPrepareNeironet.Location = new System.Drawing.Point(9, 76);
            this.buttonPrepareNeironet.Name = "buttonPrepareNeironet";
            this.buttonPrepareNeironet.Size = new System.Drawing.Size(187, 23);
            this.buttonPrepareNeironet.TabIndex = 0;
            this.buttonPrepareNeironet.Text = "Приготовить нейросеть";
            this.buttonPrepareNeironet.UseVisualStyleBackColor = true;
            this.buttonPrepareNeironet.Click += new System.EventHandler(this.buttonPrepareNeironet_Click);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 404);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Лабиринт";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSaveExperiment;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelGathered;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelSteps;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonPrepareNeironet;
        private System.Windows.Forms.Button buttonNextStep;
        private System.Windows.Forms.Button buttonLoadStat;
        private System.Windows.Forms.Button buttonGetNNStat;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}

