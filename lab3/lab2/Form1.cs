using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace lab2
{
    
    public partial class Form1 : Form
    {
        public bool completenessFlag = false;
        public bool validateFlag = false;
        public List<DisciplineForSerialize> tempDisciplines;
        public List<DisciplineForSerialize> resultDisciplines;
        Timer timer;
        Timer timerForCountDisciplines;
        Timer timerForLastAction;
        public string lastAction;

        public Form1()
        {
            InitializeComponent();

            timer = new Timer() { Interval = 1000 };
            timer.Tick += timer_Tick;
            timer.Start();
            timerForCountDisciplines = new Timer() { Interval = 1000 };
            timerForCountDisciplines.Tick += timerDisciplinesCount_Tick;
            timerForCountDisciplines.Start();
            timerForLastAction = new Timer() { Interval = 1000 };
            timerForLastAction.Tick += timerLastAction_Tick;
            timerForLastAction.Start();
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


            if (completenessFlag && validateFlag)
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

                Serialize(lector, discipline);
                lastAction = "Сохранение данных";
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
            tempDisciplines = Deserialize();
            lastAction = "Загрузка данных";
            DisplayArea.Text = "";
            foreach (DisciplineForSerialize discipline in tempDisciplines)
            {
                DisplayArea.Text += $"" +
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

        }

        public void Serialize(Lector lector, Discipline discipline)
        {
            DisciplineForSerialize serializeMe = new DisciplineForSerialize(lector, discipline);
            List<DisciplineForSerialize> disciplinesForSerialize;
            if (File.Exists("data.xml")) disciplinesForSerialize = Deserialize();
            else disciplinesForSerialize = new List<DisciplineForSerialize>();
            disciplinesForSerialize.Add(serializeMe);
            XmlSerializer xmlf = new XmlSerializer(disciplinesForSerialize.GetType());

            using (FileStream fs = new FileStream("data.xml", FileMode.OpenOrCreate))
            {
                xmlf.Serialize(fs, disciplinesForSerialize);
            }
        }

        public List<DisciplineForSerialize> Deserialize()
        {
            List<DisciplineForSerialize> disciplinesForSerialize = new List<DisciplineForSerialize>();

            XmlSerializer xmlf = new XmlSerializer(disciplinesForSerialize.GetType());

            using (FileStream fs = new FileStream("data.xml", FileMode.OpenOrCreate))
            {
                disciplinesForSerialize = (List<DisciplineForSerialize>)xmlf.Deserialize(fs);
            }

            return disciplinesForSerialize;
        }

        private void Menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MenuSearch_Click(object sender, EventArgs e)
        {
            SearchForm form = new SearchForm(this);
            form.ShowDialog();
        }

        private void MenuSort_Click(object sender, EventArgs e)
        {
            SortForm form = new SortForm(this);
            form.ShowDialog();
        }

        private void MenuSave_Click(object sender, EventArgs e)
        {
            if (resultDisciplines != null)
            {
                using (Stream f = new FileStream("SearchOrSort.xml", FileMode.OpenOrCreate))
                {
                    XmlSerializer serializer = new XmlSerializer(resultDisciplines.GetType());
                    serializer.Serialize(f, resultDisciplines);
                }
                lastAction = "Сохранение данных";
            }
            else
            {
                MessageBox.Show(
                    "Вы не выполнили сортировку/поиск по для того чтобы сохранить последний резальутат данных операций!",
                    "Сообщение об ошибке",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void MenuAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Version 1.0 ©Муковозчик Алексей Витальевич",
                "О программе",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        public void Error_Checker(object sender, EventArgs e)
        {
            TextBox text = (TextBox)sender;
            if ((new Regex(@"^[0-9]+$")).IsMatch(text.Text))
            {
                text.ForeColor = Color.Black;
                validateFlag = true;
            }
            else
            {
                text.ForeColor = Color.Red;
                validateFlag = false;
            }
        }

        private void ClearTool_Click(object sender, EventArgs e)
        {
            DisplayArea.Text = "";
            lastAction = "Очистка дисплея";
        }

        private void DeleteTool_Click(object sender, EventArgs e)
        {
            tempDisciplines = null;
            lastAction = "Удаление данных";
        }

        void timer_Tick(object sender, EventArgs e)
        {
            DateLabel.Text = DateTime.Now.ToLongDateString();
            TimeLabel.Text = DateTime.Now.ToLongTimeString();
        }

        void timerDisciplinesCount_Tick(object sender, EventArgs e)
        {
            if (tempDisciplines != null) DisciplinesInMemory.Text = $"{tempDisciplines.Count()}";
            else DisciplinesInMemory.Text = "0";
        }
        void timerLastAction_Tick(object sender, EventArgs e)
        {
            if (lastAction == null) LastAction.Text = "-";
            else
            {
                LastAction.Text = lastAction;
            }
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
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Количество лекций должно быть задано числом!")] // так могут выглядеть атрибуты регулярных выражений
        public string numberOfLectures;
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Количество лабораторных работ должно быть задано числом!")]
        public string numberOfLabratoryExercises;
        public string typeOfControl;
    }
    
    [Serializable]
    public class DisciplineForSerialize
    {
        public Lector Lector { get; set; }
        public Discipline Discipline { get; set; }

        public DisciplineForSerialize()
        {

        }

        public DisciplineForSerialize(Lector lector, Discipline discipline)
        {
            Lector = lector;
            Discipline = discipline;
        }

    }


}
