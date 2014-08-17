using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge
{
  // Abstraction
  public class Character
  {
    // reference to Implementor
    private Effect _effect;

    public Effect Effect { get { return _effect; } set { _effect = value; } }

    // Character's name and description
    public string Name { get; set; }
    public string Description { get; set; }

    // Operation
    public string GetDamageType()
    {
      return _effect.Damage;
    }

    // Operation
    public string GetEffectDescription()
    {
      return _effect.Description;
    }
  }
}
