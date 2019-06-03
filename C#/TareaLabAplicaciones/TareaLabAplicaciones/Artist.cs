using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaLabAplicaciones
{
    class Artist
    {
        private String name;
        private String sales;
        private Company company;

        public Artist()
        {
            name = "";
            sales = "";
            company = new Company();
        }

        public Artist(string name, string sales, Company company)
        {
            this.Name = name;
            this.Sales = sales;
            this.Company = company;
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

        public string Sales
        {
            get
            {
                return sales;
            }

            set
            {
                sales = value;
            }
        }

        internal Company Company
        {
            get
            {
                return company;
            }

            set
            {
                company = value;
            }
        }

        
    }
}
