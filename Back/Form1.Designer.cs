namespace Back
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.info = new System.Windows.Forms.ToolStripMenuItem();
            this.run = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.riska = new System.Windows.Forms.TextBox();
            this.riska2 = new System.Windows.Forms.TextBox();
            this.probirka1 = new System.Windows.Forms.ProgressBar();
            this.probirka2 = new System.Windows.Forms.ProgressBar();
            this.probirka3 = new System.Windows.Forms.ProgressBar();
            this.p1 = new System.Windows.Forms.Label();
            this.p2 = new System.Windows.Forms.Label();
            this.p3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.info,
            this.run});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(400, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // info
            // 
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(60, 24);
            this.info.Text = "Инфо";
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // run
            // 
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(46, 24);
            this.run.Text = "Run";
            this.run.Click += new System.EventHandler(this.runToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введите цену деления шкалы \r\nв 1 пробирке";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "во 2 пробирке";
            // 
            // riska
            // 
            this.riska.Location = new System.Drawing.Point(34, 109);
            this.riska.Name = "riska";
            this.riska.Size = new System.Drawing.Size(100, 22);
            this.riska.TabIndex = 6;
            // 
            // riska2
            // 
            this.riska2.Location = new System.Drawing.Point(272, 109);
            this.riska2.Name = "riska2";
            this.riska2.Size = new System.Drawing.Size(100, 22);
            this.riska2.TabIndex = 7;
            this.riska2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.riska2_MouseMove);
            // 
            // probirka1
            // 
            this.probirka1.Location = new System.Drawing.Point(34, 171);
            this.probirka1.Name = "probirka1";
            this.probirka1.Size = new System.Drawing.Size(319, 23);
            this.probirka1.TabIndex = 8;
            this.probirka1.Value = 100;
            this.probirka1.MouseEnter += new System.EventHandler(this.probirka1_MouseEnter);
            // 
            // probirka2
            // 
            this.probirka2.Location = new System.Drawing.Point(34, 241);
            this.probirka2.Name = "probirka2";
            this.probirka2.Size = new System.Drawing.Size(319, 23);
            this.probirka2.TabIndex = 9;
            this.probirka2.MouseEnter += new System.EventHandler(this.probirka2_MouseEnter);
            // 
            // probirka3
            // 
            this.probirka3.Location = new System.Drawing.Point(33, 306);
            this.probirka3.Name = "probirka3";
            this.probirka3.Size = new System.Drawing.Size(320, 23);
            this.probirka3.TabIndex = 10;
            this.probirka3.MouseEnter += new System.EventHandler(this.probirka3_MouseEnter);
            // 
            // p1
            // 
            this.p1.AutoSize = true;
            this.p1.Location = new System.Drawing.Point(359, 177);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(32, 17);
            this.p1.TabIndex = 11;
            this.p1.Text = "100";
            // 
            // p2
            // 
            this.p2.AutoSize = true;
            this.p2.Location = new System.Drawing.Point(359, 247);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(16, 17);
            this.p2.TabIndex = 12;
            this.p2.Text = "0";
            // 
            // p3
            // 
            this.p3.AutoSize = true;
            this.p3.Location = new System.Drawing.Point(359, 315);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(16, 17);
            this.p3.TabIndex = 13;
            this.p3.Text = "0";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 341);
            this.Controls.Add(this.p3);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.probirka3);
            this.Controls.Add(this.probirka2);
            this.Controls.Add(this.probirka1);
            this.Controls.Add(this.riska2);
            this.Controls.Add(this.riska);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Мейн";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem info;
        private System.Windows.Forms.ToolStripMenuItem run;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox riska;
        private System.Windows.Forms.TextBox riska2;
        private System.Windows.Forms.ProgressBar probirka1;
        private System.Windows.Forms.ProgressBar probirka2;
        private System.Windows.Forms.ProgressBar probirka3;
        private System.Windows.Forms.Label p1;
        private System.Windows.Forms.Label p2;
        private System.Windows.Forms.Label p3;
    }
}

