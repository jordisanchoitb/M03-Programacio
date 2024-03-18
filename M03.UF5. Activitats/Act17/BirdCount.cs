using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace OOPEx
{
    public class BirdCount
    {
        static public int[] CountBirdsLastWeek { get; set; } = [0, 2, 5, 3, 7, 8, 4];
        public int[] CountBirds { get; set; }

        public BirdCount(int[] countBirds)
        {
            this.CountBirds = countBirds;
        }

        public BirdCount() : this(new int[7])
        {
        }

        public static int[] LastWeek()
        {
            return CountBirdsLastWeek;
        }

        public int Today()
        {
            return this.CountBirds[this.CountBirds.Length-1];
        }

        public bool HasDayWithoutBirds()
        {
            return this.CountBirds.Contains(0);
        }

        public int CountForFirstDays(int limitday)
        {
            int iterator = 0;
            int count = 0;
            while (iterator < limitday)
            {
                count += this.CountBirds[iterator];
                iterator++;
            }
            return count;
        }

        public int BusyDays()
        {
            int iterator = 0;
            int busyDays = 0;
            while (iterator < this.CountBirds.Length)
            {
                if (this.CountBirds[iterator] >= 5)
                {
                    busyDays++;
                }
                iterator++;
            }
            return busyDays;
        }

        public void IncrementTodaysCount()
        {
            this.CountBirds[this.CountBirds.Length-1]++;
        }
    }
}
