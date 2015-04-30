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
    public class RandomAbstract: IRandomName
    {

        private int countValues;
        private System.Random myRandom= new System.Random();
        private int randValue;
        private string returnName;
        private PolishNames Lista = new PolishNames();

        public string GetRandom()
        {
            countValues = Lista.NameList.Count;
            randValue = myRandom.Next(countValues);
            returnName = Lista.NameList[randValue].Name;
            return returnName;
        }

        public string GetRandom(Enums.Gender gender)
        {
            List<GenderString> genderList = Lista.NameList.Where(n => n.Gender == gender).ToList();
            countValues = genderList.Count;
            randValue = myRandom.Next(countValues);
            returnName = genderList[randValue].Name;
            return returnName;
        }
    }
}
