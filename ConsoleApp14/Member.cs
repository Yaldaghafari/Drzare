using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    public class Member
    {
        public string Name { get; set; }
        public string MemberID {  get; set; }
        public string Phone {  get; set; }
       

        public void GetMemberName()
        {
            Console.WriteLine($"Name is:{Name}, and MemberID{MemberID}, and Phone{Phone}");
        }    

    }
}
