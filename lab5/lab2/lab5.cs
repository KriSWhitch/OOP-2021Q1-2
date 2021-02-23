using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace lab2
{
    public partial class lab5 : Form
    {
        public Form1 mainForm;
        public lab5(Form1 form)
        {
            InitializeComponent();
            mainForm = form;
            mainForm.Enabled = false;
        }

        //позволяет объектам с несовместимыми интерфейсами работать вместе.
        #region Adapter 
        interface IPen
        {
            string Write();
        }

        class Pen : IPen
        {
            public string Write()
            {
                return "Ручкой пишет";
            }
        }//ghostly messanger

        interface IChalk
        {
            string Draw();
        }

        class Chalk : IChalk
        {
            public string Draw()
            {
                return "Мелом пишет";
            }
        }

        class Student
        {
            public string Stuff(IPen stuff)
            {
                return stuff.Write();
            }
        }



        class ChalkToPenAdapter : IPen
        {
            Chalk chalk;
            public ChalkToPenAdapter(Chalk c)
            {
                chalk = c;
            }

            public string Write()
            {
                return chalk.Draw();
            }
        }
        #endregion

        #region Decorator
        abstract class Cake
        {
            public Cake(string n)
            {
                this.Name = n;
            }

            public string Name { get; protected set; }
            public abstract int GetCost();
        }

        class AppleCake : Cake
        {
            public AppleCake() : base("Яблочный пирог")
            { }
            public override int GetCost()
            {
                return 6;
            }
        }

        class ChocolateCake : Cake
        {
            public ChocolateCake()
                : base("Шоколадный пирог")
            { }
            public override int GetCost()
            {
                return 10;
            }
        }

        abstract class CakeDecorator : Cake
        {
            protected Cake Cake;
            public CakeDecorator(string n, Cake Cake) : base(n)
            {
                this.Cake = Cake;
            }
        }

        class DeliveryCake : CakeDecorator
        {
            public DeliveryCake(Cake p)
                : base(p.Name + ", с доставкой", p)
            { }

            public override int GetCost()
            {
                return Cake.GetCost() + 5;
            }
        }

        class ThereCake : CakeDecorator
        {
            public ThereCake(Cake p)
                : base(p.Name + ", есть на месте", p)
            { }

            public override int GetCost()
            {
                return Cake.GetCost() - 1;
            }
        }
        #endregion


        private void lab5_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.Enabled = true;
        }

        private void Adapter_Click(object sender, EventArgs e)
        {
            lab5Display.Text = "";
            Student student = new Student();

            Pen pen = new Pen();
            lab5Display.Text += student.Stuff(pen) + "\r\n";
            lab5Display.Text += "Оп... В ручке стержень закончился \r\n";

            Chalk chalk = new Chalk();
            IPen chalkStuff = new ChalkToPenAdapter(chalk);
            lab5Display.Text += student.Stuff(chalkStuff) + "\r\n";
        }

        private void Decorator_Click(object sender, EventArgs e)
        {
            lab5Display.Text = "";
            Cake Cake1 = new AppleCake();
            Cake1 = new DeliveryCake(Cake1);
            lab5Display.Text += String.Format("Название: {0}\r\n", Cake1.Name);
            lab5Display.Text += String.Format("Цена: {0}\r\n", Cake1.GetCost());

            Cake Cake2 = new AppleCake();
            Cake2 = new ThereCake(Cake2);
            lab5Display.Text += String.Format("Название: {0}\r\n", Cake2.Name);
            lab5Display.Text += String.Format("Цена: {0}\r\n", Cake2.GetCost());

            Cake Cake3 = new ChocolateCake();
            Cake3 = new DeliveryCake(Cake3);
            lab5Display.Text += String.Format("Название: {0}\r\n", Cake3.Name);
            lab5Display.Text += String.Format("Цена: {0}\r\n", Cake3.GetCost());

            Cake Cake4 = new ChocolateCake();
            Cake4 = new ThereCake(Cake4);
            lab5Display.Text += String.Format("Название: {0}\r\n", Cake4.Name);
            lab5Display.Text += String.Format("Цена: {0}\r\n", Cake4.GetCost());
        }
    }
}
