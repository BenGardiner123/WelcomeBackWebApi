using System.Collections.Generic;
using System.Linq;

namespace WelcomeBackTasks
{
    class DividingThingy
    {
       

        public void remaindeCheck(int max)
        {   
            
            // candidtate numbers can be stored here
            List<int> CanBeDividedByAll = new List<int>();

            int counter = 1;
            int mainInt = 3000;

            for (int i = 1; i <= max; i++)
            {
               
                // check if there is remainder
                var noRemainder = mainInt % i;
               
                if (noRemainder == 0)
                {
                    
                    counter++;

                    if(counter == max )
                    {
                        CanBeDividedByAll.Add(mainInt);   
                    }


                }
                else {

                    mainInt--;
                    i = 1;
                    counter = 1;

                }

                
            }

            int outputMin = CanBeDividedByAll.Min(); 
            System.Console.WriteLine($"The smallest positive number that can be divided by each number from 1 to {max} is {outputMin}");  

        }

    }

}