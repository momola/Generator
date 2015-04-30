using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Momola.Random.Abstraction
{
    public interface IRandomDate
    {
        DateTime GetRandom();
        DateTime GetRandom(DateTime startDate, DateTime endDate);
        DateTime GetRandom(int year);
        DateTime GetRandom(int year, int month);


    }
}
