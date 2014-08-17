using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge
{
    /*
    * Bridge Pattern
    * 
    * Definition: Decouple an abstraction from its implementation so that the two can vary independently.
    */
    class Program
  {
    static void Main(string[] args)
    {
      Character mario = new Mario();
      mario.Effect = new FireEffect();

      Character luigi = new Luigi();
      luigi.Effect = new PropellerEffect();

      Console.WriteLine("Name: {0} \nDescription: {1} \nEffect description: {2} \nEffect damage: {3}\n",
        mario.Name, mario.Description, mario.GetEffectDescription(), mario.GetDamageType());

      Console.WriteLine("Name: {0} \nDescription: {1} \nEffect description: {2} \nEffect damage: {3}\n",
        luigi.Name, luigi.Description, luigi.GetEffectDescription(), luigi.GetDamageType());

      Console.WriteLine("Press enter to exit.");
      Console.ReadLine();

      /* Output:
      Name: Mario
      Description: Happy italian plumber dude
      Effect description: Shooting fireballs
      Effect damage: Fire Damage

      Name: Luigi
      Description: Mario's brother
      Effect description: Flying around with a propeller head
      Effect damage: No extra damage
      */
    }
  }
}
