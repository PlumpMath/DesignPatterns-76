using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge
{
  // Implementor
  public abstract class Effect
  {
    // OperationImp
    public abstract string Description { get; }

    // OperationImp    
    public abstract string Damage { get; }
  }
}
