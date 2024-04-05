using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite
{
    /*
    Hierarchy Representation: When you have a hierarchical structure, such as a tree or a group of objects within objects, the Composite pattern allows you to represent this structure in a natural and intuitive way. It provides a way to model complex relationships.

    Uniformity: The pattern enables you to treat individual objects and compositions of objects uniformly. Clients can work with both single objects and groups of objects without needing to know the details of the objects' structure. This simplifies the client code.

    Recursive Behavior: If you need to apply an operation recursively to all elements of a hierarchy, the Composite pattern is well-suited. You can perform the same operation on individual elements and on composite elements (containers) without distinguishing between them in client code.

    Flexibility: It allows you to add or remove objects dynamically from a composition. This is particularly useful when the structure can change at runtime, and you want a consistent way to manipulate it.

    Complex Graphic Systems: In graphics and drawing applications, the Composite pattern is often used to represent complex graphical elements. You can group basic shapes (leaves) into more complex shapes (composites) and apply transformations uniformly.

    File Systems: In file systems, directories (composites) can contain both files (leaves) and subdirectories (composites). The Composite pattern is used to navigate and manipulate the file system structure uniformly.

    Menu Systems: In graphical user interfaces, menu structures can be represented using the Composite pattern. Menus can contain menu items, submenus, and separators, all of which can be treated uniformly.

    Organization Structures: In organizational hierarchies, you can use the Composite pattern to represent employees and organizational units. This allows you to apply operations at various levels of the hierarchy.

    Mathematical Expressions: In mathematical expression evaluation, you can use the Composite pattern to represent expressions as a tree structure. It simplifies the evaluation process by applying the same rules recursively.
    */
    // Composite
    public class Composite_ : Component
    {
        private List<Component> children = new List<Component>();

        public Composite_(string name) : base(name) { }

        public void Add(Component component)
        {
            children.Add(component);
        }

        public void Remove(Component component)
        {
            children.Remove(component);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + name);

            foreach (var child in children)
            {
                child.Display(depth + 2);
            }
        }
    }
}
