using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
  public class Leaf<T> : Component<T>
  {

    public override void Add(Component<T> component)
    {
      throw new Exception("Cannot add to a leaf");
    }

    public override string Display()
    {
      return "- " + this.Name;
    }

    public override void Remove(Component<T> component)
    {
      throw new Exception("Cannot remove from a leaf");
    }

    public override Component<T> Find(string name)
    {
      throw new Exception("Cannot find from a leaf");
    }
  }
}
