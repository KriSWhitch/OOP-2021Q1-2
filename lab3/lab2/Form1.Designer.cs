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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSort = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.DisplayArea = new System.Windows.Forms.TextBox();
            this.Tools = new System.Windows.Forms.ToolStrip();
            this.SearchTool = new System.Windows.Forms.ToolStripButton();
            this.SortTool = new System.Windows.Forms.ToolStripButton();
            this.ClearTool = new System.Windows.Forms.ToolStripButton();
            this.DeleteTool = new System.Windows.Forms.ToolStripButton();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.InfoLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.DateLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.TimeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.DisciplinesInfoLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.DisciplinesInMemory = new System.Windows.Forms.ToolStripStatusLabel();
            this.LastActionInfoLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.LastAction = new System.Windows.Forms.ToolStripStatusLabel();
            this.TypeOfControlPanel.SuspendLayout();
            this.SemestrPanel.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.Tools.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // DisciplineName
            // 
            this.DisciplineName.Location = new System.Drawing.Point(12, 68);
            this.DisciplineName.Name = "DisciplineName";
            this.DisciplineName.Size = new System.Drawing.Size(136, 23);
            this.DisciplineName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Семестр:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Курс:";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // DisciplineCours
            // 
            this.DisciplineCours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DisciplineCours.FormattingEnabled = true;
            this.DisciplineCours.Location = new System.Drawing.Point(12, 186);
            this.DisciplineCours.Name = "DisciplineCours";
            this.DisciplineCours.Size = new System.Drawing.Size(136, 23);
            this.DisciplineCours.TabIndex = 2;
            // 
            // DisciplineSpeciality
            // 
            this.DisciplineSpeciality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DisciplineSpeciality.FormattingEnabled = true;
            this.DisciplineSpeciality.Location = new System.Drawing.Point(12, 248);
            this.DisciplineSpeciality.Name = "DisciplineSpeciality";
            this.DisciplineSpeciality.Size = new System.Drawing.Size(136, 23);
            this.DisciplineSpeciality.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Специальность:";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Вид контроля:";
            this.label5.Click += new System.EventHandler(this.label2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Количество лекций:";
            this.label6.Click += new System.EventHandler(this.label2_Click);
            // 
            // NumberOfLectures
            // 
            this.NumberOfLectures.Location = new System.Drawing.Point(12, 385);
            this.NumberOfLectures.Name = "NumberOfLectures";
            this.NumberOfLectures.Size = new System.Drawing.Size(136, 23);
            this.NumberOfLectures.TabIndex = 0;
            this.NumberOfLectures.TextChanged += new System.EventHandler(this.Error_Checker);
            // 
            // NumberOfLabratoryExercises
            // 
            this.NumberOfLabratoryExercises.Location = new System.Drawing.Point(12, 452);
            this.NumberOfLabratoryExercises.Name = "NumberOfLabratoryExercises";
            this.NumberOfLabratoryExercises.Size = new System.Drawing.Size(136, 23);
            this.NumberOfLabratoryExercises.TabIndex = 0;
            this.NumberOfLabratoryExercises.TextChanged += new System.EventHandler(this.Error_Checker);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 425);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Количество лабораторных:";
            this.label7.Click += new System.EventHandler(this.label2_Click);
            // 
            // OffsetRadioBtn
            // 
            this.OffsetRadioBtn.AutoSize = true;
            this.OffsetRadioBtn.Location = new System.Drawing.Point(5, 15);
            this.OffsetRadioBtn.Name = "OffsetRadioBtn";
            this.OffsetRadioBtn.Size = new System.Drawing.Size(56, 19);
            this.OffsetRadioBtn.TabIndex = 3;
            this.OffsetRadioBtn.TabStop = true;
            this.OffsetRadioBtn.Text = "Зачёт";
            this.OffsetRadioBtn.UseVisualStyleBackColor = true;
            // 
            // ExamRadioBtn
            // 
            this.ExamRadioBtn.AutoSize = true;
            this.ExamRadioBtn.Location = new System.Drawing.Point(63, 15);
            this.ExamRadioBtn.Name = "ExamRadioBtn";
            this.ExamRadioBtn.Size = new System.Drawing.Size(71, 19);
            this.ExamRadioBtn.TabIndex = 3;
            this.ExamRadioBtn.TabStop = true;
            this.ExamRadioBtn.Text = "Экзамен";
            this.ExamRadioBtn.UseVisualStyleBackColor = true;
            this.ExamRadioBtn.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 488);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Лектор:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 516);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "ФИО:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 547);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "Кафедра:";
            this.label10.Click += new System.EventHandler(this.label9_Click);
            // 
            // LectorsFullname
            // 
            this.LectorsFullname.Location = new System.Drawing.Point(85, 513);
            this.LectorsFullname.Name = "LectorsFullname";
            this.LectorsFullname.Size = new System.Drawing.Size(136, 23);
            this.LectorsFullname.TabIndex = 0;
            // 
            // LectorsDepartment
            // 
            this.LectorsDepartment.Location = new System.Drawing.Point(85, 544);
            this.LectorsDepartment.Name = "LectorsDepartment";
            this.LectorsDepartment.Size = new System.Drawing.Size(136, 23);
            this.LectorsDepartment.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 580);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 15);
            this.label11.TabIndex = 1;
            this.label11.Text = "Аудитория:";
            this.label11.Click += new System.EventHandler(this.label9_Click);
            // 
            // LectorsAuditory
            // 
            this.LectorsAuditory.Location = new System.Drawing.Point(85, 577);
            this.LectorsAuditory.Name = "LectorsAuditory";
            this.LectorsAuditory.Size = new System.Drawing.Size(136, 23);
            this.LectorsAuditory.TabIndex = 0;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(288, 55);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(457, 46);
            this.SaveBtn.TabIndex = 5;
            this.SaveBtn.Text = "Сохранить данные в формате XML";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // LoadBtn
            // 
            this.LoadBtn.Location = new System.Drawing.Point(288, 112);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(457, 46);
            this.LoadBtn.TabIndex = 5;
            this.LoadBtn.Text = "Загрузить данные из формата XML";
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // TypeOfControlPanel
            // 
            this.TypeOfControlPanel.Controls.Add(this.ExamRadioBtn);
            this.TypeOfControlPanel.Controls.Add(this.OffsetRadioBtn);
            this.TypeOfControlPanel.Location = new System.Drawing.Point(13, 307);
            this.TypeOfControlPanel.Name = "TypeOfControlPanel";
            this.TypeOfControlPanel.Size = new System.Drawing.Size(136, 46);
            this.TypeOfControlPanel.TabIndex = 6;
            // 
            // SecondSemestrRadioBtn
            // 
            this.SecondSemestrRadioBtn.AutoSize = true;
            this.SecondSemestrRadioBtn.Location = new System.Drawing.Point(79, 6);
            this.SecondSemestrRadioBtn.Name = "SecondSemestrRadioBtn";
            this.SecondSemestrRadioBtn.Size = new System.Drawing.Size(79, 19);
            this.SecondSemestrRadioBtn.TabIndex = 3;
            this.SecondSemestrRadioBtn.TabStop = true;
            this.SecondSemestrRadioBtn.Text = "2 семестр";
            this.SecondSemestrRadioBtn.UseVisualStyleBackColor = true;
            // 
            // FirstSemestrRadioBtn
            // 
            this.FirstSemestrRadioBtn.AutoSize = true;
            this.FirstSemestrRadioBtn.Location = new System.Drawing.Point(1, 6);
            this.FirstSemestrRadioBtn.Name = "FirstSemestrRadioBtn";
            this.FirstSemestrRadioBtn.Size = new System.Drawing.Size(79, 19);
            this.FirstSemestrRadioBtn.TabIndex = 3;
            this.FirstSemestrRadioBtn.TabStop = true;
            this.FirstSemestrRadioBtn.Text = "1 семестр";
            this.FirstSemestrRadioBtn.UseVisualStyleBackColor = true;
            // 
            // SemestrPanel
            // 
            this.SemestrPanel.Controls.Add(this.SecondSemestrRadioBtn);
            this.SemestrPanel.Controls.Add(this.FirstSemestrRadioBtn);
            this.SemestrPanel.Location = new System.Drawing.Point(13, 123);
            this.SemestrPanel.Name = "SemestrPanel";
            this.SemestrPanel.Size = new System.Drawing.Size(180, 36);
            this.SemestrPanel.TabIndex = 6;
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(778, 24);
            this.MenuStrip.TabIndex = 7;
            this.MenuStrip.Text = "MenuStrip";
            this.MenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Menu_ItemClicked);
            // 
            // Menu
            // 
            this.Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuSearch,
            this.MenuSort,
            this.MenuSave,
            this.MenuAbout});
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(53, 20);
            this.Menu.Text = "Меню";
            // 
            // MenuSearch
            // 
            this.MenuSearch.Name = "MenuSearch";
            this.MenuSearch.Size = new System.Drawing.Size(149, 22);
            this.MenuSearch.Text = "Поиск";
            this.MenuSearch.Click += new System.EventHandler(this.MenuSearch_Click);
            // 
            // MenuSort
            // 
            this.MenuSort.Name = "MenuSort";
            this.MenuSort.Size = new System.Drawing.Size(149, 22);
            this.MenuSort.Text = "Сортировка";
            this.MenuSort.Click += new System.EventHandler(this.MenuSort_Click);
            // 
            // MenuSave
            // 
            this.MenuSave.Name = "MenuSave";
            this.MenuSave.Size = new System.Drawing.Size(149, 22);
            this.MenuSave.Text = "Сохранить";
            this.MenuSave.Click += new System.EventHandler(this.MenuSave_Click);
            // 
            // MenuAbout
            // 
            this.MenuAbout.Name = "MenuAbout";
            this.MenuAbout.Size = new System.Drawing.Size(149, 22);
            this.MenuAbout.Text = "О программе";
            this.MenuAbout.Click += new System.EventHandler(this.MenuAbout_Click);
            // 
            // DisplayArea
            // 
            this.DisplayArea.BackColor = System.Drawing.Color.White;
            this.DisplayArea.Location = new System.Drawing.Point(288, 186);
            this.DisplayArea.Multiline = true;
            this.DisplayArea.Name = "DisplayArea";
            this.DisplayArea.ReadOnly = true;
            this.DisplayArea.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DisplayArea.Size = new System.Drawing.Size(457, 414);
            this.DisplayArea.TabIndex = 8;
            // 
            // Tools
            // 
            this.Tools.Dock = System.Windows.Forms.DockStyle.Right;
            this.Tools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SearchTool,
            this.SortTool,
            this.ClearTool,
            this.DeleteTool});
            this.Tools.Location = new System.Drawing.Point(754, 24);
            this.Tools.Name = "Tools";
            this.Tools.Size = new System.Drawing.Size(24, 620);
            this.Tools.TabIndex = 9;
            // 
            // SearchTool
            // 
            this.SearchTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SearchTool.Image = ((System.Drawing.Image)(resources.GetObject("SearchTool.Image")));
            this.SearchTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SearchTool.Name = "SearchTool";
            this.SearchTool.Size = new System.Drawing.Size(21, 20);
            this.SearchTool.Text = "Поиск";
            this.SearchTool.Click += new System.EventHandler(this.MenuSearch_Click);
            // 
            // SortTool
            // 
            this.SortTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SortTool.Image = ((System.Drawing.Image)(resources.GetObject("SortTool.Image")));
            this.SortTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SortTool.Name = "SortTool";
            this.SortTool.Size = new System.Drawing.Size(21, 20);
            this.SortTool.Text = "Сортировка";
            this.SortTool.Click += new System.EventHandler(this.MenuSort_Click);
            // 
            // ClearTool
            // 
            this.ClearTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ClearTool.Image = ((System.Drawing.Image)(resources.GetObject("ClearTool.Image")));
            this.ClearTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ClearTool.Name = "ClearTool";
            this.ClearTool.Size = new System.Drawing.Size(21, 20);
            this.ClearTool.Text = "Очистить дисплей";
            this.ClearTool.Click += new System.EventHandler(this.ClearTool_Click);
            // 
            // DeleteTool
            // 
            this.DeleteTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteTool.Image = ((System.Drawing.Image)(resources.GetObject("DeleteTool.Image")));
            this.DeleteTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteTool.Name = "DeleteTool";
            this.DeleteTool.Size = new System.Drawing.Size(21, 20);
            this.DeleteTool.Text = "Удалить данные из памяти";
            this.DeleteTool.Click += new System.EventHandler(this.DeleteTool_Click);
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InfoLabel,
            this.DateLabel,
            this.TimeLabel,
            this.DisciplinesInfoLabel,
            this.DisciplinesInMemory,
            this.LastActionInfoLabel,
            this.LastAction});
            this.StatusStrip.Location = new System.Drawing.Point(0, 622);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(754, 22);
            this.StatusStrip.TabIndex = 10;
            // 
            // InfoLabel
            // 
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(131, 17);
            this.InfoLabel.Text = "Текущие дата и время:";
            // 
            // DateLabel
            // 
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // TimeLabel
            // 
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // DisciplinesInfoLabel
            // 
            this.DisciplinesInfoLabel.Name = "DisciplinesInfoLabel";
            this.DisciplinesInfoLabel.Size = new System.Drawing.Size(125, 17);
            this.DisciplinesInfoLabel.Text = "Дисциплин в памяти:";
            // 
            // DisciplinesInMemory
            // 
            this.DisciplinesInMemory.Name = "DisciplinesInMemory";
            this.DisciplinesInMemory.Size = new System.Drawing.Size(0, 17);
            // 
            // LastActionInfoLabel
            // 
            this.LastActionInfoLabel.Name = "LastActionInfoLabel";
            this.LastActionInfoLabel.Size = new System.Drawing.Size(122, 17);
            this.LastActionInfoLabel.Text = "Последнее действие:";
            // 
            // LastAction
            // 
            this.LastAction.Name = "LastAction";
            this.LastAction.Size = new System.Drawing.Size(0, 17);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 644);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.Tools);
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
            this.Controls.Add(this.MenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.MenuStrip;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Дисциплина";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TypeOfControlPanel.ResumeLayout(false);
            this.TypeOfControlPanel.PerformLayout();
            this.SemestrPanel.ResumeLayout(false);
            this.SemestrPanel.PerformLayout();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.Tools.ResumeLayout(false);
            this.Tools.PerformLayout();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
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
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem Menu;
        private System.Windows.Forms.ToolStripMenuItem MenuSearch;
        internal System.Windows.Forms.TextBox DisplayArea;
        private System.Windows.Forms.ToolStripMenuItem MenuSort;
        private System.Windows.Forms.ToolStripMenuItem MenuSave;
        private System.Windows.Forms.ToolStripMenuItem MenuAbout;
        private System.Windows.Forms.ToolStrip Tools;
        private System.Windows.Forms.ToolStripButton SearchTool;
        private System.Windows.Forms.ToolStripButton SortTool;
        private System.Windows.Forms.ToolStripButton ClearTool;
        private System.Windows.Forms.ToolStripButton DeleteTool;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel InfoLabel;
        private System.Windows.Forms.ToolStripStatusLabel DateLabel;
        private System.Windows.Forms.ToolStripStatusLabel TimeLabel;
        private System.Windows.Forms.ToolStripStatusLabel DisciplinesInfoLabel;
        private System.Windows.Forms.ToolStripStatusLabel DisciplinesInMemory;
        private System.Windows.Forms.ToolStripStatusLabel LastActionInfoLabel;
        private System.Windows.Forms.ToolStripStatusLabel LastAction;
    }
}

