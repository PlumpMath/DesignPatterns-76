using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge
{
  // Concrete Implementor
  public class FireEffect : Effect
  {
    public override string Description
    {
      get { return "Shooting fireballs"; }
    }

    public override string Damage
    {
      get { return "Fire Damage"; }
    }
  }
}
