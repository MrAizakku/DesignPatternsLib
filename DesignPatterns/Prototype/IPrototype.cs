using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Prototype
{
    //The Prototype pattern is a creational design pattern that allows you to create new objects by copying an existing object, known as a prototype. 
    /*
    Object Creation: The primary purpose of the Prototype pattern is to provide a way to create new objects by copying an existing object, known as a prototype. This allows you to create new objects without specifying their exact class or initializing them. It can be particularly useful when creating complex objects or objects with many configuration options.

    Reducing Coupling: The Prototype pattern reduces the coupling between the client code and the specific classes of objects to be created. Clients work with prototypes through a common interface, which abstracts the concrete class details.

    Cloning Objects: It provides a mechanism for object cloning. The cloned objects are copies of the original prototype, and they can be modified independently. This is especially valuable when you want to create multiple similar objects with slight variations.

    Performance: In some cases, object creation can be expensive, involving database queries, file I/O, or complex calculations. By using the Prototype pattern, you can create new objects by copying an existing one, which can be more efficient than creating them from scratch.

    Customization and Configuration: It allows for object customization and configuration by changing the cloned objects' properties. Instead of setting all the configuration options manually, you can clone a prototype and make specific adjustments.

    Dynamic Object Creation: The Prototype pattern enables dynamic creation of objects based on runtime requirements. You can have multiple prototypes available and choose which one to clone based on the situation.

    Complex Object Structures: It is useful when dealing with complex object structures or hierarchies. By cloning an existing object, you can create similar objects with the same structure.

    Undo and Redo Functionality: The Prototype pattern can be used to implement undo and redo functionality in applications. By storing a history of object states (prototypes), you can revert to previous states.

    Testing and Isolation: When testing code, it may be advantageous to work with cloned objects that are isolated from the original ones. This helps prevent unintended side effects during testing.
    */
    // Prototype interface
    public interface IPrototype
    {
        IPrototype Clone();
    }
}
