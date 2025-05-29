using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace STORE_X.Object 
{
    internal class Customer
    {
        private string _id;
        private string _name;
        private string _phone;
        private string _email;
        private string _address;

        public Customer() { }
        public Customer(string id, string name, string phone, string email, string address)
        {
            this._id = _id;
            this._name = _name;
            this._phone = _phone;
            this._email = _email;
            this._address = _address;
        }

        public string Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }

        public string Phone { get => _phone; set => _phone = value; }
        public string Email { get => _email; set => _email = value; }
        public string Address { get => _address; set => _address = value; }


       
    }
}
