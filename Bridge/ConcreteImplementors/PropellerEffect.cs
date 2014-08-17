using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge
{
  // Concrete Implementor
  public class PropellerEffect : Effect
  {
    public override string Description
    {
      get { return "Flying around with a propeller head"; }
    }

    public override string Damage
    {
      get { return "No extra damage"; }
    }
  }
}
