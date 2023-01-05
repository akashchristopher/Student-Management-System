using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class completion_status
    {
        string _iscomplete;
        public string Iscomplete
        {
            get { return _iscomplete; }
            set { _iscomplete = value; }
        }
        public override string ToString()
        {
            return string.Format("course complete status : {0}",this.Iscomplete);
        }
    }
}
