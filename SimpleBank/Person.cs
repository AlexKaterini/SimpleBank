using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleBank
{
    public class Person
    {
        private int _id;
        private string _name;
        private string _address;

        public Person()
        {

        }

        public Person(int id, string name, string address)
        {
            _id = id;
            _name = name;
            _address = address;
        }

        public override string ToString()
        {
            return $"id = {_id} name = {_name} address = {_address}";
        }
    }
}
