using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubMaybe
{
    public class Paper
    {
        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                if(value <= 0)
                {
                    return;
                }

                _height = value;
            }
        }
        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }

                _width = value;
            }
        }
        public string Color
        {
            get
            {
                return _color;
            }
            set
            {
                if(Color == string.Empty)
                {
                    return;
                }

                _color = value;
            }
        }
        public string Material
        {
            get
            {
                return _material;
            }
            set
            {
                if (Color == string.Empty)
                {
                    return;
                }

                _material = value;
            }
        }
        public double Thicness
        {
            get
            {
                return _thicness;
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }

                _thicness = value;
            }
        }

        public string AllInfo
        {
            get
            {
                return string.Format("Paper is {0} cm high, {1} cm wide, is {2} color, made from {3} material and is {4} thicc.", this.Height, this.Width, this.Color, this.Material, this.Thicness);
            }
        }
      
        private int _height = 8;
        private int _width = 4;
        private string _color = "White";
        private string _material = "Oak wood";
        private double _thicness = 0.2;


        public Paper()
        {
            this.Height = 17;
            this.Width = 9;
            this.Color = "Blue";
            this.Material = "Cotton candy";
            this.Thicness = 5.7;
        }

        public Paper(int Height, int Width, string Color, string Material, double Thicness)
        {
            this.Height = Height;
            this.Width = Width;
            this.Color = Color;
            this.Material = Material;
            this.Thicness = Thicness;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            //Paper PaperWan = new Paper();
            Paper MoreDetailed = new Paper(-100, -6, "not red", "oakland", -0.05);
            MoreDetailed.Material = "Cyann";
            //Console.WriteLine(PaperWan.AllInfo);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(MoreDetailed.AllInfo);
            Console.ReadKey();
        }
    }
}
// Ankh-svn plugin