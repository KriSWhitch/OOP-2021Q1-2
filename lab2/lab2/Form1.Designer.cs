﻿namespace lab2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DisciplineName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DisciplineCours = new System.Windows.Forms.ComboBox();
            this.DisciplineSpeciality = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NumberOfLectures = new System.Windows.Forms.TextBox();
            this.NumberOfLabratoryExercises = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.OffsetRadioBtn = new System.Windows.Forms.RadioButton();
            this.ExamRadioBtn = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LectorsFullname = new System.Windows.Forms.TextBox();
            this.LectorsDepartment = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.LectorsAuditory = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.TypeOfControlPanel = new System.Windows.Forms.Panel();
            this.SecondSemestrRadioBtn = new System.Windows.Forms.RadioButton();
            this.FirstSemestrRadioBtn = new System.Windows.Forms.RadioButton();
            this.SemestrPanel = new System.Windows.Forms.Panel();
            this.DisplayArea = new System.Windows.Forms.TextBox();
            this.TypeOfControlPanel.SuspendLayout();
            this.SemestrPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DisciplineName
            // 
            this.DisciplineName.BackColor = System.Drawing.Color.Red;
            this.DisciplineName.Location = new System.Drawing.Point(14, 43);
            this.DisciplineName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DisciplineName.Name = "DisciplineName";
            this.DisciplineName.Size = new System.Drawing.Size(155, 27);
            this.DisciplineName.TabIndex = 0;
            this.DisciplineName.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.DisciplineName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LettersOnly_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Семестр:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Курс:";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // DisciplineCours
            // 
            this.DisciplineCours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DisciplineCours.FormattingEnabled = true;
            this.DisciplineCours.Location = new System.Drawing.Point(14, 200);
            this.DisciplineCours.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DisciplineCours.Name = "DisciplineCours";
            this.DisciplineCours.Size = new System.Drawing.Size(155, 28);
            this.DisciplineCours.TabIndex = 2;
            // 
            // DisciplineSpeciality
            // 
            this.DisciplineSpeciality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DisciplineSpeciality.FormattingEnabled = true;
            this.DisciplineSpeciality.Location = new System.Drawing.Point(14, 283);
            this.DisciplineSpeciality.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DisciplineSpeciality.Name = "DisciplineSpeciality";
            this.DisciplineSpeciality.Size = new System.Drawing.Size(155, 28);
            this.DisciplineSpeciality.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Специальность:";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Вид контроля:";
            this.label5.Click += new System.EventHandler(this.label2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 427);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Количество лекций:";
            this.label6.Click += new System.EventHandler(this.label2_Click);
            // 
            // NumberOfLectures
            // 
            this.NumberOfLectures.BackColor = System.Drawing.Color.Red;
            this.NumberOfLectures.Location = new System.Drawing.Point(14, 465);
            this.NumberOfLectures.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NumberOfLectures.Name = "NumberOfLectures";
            this.NumberOfLectures.Size = new System.Drawing.Size(155, 27);
            this.NumberOfLectures.TabIndex = 0;
            this.NumberOfLectures.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.NumberOfLectures.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DigitsOnly_KeyPress);
            // 
            // NumberOfLabratoryExercises
            // 
            this.NumberOfLabratoryExercises.BackColor = System.Drawing.Color.Red;
            this.NumberOfLabratoryExercises.Location = new System.Drawing.Point(14, 555);
            this.NumberOfLabratoryExercises.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NumberOfLabratoryExercises.Name = "NumberOfLabratoryExercises";
            this.NumberOfLabratoryExercises.Size = new System.Drawing.Size(155, 27);
            this.NumberOfLabratoryExercises.TabIndex = 0;
            this.NumberOfLabratoryExercises.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.NumberOfLabratoryExercises.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DigitsOnly_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 519);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Количество лабораторных:";
            this.label7.Click += new System.EventHandler(this.label2_Click);
            // 
            // OffsetRadioBtn
            // 
            this.OffsetRadioBtn.AutoSize = true;
            this.OffsetRadioBtn.Location = new System.Drawing.Point(6, 20);
            this.OffsetRadioBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OffsetRadioBtn.Name = "OffsetRadioBtn";
            this.OffsetRadioBtn.Size = new System.Drawing.Size(68, 24);
            this.OffsetRadioBtn.TabIndex = 3;
            this.OffsetRadioBtn.TabStop = true;
            this.OffsetRadioBtn.Text = "Зачёт";
            this.OffsetRadioBtn.UseVisualStyleBackColor = true;
            // 
            // ExamRadioBtn
            // 
            this.ExamRadioBtn.AutoSize = true;
            this.ExamRadioBtn.Location = new System.Drawing.Point(79, 20);
            this.ExamRadioBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ExamRadioBtn.Name = "ExamRadioBtn";
            this.ExamRadioBtn.Size = new System.Drawing.Size(89, 24);
            this.ExamRadioBtn.TabIndex = 3;
            this.ExamRadioBtn.TabStop = true;
            this.ExamRadioBtn.Text = "Экзамен";
            this.ExamRadioBtn.UseVisualStyleBackColor = true;
            this.ExamRadioBtn.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 603);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Лектор:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 640);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "ФИО:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 681);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Кафедра:";
            this.label10.Click += new System.EventHandler(this.label9_Click);
            // 
            // LectorsFullname
            // 
            this.LectorsFullname.BackColor = System.Drawing.Color.Red;
            this.LectorsFullname.Location = new System.Drawing.Point(97, 636);
            this.LectorsFullname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LectorsFullname.Name = "LectorsFullname";
            this.LectorsFullname.Size = new System.Drawing.Size(155, 27);
            this.LectorsFullname.TabIndex = 0;
            this.LectorsFullname.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.LectorsFullname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LettersOnly_KeyPress);
            // 
            // LectorsDepartment
            // 
            this.LectorsDepartment.BackColor = System.Drawing.Color.Red;
            this.LectorsDepartment.Location = new System.Drawing.Point(97, 677);
            this.LectorsDepartment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LectorsDepartment.Name = "LectorsDepartment";
            this.LectorsDepartment.Size = new System.Drawing.Size(155, 27);
            this.LectorsDepartment.TabIndex = 0;
            this.LectorsDepartment.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.LectorsDepartment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LettersOnly_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 725);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "Аудитория:";
            this.label11.Click += new System.EventHandler(this.label9_Click);
            // 
            // LectorsAuditory
            // 
            this.LectorsAuditory.BackColor = System.Drawing.Color.Red;
            this.LectorsAuditory.Location = new System.Drawing.Point(97, 721);
            this.LectorsAuditory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LectorsAuditory.Name = "LectorsAuditory";
            this.LectorsAuditory.Size = new System.Drawing.Size(155, 27);
            this.LectorsAuditory.TabIndex = 0;
            this.LectorsAuditory.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.LectorsAuditory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Auditory_KeyPress);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(329, 25);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(522, 61);
            this.SaveBtn.TabIndex = 5;
            this.SaveBtn.Text = "Сохранить данные в формате XML";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // LoadBtn
            // 
            this.LoadBtn.Location = new System.Drawing.Point(329, 101);
            this.LoadBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(522, 61);
            this.LoadBtn.TabIndex = 5;
            this.LoadBtn.Text = "Загрузить данные из формата XML";
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // TypeOfControlPanel
            // 
            this.TypeOfControlPanel.Controls.Add(this.ExamRadioBtn);
            this.TypeOfControlPanel.Controls.Add(this.OffsetRadioBtn);
            this.TypeOfControlPanel.Location = new System.Drawing.Point(15, 361);
            this.TypeOfControlPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TypeOfControlPanel.Name = "TypeOfControlPanel";
            this.TypeOfControlPanel.Size = new System.Drawing.Size(168, 61);
            this.TypeOfControlPanel.TabIndex = 6;
            // 
            // SecondSemestrRadioBtn
            // 
            this.SecondSemestrRadioBtn.AutoSize = true;
            this.SecondSemestrRadioBtn.Location = new System.Drawing.Point(105, 8);
            this.SecondSemestrRadioBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SecondSemestrRadioBtn.Name = "SecondSemestrRadioBtn";
            this.SecondSemestrRadioBtn.Size = new System.Drawing.Size(98, 24);
            this.SecondSemestrRadioBtn.TabIndex = 3;
            this.SecondSemestrRadioBtn.TabStop = true;
            this.SecondSemestrRadioBtn.Text = "2 семестр";
            this.SecondSemestrRadioBtn.UseVisualStyleBackColor = true;
            // 
            // FirstSemestrRadioBtn
            // 
            this.FirstSemestrRadioBtn.AutoSize = true;
            this.FirstSemestrRadioBtn.Location = new System.Drawing.Point(1, 8);
            this.FirstSemestrRadioBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FirstSemestrRadioBtn.Name = "FirstSemestrRadioBtn";
            this.FirstSemestrRadioBtn.Size = new System.Drawing.Size(98, 24);
            this.FirstSemestrRadioBtn.TabIndex = 3;
            this.FirstSemestrRadioBtn.TabStop = true;
            this.FirstSemestrRadioBtn.Text = "1 семестр";
            this.FirstSemestrRadioBtn.UseVisualStyleBackColor = true;
            // 
            // SemestrPanel
            // 
            this.SemestrPanel.Controls.Add(this.SecondSemestrRadioBtn);
            this.SemestrPanel.Controls.Add(this.FirstSemestrRadioBtn);
            this.SemestrPanel.Location = new System.Drawing.Point(15, 116);
            this.SemestrPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SemestrPanel.Name = "SemestrPanel";
            this.SemestrPanel.Size = new System.Drawing.Size(206, 48);
            this.SemestrPanel.TabIndex = 6;
            // 
            // DisplayArea
            // 
            this.DisplayArea.BackColor = System.Drawing.Color.White;
            this.DisplayArea.Location = new System.Drawing.Point(329, 200);
            this.DisplayArea.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DisplayArea.Multiline = true;
            this.DisplayArea.Name = "DisplayArea";
            this.DisplayArea.ReadOnly = true;
            this.DisplayArea.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DisplayArea.Size = new System.Drawing.Size(522, 551);
            this.DisplayArea.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 796);
            this.Controls.Add(this.DisplayArea);
            this.Controls.Add(this.SemestrPanel);
            this.Controls.Add(this.TypeOfControlPanel);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.LectorsAuditory);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.LectorsDepartment);
            this.Controls.Add(this.LectorsFullname);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NumberOfLabratoryExercises);
            this.Controls.Add(this.NumberOfLectures);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DisciplineSpeciality);
            this.Controls.Add(this.DisciplineCours);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DisciplineName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Дисциплина";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TypeOfControlPanel.ResumeLayout(false);
            this.TypeOfControlPanel.PerformLayout();
            this.SemestrPanel.ResumeLayout(false);
            this.SemestrPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DisciplineName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox DisciplineCours;
        private System.Windows.Forms.ComboBox DisciplineSpeciality;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NumberOfLectures;
        private System.Windows.Forms.TextBox NumberOfLabratoryExercises;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton OffsetRadioBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox LectorsFullname;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox LectorsAuditory;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.Panel TypeOfControlPanel;
        private System.Windows.Forms.RadioButton SecondSemestrRadioBtn;
        private System.Windows.Forms.RadioButton FirstSemestrRadioBtn;
        private System.Windows.Forms.Panel SemestrPanel;
        private System.Windows.Forms.TextBox LectorsDepartment;
        private System.Windows.Forms.RadioButton ExamRadioBtn;
        private System.Windows.Forms.TextBox DisplayArea;
    }
}

