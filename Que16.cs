using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40Questions
{
    struct Dimensions
    {
        // 1.
        public decimal Length { get; set; }
        public decimal Width { get; set; }
        public decimal Height { get; set; }

        public Dimensions(decimal length, decimal width, decimal height)
        {
            if (length <= 0 || width <= 0 || height <= 0)
                throw new ArgumentException("Enter positive values!");

            Length = length;
            Width = width;
            Height = height;
        }

        // 2. calc volume 
        public decimal Volume()
        {
            return Length * Width * Height;
        }
    }
    // 4.
    class Parcel
    {
        public Dimensions ParcelDim { get; set; }

        public Parcel(Dimensions parcelDim) { 
            ParcelDim= parcelDim;
        }
    }
    public class Que16
    {   
        public static void Run()
        {
            // 3. 
            Dimensions dim1 = new Dimensions(10, 20, 25);
            Dimensions dim2 = dim1;
            dim2.Length = 15;

            Console.WriteLine("Dimension 1: "+dim1);
            Console.WriteLine("Copy of Dimension 1: " + dim2);

            // 4.
            Parcel parcel = new Parcel(dim1);
            Parcel parcel2 = parcel;

            Console.WriteLine("Parcel 1: " + parcel);
            Console.WriteLine("Copy of Parcel 1: " + parcel2);
        }
    }
}
