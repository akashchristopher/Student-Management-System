using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class attendance
    {
        string _date;
        public string Date
        {
            get { return _date; }
            set { _date = value; }
        }

        char _day_order;
        public char Day_order
        {
            get { return _day_order; }
            set { _day_order = value; }
        }

        char _hour;
        public char Hour
        {
            get { return _hour; }
            set { _hour = value; }
        }

        public override string ToString()
        {
            return string.Format("Date : {0} \t Day Order : {1} \t Att Status : {2} " ,this.Date ,this.Day_order,this.Hour);
        }


    }
}
