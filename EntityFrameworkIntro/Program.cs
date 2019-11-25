using EntityFrameworkIntro.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkIntro
{
    class Program
    {
        static void Main(string[] args) //Context
        {
           

        }

        static void PrintAllCompanies()
        {
            using(var context = new EF.WtfDoICallThis())
            {
                foreach (tbl_Company company in context.tbl_Company)
                {
                    Console.WriteLine("");
                }
            }
        }
    }
}
