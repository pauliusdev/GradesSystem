using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades {

    class Program {
        static void Main(string[] args) {
            GradeBook book = new GradeBook();
            GradeBook book1 = book;
            GradeBook book2 = book;
            GradeStatistics stats = book.ComputeStatistics();
            book.AddGrade(113);
        }
    }
    //Dude tryDude = new Dude(22);
    //tryDude.IsGenius.GetType();
    //public class Dude {
    //    public Dude(int iq) {
    //        this.IQ = iq;
    //    }
    //    public int IQ { get; set; }
    //    public bool IsGenius => IQ > 130;
    //}

    public class Dude {
        public Dude(int iq) {
            this.IQ = iq;
        }
        public int IQ { get; set; }
    }
}
