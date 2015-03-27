using System;
using Momola.Random.Enums;

namespace Momola.Random.Abstraction
{
    public interface IRandomName
    {
        String GetRandom();
        String GetRandom(Gender gender);
    }
}

