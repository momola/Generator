using System;
using System.Collections.Generic;
using Momola.Random.Abstraction;
using Momola.Random.Enums;


namespace Momola.Random.Generators
{
    public class RandomName : IRandomName
    {
        private int countValues;
        System.Random myRandom= new System.Random();
        private int randValue;
        private string returnName;
        private List<string> nameList;

        public RandomName()
        {
          nameList=new List<string>();
          nameList.Add("Adrianna");
          nameList.Add("Alicja");
          nameList.Add("Adam");
          nameList.Add("Amadeusz");
        }


        



        public string GetRandom()
        {
         countValues =nameList.Count;
         randValue = myRandom.Next(countValues);
         returnName = nameList[randValue];
         return returnName;
            
        }

        public string GetRandom(Enums.Gender gender)
        {
            if (gender == Gender.Female){
                countValues = nameList.Count;
                randValue = myRandom.Next(countValues/2);
                returnName = nameList[randValue];
                return returnName;
            }
            else if (gender == Gender.Male){
                countValues = nameList.Count;
                randValue = myRandom.Next(countValues/2, countValues+1);
                returnName = nameList[randValue];
                return returnName;
                
            }
            else
            {
            throw new NotImplementedException();
            }

            
        }
    }
}
