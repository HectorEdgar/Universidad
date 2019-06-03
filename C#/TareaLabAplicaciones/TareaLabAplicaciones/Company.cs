using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaLabAplicaciones
{
    class Company
    {
        private String name;
        private String location;

        public Company()
        {

        }
        public Company(string name, string location)
        {
            this.name = name;
            this.location = location;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Location
        {
            get
            {
                return location;
            }

            set
            {
                location = value;
            }
        }
    }
}
