using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            attendance at = new attendance();
            at.Date = "04-01-2023";
            at.Day_order = 'A';
            at.Hour = 'P';
            Console.WriteLine(at);
            Console.WriteLine("");
           

            completion_status cs = new completion_status();
            cs.Iscomplete = "completed";
            Console.WriteLine(cs);
            Console.WriteLine("");
            

            fees_management fm = new fees_management();
            fm.Regno = 21855;
            fm.Stud_name = "akash";
            fm.Amount_paid_for = "forth sem";
            fm.Amount = 25000;
            fm.Transaction_id = 409600108017;
            Console.WriteLine(fm);
            Console.WriteLine("");

            performance_tracking pt = new performance_tracking();
            pt.Quarterly = "good";
            pt.Half_yearly = "bad";
            pt.Annaual = "average";
            Console.WriteLine(pt);
            Console.WriteLine("");

        }
    }
}
