using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza_Project.pRoject
{
    class Product
    {
        private static decimal _id;
        private string _name;
        private string _ingrident;
        private decimal _price;


        public decimal ID {get;}
        public Product()
        {
            _id++;
            _id = ID;
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if(value != null)
                {
                    _name = value;
                }
            }
        }
        static bool Checkname(string Name)
        {
            if (!string.IsNullOrWhiteSpace(Name))
            {
                for (int i = 0; i < Name.Length; i++)
                {
                    if (!Char.IsDigit(Name[i]))
                    {
                        return false;
                    }

                }
                return true;
            }
            return false;
        }
        public string Ingrident
        {
            get
            {
                return _ingrident;
            }
            set
            {
                if (value != null)
                {
                    _ingrident=value;
                }
            }
        }
        public decimal Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
            }
        }
        
    }
}
