using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class performance_tracking
    {
        string _quarterly;

        public string Quarterly
        {
            get { return _quarterly; }
            set { _quarterly = value; }
        }

        string _half_yearly;
        public string Half_yearly
        {
            get { return _half_yearly; }
            set { _half_yearly = value; }
        }

        string _annaual;

        public string Annaual
        {
            get { return _annaual; }
            set { _annaual = value; }
        }

        public override string ToString()
        {
            return string.Format("quarterly performance : {0} \t  half_yearly performance : {1} \t annual performance : {2}",this._quarterly,this._half_yearly,this._annaual);
        }
    }
}
