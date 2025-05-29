using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STORE_X.Object
{
    internal class Employee
    {
        private string _idE;
        private string _nameE;
        private string _phoneE;
        private string _emailE;
        private string _addressE;

        public Employee() { }
        public Employee(string idE, string nameE, string phoneE, string emailE, string addressE)
        {
            this._idE = idE;
            this._nameE = nameE;
            this._phoneE = phoneE;
            this._emailE = emailE;
            this._addressE = addressE;
        }

        public string IdE { get => _idE; set => _idE = value; }
        public string NameE { get => _nameE; set => _nameE = value; }
        public string PhoneE { get => _phoneE; set => _phoneE = value; }
        public string EmailE { get => _emailE; set => _emailE = value; }
        public string AddressE { get => _addressE; set => _addressE = value; }
    }
}
