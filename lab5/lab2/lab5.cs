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

        private void Observer_Click(object sender, EventArgs e)
        {
            lab5Display.Text = "";
            // Клиентский код.
            var subject = new Subject();
            var observerA = new ConcreteObserverA();
            subject.Attach(lab5Display, observerA);

            var observerB = new ConcreteObserverB();
            subject.Attach(lab5Display, observerB);

            subject.SomeBusinessLogic(lab5Display);
            subject.SomeBusinessLogic(lab5Display);

            subject.Detach(lab5Display, observerB);

            subject.SomeBusinessLogic(lab5Display);
        }

        private void Strategy_Click(object sender, EventArgs e)
        {
            lab5Display.Text = "";
            // Клиентский код выбирает конкретную стратегию и передаёт её в
            // контекст. Клиент должен знать о различиях между стратегиями,
            // чтобы сделать правильный выбор.
            var context = new Context();

            lab5Display.Text += "Клиент: Выбрана нормальная сортировка.\r\n";
            context.SetStrategy(new ConcreteStrategyA());
            context.DoSomeBusinessLogic(lab5Display);

            lab5Display.Text += "\r\n";

            lab5Display.Text += ("Клиент: Выбрана обратная сортировка.\r\n");
            context.SetStrategy(new ConcreteStrategyB());
            context.DoSomeBusinessLogic(lab5Display);
        }
    }
}
