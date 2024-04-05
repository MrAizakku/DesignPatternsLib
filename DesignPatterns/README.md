# Design Patterns Included

## Observer
Subject maintains a list of observers and notifies them when its state changes.
IObserver defines the Update method for observers.
ConcreteObserverA and ConcreteObserverB implement IObserver and respond to state changes.
In the Main method, a subject and two observers are created. State changes are made, and both observers receive updates. Detaching an observer is also demonstrated.

## Flyweight
IFlyweight defines the Operation method, taking extrinsicState.
ConcreteFlyweight implements IFlyweight with intrinsic state.
FlyweightFactory manages and shares flyweight objects.
Instances of flyweights "A" and "B" are created, and different extrinsic states are passed to the Operation method.

## Factory
IProduct defines the Create method implemented by concrete products.
ConcreteProductA and ConcreteProductB represent different products.
IFactory defines CreateProduct for factories.
ConcreteFactoryA and ConcreteFactoryB create specific products.
In Main, instances of concrete factories create products based on factory type.

## Builder
Product has parts (Part1 and Part2) and a ShowInfo method.
IBuilder defines methods for building parts and getting the result.
ConcreteBuilder constructs the product and provides a method to get the result.
Director coordinates construction process.
In Main, a ConcreteBuilder and Director construct a product, and its details are displayed.

## Singleton
Singleton class ensures single instance with private constructor.
Public static property Instance creates or returns the instance.
Example method SomeMethod exists in the Singleton class.

## Memento
Originator's state is saved and restored using Memento.
Caretaker manages saved mementos.
Demonstrates setting state, creating mementos, changing state, and restoring from memento.

## Decorator
IComponent is interface for the component to decorate.
ConcreteComponent implements IComponent.
Decorator is base class for decorators.
ConcreteDecoratorA and ConcreteDecoratorB add behavior to the component.

## Composite
Component defines interface for leaf and composite objects.
Leaf represents individual objects, Composite represents composite objects.
Displays hierarchy of components using the Display method.

## Command
Light is the receiver.
ICommand defines Execute method.
TurnOnCommand and TurnOffCommand encapsulate operations.
RemoteControl acts as invoker and sets/executes commands.

## Prototype
IPrototype defines Clone method for copying objects.
ConcretePrototype implements IPrototype.
Prototype object is created, cloned, and modified. Output shows original and cloned objects.

## Proxy
ISubject defines Request method.
RealSubject performs actual work.
Proxy controls access to RealSubject.
Demonstrates pre-processing, forwarding requests, and post-processing.

## Adapter
ITarget is target interface.
Adaptee has an incompatible interface.
ClassAdapter adapts Adaptee to ITarget.
ObjectAdapter contains Adaptee and adapts it to ITarget.

## Chain of Responsibility
IHandler defines methods for handling requests.
ConcreteHandler implements IHandler and forwards requests if necessary.
Two ConcreteHandler objects are created, and the successor is set. Requests are made to the first handler.

## State
Context maintains current state and delegates requests.
IState defines Handle method for concrete states.
ConcreteStateA and ConcreteStateB handle requests differently.
Context is created with ConcreteStateA, requests are made, and state is changed to ConcreteStateB.

## Strategy
IStrategy defines Execute method for concrete strategies.
ConcreteStrategyA and ConcreteStrategyB implement IStrategy.
Context contains current strategy and can change/execute it.

## Visitor
IElement defines Accept method for visitors.
ConcreteElementA and ConcreteElementB accept visitors.
IVisitor defines Visit methods for elements.
ConcreteVisitor performs operations on elements.
ObjectStructure contains elements, and ConcreteVisitor is used to visit them.

## Template
AbstractClass defines TemplateMethod calling abstract methods.
ConcreteClass1 and ConcreteClass2 implement abstract methods.
Instances of both concrete classes are created, TemplateMethod is called, and specific implementations are invoked.
