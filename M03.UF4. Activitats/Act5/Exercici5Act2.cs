using System;
using OOPEx;

namespace Activitats
{
    public class Card : AColorExercici5Act2
    {
        private int number;

        public Card(string color, int number) : base(color)
        {
            this.SetNumber(number);
        }

        public int GetNumber()
        {
            return this.number;
        }

        public void SetNumber(int number)
        {
            this.number = number;
        }

    }

    public class Lamp : AColorExercici5Act2
    {
        private int watts;
        public Lamp(string color, int watts) : base(color)
        {
            this.SetWatts(watts);
        }
        public int GetWatts()
        {
            return this.watts;
        }
        public void SetWatts(int watts)
        {
            this.watts = watts;
        }
    }

    public class Flight
    {
        private string origin;
        private string destination;
        private int duration;

        public Flight(string origin, string destination, int duration)
        {
            this.SetOrigin(origin);
            this.SetDestination(destination);
            this.SetDuration(duration);
        }

        public string GetOrigin()
        {
            return this.origin;
        }
        public string GetDestination()
        {
            return this.destination;
        }
        public int GetDuration()
        {
            return this.duration;
        }
        public void SetOrigin(string origin)
        {
            this.origin = origin;
        }

        public void SetDestination(string destination)
        {
            this.destination = destination;
        }
        public void SetDuration(int duration)
        {
            this.duration = duration;
        }
    }
}