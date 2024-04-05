using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    /*
    The Decorator design pattern serves several essential purposes in software design:

    Open-Closed Principle: The Decorator pattern adheres to the Open-Closed Principle, which is one of the SOLID principles of object-oriented design. This principle states that a class should be open for extension but closed for modification. With the Decorator pattern, you can add new behaviors or responsibilities to an object without changing its source code. This promotes code stability and minimizes the risk of introducing bugs when extending functionality.

    Single Responsibility Principle: The pattern helps achieve the Single Responsibility Principle, another SOLID principle, by allowing you to separate concerns. Each decorator class is responsible for a specific aspect of behavior, keeping the core component focused on its primary responsibility.

    Code Reusability: Decorators are reusable components. You can use the same decorator classes to add behavior to different components. This reusability reduces code duplication and makes it easier to maintain and extend the system.

    Dynamic Behavior Extension: The Decorator pattern enables dynamic and flexible behavior extension at runtime. You can compose objects with various combinations of decorators, providing more options and adaptability.

    Complex Combinations: You can create complex combinations of decorators to achieve a wide range of functionality by stacking decorators on top of one another. This flexibility allows you to tailor the behavior of an object to specific requirements.

    Maintainability: It helps maintain a clean and modular design. Each decorator class focuses on a specific concern, making the code easier to understand, maintain, and test. Modifications and updates are localized to the respective decorator classes.

    Transparency: From the client's perspective, there is no distinction between a decorated component and the original component. This transparency ensures that clients interact with objects consistently, regardless of the presence of decorators.

    Separation of Concerns: The Decorator pattern separates the concerns of individual behaviors or responsibilities, making it easier to manage and extend the system's functionality.
    */
    // Decorator base class
    public abstract class Decorator : IComponent
    {
        private IComponent component;

        public Decorator(IComponent component)
        {
            this.component = component;
        }

        public virtual void Operation()
        {
            component.Operation();
        }
    }
}
