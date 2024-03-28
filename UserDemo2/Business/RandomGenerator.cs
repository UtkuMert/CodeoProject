using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDemo2.Business
{
    public static class RandomGenerator
    {
        public static string GenerateRandomUserName()
        {
            Random res = new Random();
            String random = "";

            String str = "abcdefghijklmnopqrstuvwxyz";
            int size = res.Next(4, 15); 


            for (int i = 0; i < size; i++)
            {

                // Selecting a index randomly 
                int x = res.Next(26);

                // Appending the character at the  
                // index to the random string. 
                random = random + str[x];
            }

            return random;
        }

        public static string GenerateRandomPassword()
        {
            Random res = new Random();

            // String that contain both alphabets and numbers 
            String str = "abcdefghijklmnopqrstuvwxyz0123456789";
            int size = res.Next(4, 25);

            // Initializing the empty string 
            String random = "";

            for (int i = 0; i < size; i++)
            {

                // Selecting a index randomly 
                int x = res.Next(str.Length);

                // Appending the character at the  
                // index to the random alphanumeric string. 
                random = random + str[x];
            }

            return random;
        }
    }
}
