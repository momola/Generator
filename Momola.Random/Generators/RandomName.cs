﻿using System;
using Momola.Random.Abstraction;

namespace Momola.Random.Generators
{
    public class RandomName : IRandomName
    {
        public string GetRandom()
        {
            return null; // test commit
        }

        public string GetRandom(Enums.Gender gender)
        {
            throw new NotImplementedException();
        }
    }
}
