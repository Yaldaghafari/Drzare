using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    public class Book
    {
        public string Title {  get; set; }
        public string Author {  get; set; }
        public string Year{  get; set; }
        public string ISBN {  get; set; }


        public void GetBookTitle()
        {
            Console.WriteLine($"Name is:{Title}, and Author:{Author}, and Year:{Year}, and ISBN:{ISBN} ");
        }

     
    }
}
