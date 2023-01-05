using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class fees_management
    {
        int _regno;
        public int Regno
        {
            get { return _regno; }
            set { _regno = value; }
        }

        string _stud_name;
        public string Stud_name
        {
            get { return _stud_name; }
            set { _stud_name = value; }
        }

        string _amount_paid_for;

        public string Amount_paid_for
        {
            get { return _amount_paid_for; }
            set { _amount_paid_for = value; }
        }

        int _amount;

        public int Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

        long _transaction_id;

        public long Transaction_id
        {
            get { return _transaction_id; }
            set { _transaction_id = value; }
        }

        public override string ToString()
        {
            return string.Format("reg.no : {0} \t  student_name : {1}\t  amount_paid_for : {2} \t  amount : {3}\t  transaction_id : {4}",this.Regno,this.Stud_name,this.Amount_paid_for,this.Amount,this._transaction_id);
        }
    }
}
