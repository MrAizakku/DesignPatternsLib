using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Adapter;
using DesignPatterns.Builder;
using DesignPatterns.ChainOfResponsibility;
using DesignPatterns.Command;
using DesignPatterns.Composite;
using DesignPatterns.Decorator;
using DesignPatterns.Factory;
using DesignPatterns.FlyWeight;
using DesignPatterns.Memento;
using DesignPatterns.Observer;
using DesignPatterns.Prototype;
using DesignPatterns.Proxy;
using DesignPatterns.Singleton;
using DesignPatterns.State;
using DesignPatterns.Strategy;
using DesignPatterns.Template;
using DesignPatterns.Visitor;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            /*******************
             *     OBSERVER    *
             *******************
            Subject is the subject (observable) that maintains a list of observers and a state. When the state changes, it notifies all its observers.
            IObserver is the observer interface that defines the Update method, which is called when the subject's state changes.
            ConcreteObserverA and ConcreteObserverB are concrete observer classes that implement the IObserver interface. They subscribe to the subject and respond to state changes.
            In the Main method, we create a subject and two concrete observers (observerA and observerB). We change the subject's state, and both observers receive updates. We also demonstrate detaching an observer (observerB), and it no longer receives updates. */
            Header("OBSERVER");
            WeatherStation weatherStation = new WeatherStation();

            NewsAgency agency1 = new NewsAgency("Alpha News Agency");
            weatherStation.Attach(agency1);

            NewsAgency agency2 = new NewsAgency("Beta News Agency");
            weatherStation.Attach(agency2);

            NewsAgency agency3 = new NewsAgency("Charlie News Agency");
            weatherStation.Attach(agency3);

            weatherStation.Temperature = 31.2f;
            weatherStation.Temperature = 30.0f;
            weatherStation.Temperature = 29.7f;
            weatherStation.Temperature = 26.2f;

            Console.ReadLine();

            /*******************
             *    FLYWEIGHT    *
             *******************
            IFlyweight is the Flyweight interface that defines the Operation method. The method takes an extrinsicState, which is the state that can vary between objects.
            ConcreteFlyweight is a concrete implementation of the Flyweight interface. It contains an intrinsic state that remains the same for all instances.
            FlyweightFactory is responsible for managing and sharing flyweight objects. It uses a dictionary to store and retrieve flyweights by their intrinsic state.
            Here, we create a FlyweightFactory and obtain two flyweight objects, "A" and "B". We then use these flyweights and pass different extrinsic states to the Operation method. */
            Header("FLYWEIGHT");
            FlyweightFactory factory = new FlyweightFactory();

            IFlyweight flyweight1 = factory.GetFlyweight("A");
            IFlyweight flyweight2 = factory.GetFlyweight("B");
            IFlyweight flyweight3 = factory.GetFlyweight("A");

            flyweight1.Operation(); // ConcreteFlyweight: A
            flyweight2.Operation(); // ConcreteFlyweight: B
            flyweight3.Operation(); // ConcreteFlyweight: A

            // You can see that flyweight3 is the same object as flyweight1, sharing intrinsic state.
            Console.ReadLine();

            /********************
             *      FACTORY     *
             ********************
            IProduct is the product interface, which defines the method Create() that will be implemented by concrete products.
            ConcreteProductA and ConcreteProductB are concrete product classes that implement the IProduct interface. They represent different types of products that can be created.
            IFactory is the factory interface, which defines the CreateProduct() method for creating products.
            ConcreteFactoryA and ConcreteFactoryB are concrete factory classes that implement the IFactory interface. They create specific types of products.
            In the Main method, we create instances of concrete factories (ConcreteFactoryA and ConcreteFactoryB) and use them to create products (ConcreteProductA and ConcreteProductB) based on the factory type. */
            Header("FACTORY");
            IFactory factoryA = new ConcreteFactoryA();
            IProduct productA = factoryA.CreateProduct();
            productA.ShowInfo(); // Output: Product A

            IFactory factoryB = new ConcreteFactoryB();
            IProduct productB = factoryB.CreateProduct();
            productB.ShowInfo(); // Output: Product B

            Console.ReadLine();


            /********************
             *      BUILDER     *
             ********************
            Product represents the complex object you want to build. It has two parts, Part1 and Part2, and a ShowInfo method to display its details.
            IBuilder is the builder interface that defines methods for building different parts of the product and retrieving the final result.
            ConcreteBuilder is a concrete builder class that implements the IBuilder interface. It constructs the product by building its parts and provides a method to get the result.
            Director is responsible for coordinating the construction process. It takes a builder as a parameter and instructs it on how to build the product.
            In the Main method, we create a ConcreteBuilder, a Director, and use the director to construct a product. The director tells the builder to build Part1 and Part2, and the resulting product is displayed. */
            Header("BUILDER");
            IPersonBuilder builder = new PersonBuilder();
            PersonDirector director = new PersonDirector(builder);

            Person person = director.BuildPerson();
            person.DisplayInfo();

            Console.ReadLine();



            /********************
             *     SINGLETON    *
             ********************
            We create a Singleton class with a private constructor to prevent external instantiation.
            We define a private static field instance to hold the single instance of the class.
            We expose a public static property Instance that checks whether an instance exists or not. If an instance doesn't exist, it creates one, and if it already exists, it returns the existing instance.
            The SomeMethod is just an example of a method in the Singleton class. */
            Header("SINGLETON");
            Singleton_ instance1 = Singleton_.Instance;
            Singleton_ instance2 = Singleton_.Instance;

            Console.WriteLine($"Are the singleton instances the same? {((instance1 == instance2) ? "yer" : "ner")}"); // Should be true, as they refer to the same instance


            instance1.SomeMethod(); // Call a method on the Singleton instance

            Console.ReadLine();

            /********************
             *      MEMENTO     *
             ********************
            Originator is the object whose state we want to save and restore.
            Memento is a class that represents the saved state of the Originator.
            Caretaker is a class that keeps track of the saved mementos.
            Here we demonstrate how to set the state of the Originator, create mementos, change the state, and restore the state from a memento. */
            Header("MEMENTO");
            // Create an originator
            Originator originator = new Originator();

            // Create a caretaker
            Caretaker caretaker = new Caretaker();

            // Set the initial state and save a memento
            originator.State = "State 1";
            caretaker.AddMemento(originator.CreateMemento());

            // Change the state and save another memento
            originator.State = "State 2";
            caretaker.AddMemento(originator.CreateMemento());

            // Restore the first state from the memento
            originator.RestoreMemento(caretaker.GetMemento(0));

            Console.WriteLine("Current state: " + originator.State);

            Console.ReadLine();

            /********************
             *     DECORATOR    *
             ********************
            IComponent is the interface for the component that we want to decorate.
            ConcreteComponent is the concrete component that implements IComponent.
            Decorator is the base class for decorators, which also implements IComponent.
            ConcreteDecoratorA and ConcreteDecoratorB are concrete decorators that add behavior to the component.
            */
            Header("DECORATOR");
            // Create a Concrete Component
            IComponent component = new ConcreteComponent();
            component.Operation();

            Console.WriteLine();

            // Decorate the component with Concrete Decorator A
            IComponent decoratedA = new ConcreteDecoratorA(component);
            decoratedA.Operation();

            Console.WriteLine();

            // Decorate the component with Concrete Decorator B
            IComponent decoratedB = new ConcreteDecoratorB(component);
            decoratedB.Operation();

            Console.ReadLine();

            /********************
             *     COMPOSITE    *
             ********************
            Component is an abstract class that defines the common interface for both leaf and composite objects.
            Leaf represents individual objects that don't have children. It inherits from Component and implements the Display method.
            Composite represents composite objects that can contain other components, including both leaves and sub-composites. It also inherits from Component and implements the Display method, which recursively displays the hierarchy of components.
            Here a tree structure is created, and components are added to the composite structure. The Display method is called on the root, which cascades the display operation through the entire hierarchy.  */
            Header("COMPOSITE");
            // Create a tree structure
            var root = new Composite_("Root");
            root.Add(new Leaf("Leaf A"));
            root.Add(new Leaf("Leaf B"));

            var composite = new Composite_("Composite X");
            composite.Add(new Leaf("Leaf XA"));
            composite.Add(new Leaf("Leaf XB"));

            root.Add(composite);

            var leaf = new Leaf("Leaf C");
            root.Add(leaf);

            // Display the tree
            root.Display(0);

            Console.ReadLine();

            /********************
             *     COMMAND    *
             ********************
            Light represents the receiver, the object on which the commands will be executed.
            ICommand is the command interface that defines the Execute method.
            TurnOnCommand and TurnOffCommand are concrete command classes that encapsulate the operations to turn the light on and off.
            RemoteControl acts as the invoker and maintains a list of commands. It can set and execute the commands. */
            Header("COMMAND");

            Light light = new Light();
            ICommand turnOn = new TurnOnCommand(light);
            ICommand turnOff = new TurnOffCommand(light);

            RemoteControl remote = new RemoteControl();

            remote.SetCommand(turnOn);
            remote.PressButton(); // Turns the light on

            remote.SetCommand(turnOff);
            remote.PressButton(); // Turns the light off

            Console.ReadLine();

            /********************
             *     PROTOTYPE    *
             ********************
            IPrototype is an interface that defines a Clone method to create a copy of the object. The Clone method is used to create a shallow copy of the object using the MemberwiseClone method.
            ConcretePrototype is a concrete prototype class that implements the IPrototype interface. It contains a property called Number to demonstrate the cloning process.
            Here a prototype object is created, cloned, and then modified. The output shows the original and cloned objects. */
            Header("PROTOTYPE");

            // Create a prototype object
            IPrototype prototype = new ConcretePrototype { Number = 42 };

            // Clone the prototype
            IPrototype clone = prototype.Clone();

            // Modify the clone
            if (clone is ConcretePrototype concreteClone)
            {
                concreteClone.Number = 99;
            }

            // Output original and cloned objects
            Console.WriteLine("Original Prototype: " + prototype.GetType().Name + " - Number: " + ((ConcretePrototype)prototype).Number);
            Console.WriteLine("Cloned Prototype: " + clone.GetType().Name + " - Number: " + ((ConcretePrototype)clone).Number);

            Console.ReadLine();

            /********************
             *       PROXY      *
             ********************
            ISubject is an interface that both the RealSubject and Proxy implement. It defines the Request method, which the proxy will control access to.
            RealSubject is the real object that performs the actual work. In this case, it simply outputs a message.
            Proxy is the proxy class that implements the ISubject interface. It has a reference to the real subject (lazy-initialized), and it controls access to the real subject by performing additional operations before and after delegating the request to the real subject.
            We create a proxy object and call the Request method through the proxy. The proxy takes care of pre-processing, forwarding the request to the real subject, and post-processing. */
            Header("PROXY");

            // Create a proxy
            Proxy.ISubject proxy = new Proxy_();

            // Call the request method through the proxy
            proxy.Request();

            Console.ReadLine();

            /********************
             *      ADAPTER     *
             ********************
            ITarget is the target interface that the client code expects.
            Adaptee is an existing class with an incompatible interface.
            ClassAdapter is a class adapter that derives from Adaptee and implements the ITarget interface. It adapts the SpecificRequest method of Adaptee to the Request method expected by the client.
            ObjectAdapter is an object adapter that contains an instance of Adaptee and implements the ITarget interface. It adapts Adaptee by delegating the Request method to the SpecificRequest method of the contained Adaptee object.
            We demonstrate using both the class adapter and object adapter to adapt the Adaptee to the ITarget interface and make a request.
            */

            Header("ADAPTER");
            // Using a Class Adapter
            ITarget classAdapter = new ClassAdapter();
            classAdapter.Request();

            // Using an Object Adapter
            Adaptee adaptee = new Adaptee();
            ITarget objectAdapter = new ObjectAdapter(adaptee);
            objectAdapter.Request();

            Console.ReadLine();

            /***************************
             * CHAIN OF RESPONSIBILITY *
             ***************************
            IHandler is the handler interface that defines the methods for setting a successor handler and handling requests.

            ConcreteHandler is a concrete handler class that implements the IHandler interface. It can handle requests if they are within a certain range, and it passes the request to the successor if necessary.

            In the Main method, we create two ConcreteHandler objects and set the successor in the chain. We then make requests to the first handler, which forwards the request to the next handler if it cannot handle it. */
            Header("CHAIN OF RESPONSIBILITY");

            // Create handler objects
            IHandler handler1 = new ConcreteHandler();
            IHandler handler2 = new ConcreteHandler();

            // Set the successor in the chain
            handler1.SetSuccessor(handler2);

            // Handle requests
            handler1.HandleRequest(5);  // Request 5 handled by ConcreteHandler.
            handler1.HandleRequest(12); // Request 12 cannot be handled.

            Console.ReadLine();

            /*************
             *   STATE   *
             *************
            Context is the context class that maintains a reference to the current state and delegates the request to the state object.

            IState is the state interface that defines the Handle method, which concrete states implement to handle requests.

            ConcreteStateA and ConcreteStateB are concrete state classes that implement the IState interface. They handle requests differently based on their specific behavior.

            In the Main method, we create a Context with an initial state of ConcreteStateA. We then perform requests using the current state and change the state to ConcreteStateB to demonstrate the state transition. */
            Header("STATE");

            State.Context context = new State.Context(new ConcreteStateA());

            // Perform requests using the current state
            context.Request();

            // Change the state and perform another request
            context.SetState(new ConcreteStateB());
            context.Request();

            Console.ReadLine();


            /**************
             *  STRATEGY  *
             **************
            IStrategy is the strategy interface that defines the Execute method, which concrete strategies implement.

            ConcreteStrategyA and ConcreteStrategyB are concrete strategy classes that implement the IStrategy interface. They define specific algorithms that can be executed.

            Context is the context class that contains a reference to the current strategy. It can change the strategy and execute it.

            In the Main method, we create a Context with an initial strategy of ConcreteStrategyA, execute the current strategy, and then change the strategy to ConcreteStrategyB to demonstrate the strategy change.*/
            Header("STRATEGY");
            // Create context with an initial strategy
            Strategy.Context context2 = new Strategy.Context(new ConcreteStrategyA());

            // Execute the current strategy
            context2.ExecuteStrategy();

            // Change the strategy and execute it
            context2.SetStrategy(new ConcreteStrategyB());
            context2.ExecuteStrategy();

            Console.ReadLine();

            /**************
             *  VISITOR   *
             **************
            IElement is the element interface that defines the Accept method, which allows elements to accept visitors.

            ConcreteElementA and ConcreteElementB are concrete element classes that implement the IElement interface. They provide their specific operations and accept visitors.

            IVisitor is the visitor interface that defines the Visit methods for different types of elements.

            ConcreteVisitor is a concrete visitor class that implements the IVisitor interface. It performs specific operations on elements.

            ObjectStructure is the object structure that contains a list of elements. It provides methods to attach elements and accept visitors.

            In the Main method, we create an object structure, attach elements, and use a concrete visitor to visit the elements in the object structure.*/
            Header("VISITOR");

            ObjectStructure objectStructure = new ObjectStructure();
            objectStructure.Attach(new ConcreteElementA());
            objectStructure.Attach(new ConcreteElementB());

            ConcreteVisitor visitor = new ConcreteVisitor();
            objectStructure.Accept(visitor);

            Console.ReadLine();

            /***************
             *  TEMPLATE   *
             ***************
            AbstractClass is an abstract class that defines a template method TemplateMethod. The template method calls several abstract methods (Operation1, Operation2, and Operation3) that subclasses must implement.

            ConcreteClass1 and ConcreteClass2 are concrete subclasses that inherit from AbstractClass. They implement the abstract methods to provide their specific implementations.

            In the Main method, we create instances of both concrete classes, call the TemplateMethod, and see how each concrete class's specific implementation is invoked as part of the template method.*/
            Header("TEMPLATE");

            AbstractClass template1 = new ConcreteClass1();
            template1.TemplateMethod();

            Console.WriteLine();

            AbstractClass template2 = new ConcreteClass2();
            template2.TemplateMethod();

            Console.ReadLine();
        }

        public static void Header(string section)
        {
            int width = section.Length + 6; // Adjust the width as needed

            string border = new string('*', width);
            string paddedText = $"*  {section}  *"; // Centered padding

            Console.WriteLine(border);
            Console.WriteLine(paddedText);
            Console.WriteLine(border);
        }
    }
}