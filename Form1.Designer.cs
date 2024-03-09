namespace Quiz
{
    partial class Quiz
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_sec = new System.Windows.Forms.TextBox();
            this.txt_min = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.but_start = new System.Windows.Forms.Button();
            this.txt_ques = new System.Windows.Forms.TextBox();
            this.rdb_option1 = new System.Windows.Forms.RadioButton();
            this.rdb_option2 = new System.Windows.Forms.RadioButton();
            this.rdb_option3 = new System.Windows.Forms.RadioButton();
            this.rdb_option4 = new System.Windows.Forms.RadioButton();
            this.but_next = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.txt_points = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.but_restart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.but_ques5 = new System.Windows.Forms.Button();
            this.but_ques4 = new System.Windows.Forms.Button();
            this.but_ques3 = new System.Windows.Forms.Button();
            this.but_ques2 = new System.Windows.Forms.Button();
            this.but_ques1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1179, 56);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(290, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Online Quiz Program";
            // 
            // txt_sec
            // 
            this.txt_sec.Enabled = false;
            this.txt_sec.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sec.Location = new System.Drawing.Point(732, 97);
            this.txt_sec.Name = "txt_sec";
            this.txt_sec.ReadOnly = true;
            this.txt_sec.Size = new System.Drawing.Size(43, 34);
            this.txt_sec.TabIndex = 1;
            // 
            // txt_min
            // 
            this.txt_min.Enabled = false;
            this.txt_min.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_min.Location = new System.Drawing.Point(107, 204);
            this.txt_min.Name = "txt_min";
            this.txt_min.ReadOnly = true;
            this.txt_min.Size = new System.Drawing.Size(48, 34);
            this.txt_min.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(672, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Time Remaining";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(102, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Q.NO";
            // 
            // but_start
            // 
            this.but_start.BackColor = System.Drawing.Color.LimeGreen;
            this.but_start.FlatAppearance.BorderSize = 0;
            this.but_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_start.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_start.ForeColor = System.Drawing.Color.White;
            this.but_start.Location = new System.Drawing.Point(382, 95);
            this.but_start.Name = "but_start";
            this.but_start.Size = new System.Drawing.Size(88, 36);
            this.but_start.TabIndex = 4;
            this.but_start.Text = "Start";
            this.but_start.UseVisualStyleBackColor = false;
            this.but_start.Click += new System.EventHandler(this.but_start_Click);
            // 
            // txt_ques
            // 
            this.txt_ques.Enabled = false;
            this.txt_ques.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ques.Location = new System.Drawing.Point(182, 204);
            this.txt_ques.Name = "txt_ques";
            this.txt_ques.ReadOnly = true;
            this.txt_ques.Size = new System.Drawing.Size(568, 34);
            this.txt_ques.TabIndex = 5;
            // 
            // rdb_option1
            // 
            this.rdb_option1.AutoSize = true;
            this.rdb_option1.Location = new System.Drawing.Point(107, 305);
            this.rdb_option1.Name = "rdb_option1";
            this.rdb_option1.Size = new System.Drawing.Size(101, 21);
            this.rdb_option1.TabIndex = 6;
            this.rdb_option1.TabStop = true;
            this.rdb_option1.Text = "radioButton1";
            this.rdb_option1.UseVisualStyleBackColor = true;
            // 
            // rdb_option2
            // 
            this.rdb_option2.AutoSize = true;
            this.rdb_option2.Location = new System.Drawing.Point(287, 305);
            this.rdb_option2.Name = "rdb_option2";
            this.rdb_option2.Size = new System.Drawing.Size(101, 21);
            this.rdb_option2.TabIndex = 7;
            this.rdb_option2.TabStop = true;
            this.rdb_option2.Text = "radioButton2";
            this.rdb_option2.UseVisualStyleBackColor = true;
            // 
            // rdb_option3
            // 
            this.rdb_option3.AutoSize = true;
            this.rdb_option3.Location = new System.Drawing.Point(467, 305);
            this.rdb_option3.Name = "rdb_option3";
            this.rdb_option3.Size = new System.Drawing.Size(101, 21);
            this.rdb_option3.TabIndex = 8;
            this.rdb_option3.TabStop = true;
            this.rdb_option3.Text = "radioButton3";
            this.rdb_option3.UseVisualStyleBackColor = true;
            // 
            // rdb_option4
            // 
            this.rdb_option4.AutoSize = true;
            this.rdb_option4.Location = new System.Drawing.Point(647, 305);
            this.rdb_option4.Name = "rdb_option4";
            this.rdb_option4.Size = new System.Drawing.Size(101, 21);
            this.rdb_option4.TabIndex = 9;
            this.rdb_option4.TabStop = true;
            this.rdb_option4.Text = "radioButton4";
            this.rdb_option4.UseVisualStyleBackColor = true;
            // 
            // but_next
            // 
            this.but_next.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.but_next.FlatAppearance.BorderSize = 0;
            this.but_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_next.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_next.ForeColor = System.Drawing.Color.White;
            this.but_next.Location = new System.Drawing.Point(382, 414);
            this.but_next.Name = "but_next";
            this.but_next.Size = new System.Drawing.Size(88, 36);
            this.but_next.TabIndex = 10;
            this.but_next.Text = "Next";
            this.but_next.UseVisualStyleBackColor = false;
            this.but_next.Click += new System.EventHandler(this.but_next_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // txt_points
            // 
            this.txt_points.Enabled = false;
            this.txt_points.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_points.Location = new System.Drawing.Point(990, 436);
            this.txt_points.Name = "txt_points";
            this.txt_points.ReadOnly = true;
            this.txt_points.Size = new System.Drawing.Size(74, 34);
            this.txt_points.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(992, 405);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 28);
            this.label4.TabIndex = 12;
            this.label4.Text = "Points";
            // 
            // but_restart
            // 
            this.but_restart.BackColor = System.Drawing.Color.Red;
            this.but_restart.FlatAppearance.BorderSize = 0;
            this.but_restart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_restart.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_restart.ForeColor = System.Drawing.Color.White;
            this.but_restart.Location = new System.Drawing.Point(382, 397);
            this.but_restart.Name = "but_restart";
            this.but_restart.Size = new System.Drawing.Size(88, 36);
            this.but_restart.TabIndex = 13;
            this.but_restart.Text = "Re - Start";
            this.but_restart.UseVisualStyleBackColor = false;
            this.but_restart.Click += new System.EventHandler(this.but_restart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.but_ques5);
            this.groupBox1.Controls.Add(this.but_ques4);
            this.groupBox1.Controls.Add(this.but_ques3);
            this.groupBox1.Controls.Add(this.but_ques2);
            this.groupBox1.Controls.Add(this.but_ques1);
            this.groupBox1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(884, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 230);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Question Result";
            // 
            // but_ques5
            // 
            this.but_ques5.BackColor = System.Drawing.Color.LightGray;
            this.but_ques5.FlatAppearance.BorderSize = 0;
            this.but_ques5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_ques5.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_ques5.ForeColor = System.Drawing.Color.White;
            this.but_ques5.Location = new System.Drawing.Point(113, 101);
            this.but_ques5.Name = "but_ques5";
            this.but_ques5.Size = new System.Drawing.Size(42, 36);
            this.but_ques5.TabIndex = 19;
            this.but_ques5.Text = "5";
            this.but_ques5.UseVisualStyleBackColor = false;
            // 
            // but_ques4
            // 
            this.but_ques4.BackColor = System.Drawing.Color.LightGray;
            this.but_ques4.FlatAppearance.BorderSize = 0;
            this.but_ques4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_ques4.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_ques4.ForeColor = System.Drawing.Color.White;
            this.but_ques4.Location = new System.Drawing.Point(15, 101);
            this.but_ques4.Name = "but_ques4";
            this.but_ques4.Size = new System.Drawing.Size(42, 36);
            this.but_ques4.TabIndex = 18;
            this.but_ques4.Text = "4";
            this.but_ques4.UseVisualStyleBackColor = false;
            // 
            // but_ques3
            // 
            this.but_ques3.BackColor = System.Drawing.Color.LightGray;
            this.but_ques3.FlatAppearance.BorderSize = 0;
            this.but_ques3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_ques3.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_ques3.ForeColor = System.Drawing.Color.White;
            this.but_ques3.Location = new System.Drawing.Point(212, 36);
            this.but_ques3.Name = "but_ques3";
            this.but_ques3.Size = new System.Drawing.Size(42, 36);
            this.but_ques3.TabIndex = 17;
            this.but_ques3.Text = "3";
            this.but_ques3.UseVisualStyleBackColor = false;
            // 
            // but_ques2
            // 
            this.but_ques2.BackColor = System.Drawing.Color.LightGray;
            this.but_ques2.FlatAppearance.BorderSize = 0;
            this.but_ques2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_ques2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_ques2.ForeColor = System.Drawing.Color.White;
            this.but_ques2.Location = new System.Drawing.Point(113, 36);
            this.but_ques2.Name = "but_ques2";
            this.but_ques2.Size = new System.Drawing.Size(42, 36);
            this.but_ques2.TabIndex = 16;
            this.but_ques2.Text = "2";
            this.but_ques2.UseVisualStyleBackColor = false;
            // 
            // but_ques1
            // 
            this.but_ques1.BackColor = System.Drawing.Color.LightGray;
            this.but_ques1.FlatAppearance.BorderSize = 0;
            this.but_ques1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_ques1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_ques1.ForeColor = System.Drawing.Color.White;
            this.but_ques1.Location = new System.Drawing.Point(15, 36);
            this.but_ques1.Name = "but_ques1";
            this.but_ques1.Size = new System.Drawing.Size(42, 36);
            this.but_ques1.TabIndex = 15;
            this.but_ques1.Text = "1";
            this.but_ques1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.ForestGreen;
            this.panel2.Location = new System.Drawing.Point(830, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(16, 478);
            this.panel2.TabIndex = 15;
            // 
            // Quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1179, 533);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.but_restart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_points);
            this.Controls.Add(this.but_next);
            this.Controls.Add(this.rdb_option4);
            this.Controls.Add(this.rdb_option3);
            this.Controls.Add(this.rdb_option2);
            this.Controls.Add(this.rdb_option1);
            this.Controls.Add(this.txt_ques);
            this.Controls.Add(this.but_start);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_min);
            this.Controls.Add(this.txt_sec);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Quiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_sec;
        private System.Windows.Forms.TextBox txt_min;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button but_start;
        private System.Windows.Forms.TextBox txt_ques;
        private System.Windows.Forms.RadioButton rdb_option1;
        private System.Windows.Forms.RadioButton rdb_option2;
        private System.Windows.Forms.RadioButton rdb_option3;
        private System.Windows.Forms.RadioButton rdb_option4;
        private System.Windows.Forms.Button but_next;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox txt_points;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button but_restart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button but_ques5;
        private System.Windows.Forms.Button but_ques4;
        private System.Windows.Forms.Button but_ques3;
        private System.Windows.Forms.Button but_ques2;
        private System.Windows.Forms.Button but_ques1;
        private System.Windows.Forms.Panel panel2;
    }
}

