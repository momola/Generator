using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Momola.Random.Enums;

namespace Momola.Random.Model
{
    class GenderString
    {
        public string Name;
        public Gender Gender;

        public GenderString(string name, Gender gender)
        {
            Name = name;
            Gender = gender;
        }
    }
}
