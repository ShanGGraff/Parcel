using System.Collections.Generic;

namespace Parcel.Models
{
  public class Parcel
  {
    //Need constructors
    //getters and setters for each property
    //should be able to create parcel and specify dimensions and weight in arguments
    //volume method Volume() called on Parcel instance that should return the porduct of the sides
      public int Width { get; set; }
      public int Length { get; set; }
      public int Height { get; set; }
      public int Weight { get; set; }

    public Parcel(int width, int length, int height, int weight) 
    {
      Width = width;
      Length = length;
      Height = height;
      Weight = weight;
    }

    public int Volume()
    { 
      int volume = Width + Length + Height;
      return volume;
    }

    public int CostToShip()
    {
      
    }
  }
}