using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
  public abstract class Component<T>
  {
    public string Name { get; set; }

    public abstract string Display();
    public abstract void Add(Component<T> component);
    public abstract void Remove(Component<T> component);
    public abstract Component<T> Find(string name);

  }
}
