using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class JSONForrmatter : IFormatter
    {
        private readonly string _userEmail;
        private readonly LogStatus _status;

        public JSONForrmatter( string _userEmail , LogStatus _status)
        {
            _userEmail = userEmail;
            _status = status;
        }
        public string Format()
        {
            return string.Format("[\n\t[user]:[{0}],\n[status]:[{1}]\n[time]:[{2}]\n]\n", _userEmail, _status, DateTime.Now);
        }
    }
}
    