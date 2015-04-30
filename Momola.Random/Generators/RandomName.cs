using System;
using System.Collections.Generic;
using Momola.Random.Abstraction;
using Momola.Random.Enums;
using Momola.Random.Storage;

namespace Momola.Random.Generators
{
    public class RandomName : RandomGenderString
    {
        public RandomName(IGenderStringStorage storage) : base(storage)
        {
        }
    }
}
