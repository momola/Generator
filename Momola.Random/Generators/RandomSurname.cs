using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Momola.Random.Generators
{
    class RandomSurname
    {
         private int countValues;
        private System.Random myRandom;
        private int randValue;
        private string returnSurname;
        private List<string> surnameList;

        public RandomSurname()
        {
          myRandom = new System.Random();
          surnameList=new List<string>();
          surnameList.Add("Nowak");
          surnameList.Add("Kowalski");
          surnameList.Add("Malysz");
         
        }



        public string GetRandom()
        {
         countValues =surnameList.Count;
         randValue = myRandom.Next(countValues);
         returnSurname = surnameList[randValue];
         return returnSurname;
            
        }
    }
}
