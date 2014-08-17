using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
  public class Composite<T>: Component<T>
  {
    List<Component<T>> componentList = new List<Component<T>>();

    public override void Add(Component<T> component)
    {
      componentList.Add(component);
    }

    public override string Display()
    {
      StringBuilder sb = new StringBuilder();

      sb.Append("Group: ");
      sb.AppendLine(this.Name);

      foreach (var item in componentList)
      {
        sb.AppendLine(item.Display());
      }
      return sb.ToString();
    }

    public override void Remove(Component<T> component)
    {
      componentList.Remove(component);
    }

    public override Component<T> Find(string name)
    {
      return componentList.FirstOrDefault(c => c.Name.Equals(name));
    }
  }
}
