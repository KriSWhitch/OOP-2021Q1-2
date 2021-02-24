using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{
    interface IPen
    {
        string Write();
    }

    class Pen : IPen
    {
        public string Write()
        {
            return "Ученик пишет ручкой";
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
            return "Ученик пишет мелом";
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
}
