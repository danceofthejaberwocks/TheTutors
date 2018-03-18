using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheTutors.People
{
    class Tutors
    {
       
        public string firstName;
        public string lastName;
        public int cost;
        private int EarnedCredit(int payMe)
        {
            int a = 0;
            a = payMe + a;
            return a;
        }
        
        public  string credit(int y)
        {
            y = EarnedCredit(y);
                return $"{firstName} {lastName} has earned {y}";
        }
        
    }
}
