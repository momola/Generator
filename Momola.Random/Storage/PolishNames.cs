using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Momola.Random.Enums;
using Momola.Random.Model;

namespace Momola.Random.Storage
{
    class PolishNames
    {
        private List<GenderString> nameList;
        

        public PolishNames()
        {
            nameList = new List<GenderString>()
            {
                new GenderString("Alicja", Gender.Female),
                new GenderString("Karolina", Gender.Female),
                new GenderString("Adam",Gender.Male ),
                new GenderString("Aleksander",Gender.Male),
                new GenderString("Adrianna", Gender.Female),
                new GenderString("Amadeusz",Gender.Male)
            };
        }

        public List<Model.GenderString> NameList
        {
            get { return nameList; }
            
        }
        
    }

}
