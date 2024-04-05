using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FlyWeight
{
    /*
     Flyweights, by design, are meant to share common intrinsic state to minimize memory usage. To achieve this, they often require a centralized context, such as a factory, to manage and provide access to shared objects. The centralized context ensures that the same Flyweight object is reused when multiple parts of the application request an object with the same intrinsic state.

      The centralized context, typically a factory or some form of a registry, is responsible for creating and managing Flyweight objects. It maintains a collection of created Flyweights and ensures that they are shared appropriately.
    */
    public interface IFlyweight
    {
        void Operation();
    }

}
