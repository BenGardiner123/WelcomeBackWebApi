using System;
using System.Collections.Generic;
using System.Linq;

namespace WelcomeBackTasks
{

    class PalindromicStuff
    {   

        public bool PalindromeCheck(int number){
            //  this function turns the int into a char array and reversese using LINQ built in functions
            string resultHolder;

            resultHolder = number.ToString();

            var forwardArray = resultHolder.ToCharArray();

            var reversArray = forwardArray.Reverse().ToArray();

            var isPalindrome = Enumerable.SequenceEqual(forwardArray, reversArray);

            return isPalindrome;

        }
        public int PalindromeMin(int num)
        {
            double initmaxValue;
            double initminValue;

            List<int> resultsList = new List<int>();

            initmaxValue = Math.Pow(10,(num)) - 1;
            initminValue = Math.Floor(1 + initmaxValue / 10);

            int maxValue = Convert.ToInt32(initmaxValue);

            int minValue = Convert.ToInt32(initminValue);


            // get two numbers which are the minimum for num x 2 
            int result = 0;
            
            for (int i = maxValue; i > minValue; i--)
            {

                for (int j = maxValue; j > minValue; j--)
                {
                    result = i * j;
                    bool test = PalindromeCheck(result);
                   
                    if(test)
                    {
                        
                        resultsList.Add(result);
                        // add to the palindrome list

                    }

                }
                
            } 

            int outputMin;
            int outputMax;

            outputMin = resultsList.Min();
            outputMax = resultsList.Max();

            // System.Console.WriteLine($"Lowest palendrome was {outputMin} , Highest was {outputMax}");
            return outputMin;
        }

            public int PalindromeMax(int num)
        {
            double initmaxValue;
            double initminValue;

            List<int> resultsList = new List<int>();

            initmaxValue = Math.Pow(10,(num)) - 1;
            initminValue = Math.Floor(1 + initmaxValue / 10);

            int maxValue = Convert.ToInt32(initmaxValue);

            int minValue = Convert.ToInt32(initminValue);


            // get two numbers which are the minimum for num x 2 
            int result = 0;
            
            for (int i = maxValue; i > minValue; i--)
            {

                for (int j = maxValue; j > minValue; j--)
                {
                    result = i * j;
                    bool test = PalindromeCheck(result);
                   
                    if(test)
                    {
                        
                        resultsList.Add(result);
                        // add to the palindrome list

                    }

                }
                
            } 

            int outputMin;
            int outputMax;

            outputMin = resultsList.Min();
            outputMax = resultsList.Max();

            // System.Console.WriteLine($"Lowest palendrome was {outputMin} , Highest was {outputMax}");
            return outputMax;
        }

    }

}