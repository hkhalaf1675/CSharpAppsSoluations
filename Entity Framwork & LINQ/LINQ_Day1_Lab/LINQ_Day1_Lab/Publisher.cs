using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ_Day1_Lab
{
  public class Publisher
  {
    public String Name {get; set;}
    public String WebSite {get; set;}

    public override string ToString()
    {
      return Name;
    }
  }
}
