using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    class School
    {
        
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }
        private string _twitterAddress;
        public string TwitterAddress
        {
            //make sure the twitter address starts with @
            // Add backing variable
            get { return _twitterAddress; }
            set
            {
                if (value.StartsWith("@"))
                {
                    _twitterAddress = value;
                }
                else
                {
                    throw new Exception("the Twitter address must begin with @");
                }
            }

        }
        // Constructor
        public School()
        {
            Name = "Untitled School";
            PhoneNumber = "555-1234";
            
        }
        // Example of an overloaded constructors
        public School(string SchoolName, string SchoolPhoneNumber)
        {
            Name = SchoolName;
            PhoneNumber = SchoolPhoneNumber;
        }
        public float AverageThreeScores(float a, float b, float c)
        {
            var result = (a + b + c) / 3;
            return result;
        }
        // Overloaded Methods - AverageScore is the Name, int is the return type, Parenthese are a method on an object - arguments are in betwwen
        // Need to pass in the type for your arguments
        // If you use a VOID - you do not need to use the return statmente
        public static float AverageThreeScoresLambda(float a, float b, float c) => (a + b + c) / 3;
        
        public static int AverageThreeScores(int a, int b, int c)
        {
            
            var result = (a + b + c) / 3;
            return result;
        }
    }
}
