using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Momola.Random.Enums;
using Momola.Random.Model;
using Momola.Random.Storage;
using System.Linq;

namespace Momola.Random.Abstraction
{
    public class RandomGenderString: IRandomGenderString
    {

        private int countValues;
        private System.Random myRandom= new System.Random();
        private int randValue;
        private string returnName;
        private readonly IGenderStringStorage storage;

        public RandomGenderString(IGenderStringStorage storage)
        {
            this.storage = storage;
        }

        public string GetRandom()
        {
            countValues = storage.List.Count;
            randValue = myRandom.Next(countValues);
            returnName = storage.List[randValue].Name;
            return returnName;
        }

        public string GetRandom(Enums.Gender gender)
        {
            List<GenderString> genderList = storage.List.Where(n => n.Gender == gender).ToList();
            countValues = genderList.Count;
            randValue = myRandom.Next(countValues);
            returnName = genderList[randValue].Name;
            return returnName;
        }
    }
}
