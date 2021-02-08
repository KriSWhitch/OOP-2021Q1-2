using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace lab2
{
    public partial class SearchForm : Form
    {
        public Form1 mainForm;
        public string textFromInputInSearch;

        public SearchForm(Form1 form)
        {
            InitializeComponent();
            mainForm = form;
            mainForm.Enabled = false;
        }

        private void LectorSearch_Click(object sender, EventArgs e)
        {
            List<DisciplineForSerialize> outputList = new List<DisciplineForSerialize>();
            if (mainForm.tempDisciplines == null) MessageBox.Show("В памяти не хранятся дисциплины, загрузите данные из XML файла!", "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                InputInSearch inputInSearch = new InputInSearch(this);
                inputInSearch.ShowDialog();

                Regex regex = new Regex(@$"{textFromInputInSearch}(\w*)", RegexOptions.IgnoreCase);
                foreach (var discipline in mainForm.tempDisciplines)
                {
                    MatchCollection matches = regex.Matches(discipline.Lector.fullname);
                    if (matches.Count > 0) outputList.Add(discipline);
                }
                if (outputList.Count == 0)
                {
                    MessageBox.Show("Мы не нашли подобных записей :c", "Поиск завершился неудачей", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                else
                {
                    mainForm.DisplayArea.Text = "";
                    foreach (DisciplineForSerialize discipline in outputList)
                    {
                        mainForm.DisplayArea.Text += $"" +
                        $"Название дисциплины: {discipline.Discipline.disciplineName} \r\n" +
                        $"Cеместр: {discipline.Discipline.semestr} \r\n" +
                        $"Курс: {discipline.Discipline.cours} \r\n" +
                        $"Специальность: {discipline.Discipline.speciality} \r\n" +
                        $"Вид Контроля: {discipline.Discipline.typeOfControl} \r\n" +
                        $"Количество лекций: {discipline.Discipline.numberOfLectures} \r\n" +
                        $"Количество лабораторных: {discipline.Discipline.numberOfLabratoryExercises} \r\n" +
                        $"Лектор: \r\n" +
                        $"ФИО: {discipline.Lector.fullname} \r\n" +
                        $"Кафедра: {discipline.Lector.department} \r\n" +
                        $"Аудитория: {discipline.Lector.auditory} \r\n \r\n \r\n";
                    }
                    this.Close();
                }

            }
        }

        private void SemestrSearch_Click(object sender, EventArgs e)
        {
            List<DisciplineForSerialize> outputList = new List<DisciplineForSerialize>();
            if (mainForm.tempDisciplines == null) MessageBox.Show("В памяти не хранятся дисциплины, загрузите данные из XML файла!", "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                InputInSearch inputInSearch = new InputInSearch(this);
                inputInSearch.ShowDialog();

                Regex regex = new Regex(@$"{textFromInputInSearch}(\w*)", RegexOptions.IgnoreCase);
                foreach (var discipline in mainForm.tempDisciplines)
                {
                    MatchCollection matches = regex.Matches(discipline.Discipline.semestr);
                    if (matches.Count > 0) outputList.Add(discipline);
                }
                if (outputList.Count == 0) 
                {
                    MessageBox.Show("Мы не нашли подобных записей :c", "Поиск завершился неудачей", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                } 
                else
                {
                    mainForm.DisplayArea.Text = "";
                    foreach (DisciplineForSerialize discipline in outputList)
                    {
                        mainForm.DisplayArea.Text += $"" +
                        $"Название дисциплины: {discipline.Discipline.disciplineName} \r\n" +
                        $"Cеместр: {discipline.Discipline.semestr} \r\n" +
                        $"Курс: {discipline.Discipline.cours} \r\n" +
                        $"Специальность: {discipline.Discipline.speciality} \r\n" +
                        $"Вид Контроля: {discipline.Discipline.typeOfControl} \r\n" +
                        $"Количество лекций: {discipline.Discipline.numberOfLectures} \r\n" +
                        $"Количество лабораторных: {discipline.Discipline.numberOfLabratoryExercises} \r\n" +
                        $"Лектор: \r\n" +
                        $"ФИО: {discipline.Lector.fullname} \r\n" +
                        $"Кафедра: {discipline.Lector.department} \r\n" +
                        $"Аудитория: {discipline.Lector.auditory} \r\n \r\n \r\n";
                    }
                    this.Close();
                }

            }
        }

        private void CourseSearch_Click(object sender, EventArgs e)
        {
            List<DisciplineForSerialize> outputList = new List<DisciplineForSerialize>();
            if (mainForm.tempDisciplines == null) MessageBox.Show("В памяти не хранятся дисциплины, загрузите данные из XML файла!", "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                InputInSearch inputInSearch = new InputInSearch(this);
                inputInSearch.ShowDialog();

                Regex regex = new Regex(@$"{textFromInputInSearch}(\w*)", RegexOptions.IgnoreCase);
                foreach (var discipline in mainForm.tempDisciplines)
                {
                    MatchCollection matches = regex.Matches(discipline.Discipline.cours);
                    if (matches.Count > 0) outputList.Add(discipline);
                }
                if (outputList.Count == 0)
                {
                    MessageBox.Show("Мы не нашли подобных записей :c", "Поиск завершился неудачей", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                else
                {
                    mainForm.DisplayArea.Text = "";
                    foreach (DisciplineForSerialize discipline in outputList)
                    {
                        mainForm.DisplayArea.Text += $"" +
                        $"Название дисциплины: {discipline.Discipline.disciplineName} \r\n" +
                        $"Cеместр: {discipline.Discipline.semestr} \r\n" +
                        $"Курс: {discipline.Discipline.cours} \r\n" +
                        $"Специальность: {discipline.Discipline.speciality} \r\n" +
                        $"Вид Контроля: {discipline.Discipline.typeOfControl} \r\n" +
                        $"Количество лекций: {discipline.Discipline.numberOfLectures} \r\n" +
                        $"Количество лабораторных: {discipline.Discipline.numberOfLabratoryExercises} \r\n" +
                        $"Лектор: \r\n" +
                        $"ФИО: {discipline.Lector.fullname} \r\n" +
                        $"Кафедра: {discipline.Lector.department} \r\n" +
                        $"Аудитория: {discipline.Lector.auditory} \r\n \r\n \r\n";
                    }
                    this.Close();

                }
            }
        }

        private void SearchForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.Enabled = true;
        }
    }
}
