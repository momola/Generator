using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Momola.Random.Abstraction;

namespace Momola.Random.Generators
{
   public class RandomDate: IRandomDate
    {
        private System.Random MyRandom= new System.Random();
        public DateTime myDate= new DateTime();
        public TimeSpan mySpan = new TimeSpan();
        private int howDays;
        private int randValue;

        
        public DateTime GetRandom()
        {
           randValue= MyRandom.Next(10000);
           myDate = myDate.Date;
           myDate = myDate.AddDays(-randValue);
           return myDate;

        }

        public DateTime GetRandom(DateTime startDate, DateTime endDate)
        {
            mySpan = startDate - endDate;
            howDays=mySpan.Days;
            randValue= MyRandom.Next(howDays);
            myDate= startDate.AddDays(randValue);
            return myDate;
        }

        public DateTime GetRandom(int year)
        {
            myDate = myDate.AddYears(year);
            howDays=myDate.DayOfYear;
            randValue = MyRandom.Next(howDays);
            myDate= myDate.AddDays(1);
            myDate= myDate.AddMonths(1);
            myDate= myDate.AddDays(randValue);
            return myDate;
        }

        public DateTime GetRandom(int year, int month)
        {
            myDate = myDate.AddYears(year);
            myDate = myDate.AddMonths(month);
            howDays = myDate.Month;
            randValue = MyRandom.Next(howDays);
            myDate = myDate.AddDays(1);
            myDate = myDate.AddDays(randValue);
            return myDate;
        }
    }
}
