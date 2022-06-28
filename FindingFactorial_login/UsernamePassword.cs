using System;
using System.Collections.Generic;
using System.Text;

namespace nothing
{
    class UsernamePassword
    {
       

        public Tuple<string,string> Login(string username, string password)
        {
            if (password == "12345")
            {
                Console.WriteLine("Girish olundu");

            }
            else
            {
                Console.WriteLine("Mail ve ya shifre yanlishdir");
            }
            return Tuple.Create(username, password);


        }
        
        

    }
}
