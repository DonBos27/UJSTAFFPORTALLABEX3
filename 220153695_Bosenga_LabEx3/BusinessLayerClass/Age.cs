using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerClass
{
    internal class Age
    {
        public Age() { }
        //This class will perform calculation of the age that will go from 0-99
        public string CalculateAge(string id)
        {
            //initialize the year by taking the first two number of the ID NUMBER that we consider as the birthdate
            int year = Convert.ToInt32(id.Substring(0, 2));
            //initialize a variable that will take the current year which is 2023 and calculate the modulers to get 23
            int currentYear = DateTime.Now.Year % 100;
            //check if the birthdate is greater than the current year if so the we add year by 1900
            //(will go from 24-99 as year) 
            if (year > currentYear)
            {
                year += 1900;
            }
            // else we will add year by 2000 (will go from 00-23 as year)
            else
            {
                year += 2000;
            }
            //the calculation of the age 
            int age = DateTime.Now.Year - year;
            return age.ToString();
        }
    }
}
