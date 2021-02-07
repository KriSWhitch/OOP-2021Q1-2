using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace lab2
{
    
    public partial class Form1 : Form
    {
        public bool completenessFlag = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisciplineCours.Items.Add("1 курс"); DisciplineCours.Items.Add("2 курс");
            DisciplineCours.Items.Add("3 курс"); DisciplineCours.Items.Add("4 курс");
            DisciplineSpeciality.Items.Add("ПОИТ"); DisciplineSpeciality.Items.Add("ДЭВИ");
            DisciplineSpeciality.Items.Add("ПОИБМС"); DisciplineSpeciality.Items.Add("ИСиТ");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (
                    LectorsFullname.Text.Length > 0 && LectorsDepartment.Text.Length > 0 &&
                    LectorsAuditory.Text.Length > 0 && DisciplineName.Text.Length > 0 &&
                    (ExamRadioBtn.Checked || OffsetRadioBtn.Checked) &&
                    DisciplineCours.Text.Length > 0 && DisciplineSpeciality.Text.Length > 0 &&
                    NumberOfLectures.Text.Length > 0 &&
                    NumberOfLabratoryExercises.Text.Length > 0 &&
                    (FirstSemestrRadioBtn.Checked || SecondSemestrRadioBtn.Checked)
                ) completenessFlag = true;


            if (completenessFlag)
            {
                Lector lector = new Lector();
                Discipline discipline = new Discipline();
                lector.fullname = LectorsFullname.Text;
                lector.department = LectorsDepartment.Text;
                lector.auditory = LectorsAuditory.Text;
                discipline.disciplineName = DisciplineName.Text;
                foreach (RadioButton rb in SemestrPanel.Controls)
                {
                    if (rb.Checked) discipline.semestr = rb.Text;
                }
                discipline.cours = DisciplineCours.Text;
                discipline.speciality = DisciplineSpeciality.Text;
                discipline.numberOfLectures = NumberOfLectures.Text;
                discipline.numberOfLabratoryExercises = NumberOfLabratoryExercises.Text;
                foreach (RadioButton rb in TypeOfControlPanel.Controls)
                {
                    if (rb.Checked) discipline.typeOfControl = rb.Text;
                }

                XmlSerializer xmlf1 = new XmlSerializer(lector.GetType());
                XmlSerializer xmlf2 = new XmlSerializer(discipline.GetType());
                using (FileStream fs = new FileStream("lector.xml", FileMode.Create))
                {
                    xmlf1.Serialize(fs, lector);
                }
                using (FileStream fs = new FileStream("discipline.xml", FileMode.Create))
                {
                    xmlf2.Serialize(fs, discipline);
                }
            }
            else
            {
                MessageBox.Show(
                    "Вы не заполнили все необходимые поля!",
                    "Сообщение об ошибке",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }



        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            Lector lector = new Lector();
            Discipline discipline = new Discipline();

            XmlSerializer xmlf1 = new XmlSerializer(lector.GetType());
            XmlSerializer xmlf2 = new XmlSerializer(discipline.GetType());

            using (FileStream fs = new FileStream("lector.xml", FileMode.Open))
            {
                lector = (Lector)xmlf1.Deserialize(fs);
            }
            using (FileStream fs = new FileStream("discipline.xml", FileMode.Open))
            {
                discipline = (Discipline)xmlf2.Deserialize(fs);
            }

            DisplayArea.Text = $"" +
                $"Название дисциплины: {discipline.disciplineName} \n" +
                $"Cеместр: {discipline.semestr} \n" +
                $"Курс: {discipline.cours} \n" +
                $"Специальность: {discipline.speciality} \n" +
                $"Вид Контроля: {discipline.typeOfControl} \n" +
                $"Количество лекций: {discipline.numberOfLectures} \n" +
                $"Количество лабораторных: {discipline.numberOfLabratoryExercises} \n" +
                $"Лектор: \n" +
                $"ФИО: {lector.fullname} \n" +
                $"Кафедра: {lector.department} \n" +
                $"Аудитория: {lector.auditory} \n";

        }
    }

    public class Lector
    {
        public string fullname;
        public string department;
        public string auditory;
    }
    public class Discipline
    {
        public string disciplineName;
        public string semestr;
        public string cours;
        public string speciality;
        public string numberOfLectures;
        public string numberOfLabratoryExercises;
        public string typeOfControl;
    }
}
