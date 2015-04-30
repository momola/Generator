using System;
using Momola.Random.Enums;

namespace Momola.Random.Abstraction
{
    public interface IRandomGenderString
    {
        String GetRandom();
        String GetRandom(Gender gender);
    }
}

