using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Momola.Random.Model;

namespace Momola.Random.Abstraction
{
    public interface IGenderStringStorage
    {
        List<GenderString> List { get; }

    }
}
