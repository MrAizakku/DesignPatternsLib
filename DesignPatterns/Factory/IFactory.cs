using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    /*
    The Factory pattern is used to create objects without exposing the instantiation logic to the client. It provides an interface for creating objects but lets subclasses or concrete factories decide which class to instantiate. It is often used when you have different subtypes of objects that need to be created  
    */
    public interface IFactory
    {
        IProduct CreateProduct();
    }

}
