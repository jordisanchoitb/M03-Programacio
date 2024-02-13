using System;

namespace OOPEx
{
    public class Colour
    {
        private string colourName;
        const int MaxValue = 255;
        const int MinValue = 0;
        const string DefaultName = "No name";

        private int red;
        private int green;
        private int blue;

        public Colour(string name, int red, int green, int blue)
        {
            ColourName = name;
            Red = red;
            Green = green;
            Blue = blue;
        }

        public Colour(int red, int green, int blue)
        {
            ColourName = DefaultName;
            Red = red;
            Green = green;
            Blue = blue;
        }
        public Colour(string name)
        {
            ColourName = name;
            Red = MinValue;
            Green = MinValue;
            Blue = MinValue;
        }

        public Colour()
        {
            ColourName = DefaultName;
            Red = MinValue;
            Green = MinValue;
            Blue = MinValue;
        }

        string ColourName
        {
            get { return colourName; }
            set
            {
                colourName = value;
            }
        }

        public int Red
        {
            get { return red; }
            set
            {
                if (value >= MinValue && value <= MaxValue)
                {
                    red = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Red value must be between 0 and 255");
                }
            }
        }

        public int Green
        {
            get { return green; }
            set
            {
                if (value >= MinValue && value <= MaxValue)
                {
                    green = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Green value must be between 0 and 255");
                }
            }
        }

        public int Blue
        {
            get { return blue; }
            set
            {
                if (value >= MinValue && value <= MaxValue)
                {
                    blue = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Blue value must be between 0 and 255");
                }
            }
        }


        public void ForeColour()
        {
            throw new NotImplementedException();

        }
        public void BackgroundColour()
        {
            throw new NotImplementedException();
        }

    }
}
