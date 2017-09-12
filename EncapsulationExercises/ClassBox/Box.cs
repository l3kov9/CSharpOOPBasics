using System;

namespace ClassBox
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Heigth = height;
        }

        public double GetSurfaceArea()
        {
            return 2 * this.length * this.width + 2 * this.length * this.height + 2 * this.width * this.height;
        }

        public double GetLateralSurfaceArea()
        {
            return 2 * this.length * this.height + 2 * this.width * this.height;
        }

        public double GetVolume()
        {
            return this.length * this.height * this.width;
        }

        private double Length
        {
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(this.Length)} cannot be less zero or negative.");
                }

                this.length = value;
            }
        }

        private double Width
        {
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(this.Width)} cannot be less zero or negative.");
                }

                this.width = value;
            }
        }

        private double Heigth
        {
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(this.Heigth)} cannot be less zero or negative.");
                }

                this.height = value;
            }
        }
    }
}
