using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace lab2
{
    public partial class SortForm : Form
    {
        Form1 mainForm;
        public SortForm(Form1 form)
        {
            InitializeComponent();
            mainForm = form;
            mainForm.Enabled = false;
        }

        private void SearchForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.Enabled = true;
        }

        private void LectionsSortBtn_Click(object sender, EventArgs e)
        {
            List<DisciplineForSerialize> outputList = new List<DisciplineForSerialize>();
            if (mainForm.tempDisciplines == null) MessageBox.Show("В памяти не хранятся дисциплины, загрузите данные из XML файла!", "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                var linqSort = from discipline in mainForm.tempDisciplines orderby discipline.Discipline.numberOfLectures select discipline;
                foreach (var discipline in linqSort) outputList.Add(discipline);
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

        private void TypeOfControlSortBtn_Click(object sender, EventArgs e)
        {
            List<DisciplineForSerialize> outputList = new List<DisciplineForSerialize>();
            if (mainForm.tempDisciplines == null) MessageBox.Show("В памяти не хранятся дисциплины, загрузите данные из XML файла!", "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                var linqSort = from discipline in mainForm.tempDisciplines orderby discipline.Discipline.typeOfControl select discipline;
                foreach (var discipline in linqSort) outputList.Add(discipline);
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
}
