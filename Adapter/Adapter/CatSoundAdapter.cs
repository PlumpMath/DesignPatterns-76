using Adapter.Adaptee;
using Adapter.Target;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter.Adapter
{
    public class CatSoundAdapter : IAnimalSounds
    {

        private Dog _adaptee = new Dog();

        public int GetAnimalSoundCatLevel()
        {
            return CatLevel(_adaptee.Bark());
        }

        private int CatLevel(string sound)
        {
            switch (sound)
            {
                case "MEOW!":
                    return 100;
                case "WOOF!":
                    return 0;
                default:
                    return -1;
            }
        }
    }
}
