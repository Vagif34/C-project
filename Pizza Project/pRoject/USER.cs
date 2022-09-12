using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza_Project.pRoject
{
    class USER
    {
        private decimal _id;
        private string _name;
        private string _surname;
        private string _username;
        private string _pasword;
        private bool _isAdmin;


        public decimal Id;
        public USER()
        {
            _id++;
            Id = _id;
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value != null)
                {
                    _name = value;
                }
            }
        }
        public string SurName
        {
            get
            {
                return _surname;
            }
            set
            {
                if (value != null)
                {
                    _surname = value;
                }
            }
        }
        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                if (value != null)
                {
                    _username = value;
                }
            }
        }
        public string Pasword
        {
            get
            {
                return _pasword;
            }
            set
            {
                if (value != null)
                {
                    _pasword = value;
                }
            }
        }
        public bool IsAdmin { get; set; }
        
    }
}
