using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge
{
  // Concrete Implementor
  public class IceEffect : Effect
  {
    public override string Description
    {
      get { return "Shooting balls of ice"; }
    }

    public override string Damage
    {
      get { return "Ice damage"; }
    }
  }
}
