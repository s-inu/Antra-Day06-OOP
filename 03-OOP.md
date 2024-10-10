1. What are the six combinations of access modifier keywords and what do they do? 

  - `public`: Members are accessible from any other code in the same assembly or another assembly that references it.

  - `private`: Members are only accessible within the same class or struct.

  - `protected`: Members are accessible within their own class or in derived classes.

  - `internal`: Members are accessible within any code in the same assembly, but not from another assembly.

  - `protected internal`: Members are accessible within the same assembly or in derived classes in another assembly.

  - `private protected`: Members are accessible within its own class or in derived classes located in the same assembly.



2. What is the difference between the static, const, and readonly keywords when applied to a type member?

   - `static`: This keyword denotes that a member belongs to the type itself rather than to instances of the type. This means you can access the member without creating an instance of the class.

   - `const`: Const members are implicitly static and must be initialized with a constant value at the time of their declaration. They cannot be modified after their initial declaration and assignment.

   - `readonly`: Readonly members can be initialized either at the time of declaration or within a constructor of the same class. They can only be assigned values during declaration or in the constructor, which makes them useful for runtime constants.



3. What does a constructor do?
   - A constructor is a special method in a class or struct that is called when an instance of the class or struct is created. Constructors are used to initialize the instance's data, and they might take parameters that are used to set initial values.



4. Why is the partial keyword useful?
   - The `partial` keyword allows the definition of a class, struct, or method to be split across multiple files. 



5. What is a tuple?
   - A tuple is a data structure that contains a sequence of elements of different types. Tuples are useful for returning multiple values from a method without creating a struct or class to hold them.



6. What does the C# record keyword do?
   - The `record` keyword defines a reference type that provides built-in functionality for value-based equality checks and other useful features like with-expressions for non-destructive mutation.



7. What does overloading and overriding mean?
   - **Overloading** refers to the concept where two or more methods in the same scope have the same name but different parameters (either in type, number, or both). Overloading allows methods to perform similar functions but with different types or numbers of inputs.
   - **Overriding** is a feature that allows a subclass to provide a specific implementation of a method that is already defined in its superclass. This process is part of polymorphism, where the method in the subclass will be called instead of the one in the superclass, provided that the method call is made through a superclass reference.



8. What is the difference between a field and a property?
   - **Field**: A field is a variable declared at the class level. Fields are meant to store data that is a characteristic of the class. Fields can be public, but it's generally best practice to make fields private to enforce encapsulation and expose them through properties.
   - **Property**: A property acts as a public interface to access a field in a class. Properties use accessors (`get` and `set`) that control how a field can be read and modified. They can enforce logic when data is retrieved or assigned. For example, you can validate data in a setter before assigning it to a field.



9. How do you make a method parameter optional?
   - providing default value. e.g `void F(string msg="")`



10. What is an interface and how is it different from abstract class?
    - **Interface**: An interface is a contract that defines what methods and properties a class must implement, without specifying how these methods and properties should be implemented. Interfaces cannot contain field declarations or method bodies. They are ideal when various unrelated classes need to perform the same actions.
    - **Abstract Class**: An abstract class can provide both complete (methods with bodies) and incomplete (abstract methods without bodies) methods, as well as fields and properties. Abstract classes are used when several related classes share some common functionality, but they also need to have their unique implementations of other functionalities.



11. What accessibility level are members of an interface?
    - all members of an interface are implicitly `public`, and you cannot specify any other accessibility level



12. True/False. 
    Polymorphism allows derived classes to provide different implementations of the same method.
    - T



13. True/False. 
    The override keyword is used to indicate that a method in a derived class is providing its own implementation of a method.
    - T



14. True/False. 
    The new keyword is used to indicate that a method in a derived class is providing its own implementation of a method.
    - T



15. True/False. 
    Abstract methods can be used in a normal (non-abstract) class. 
    - F



16. True/False. 
    Normal (non-abstract) methods can be used in an abstract class. 
    - T



17. True/False.
    Derived classes can override methods that were virtual in the base class. 
    - T



18. True/False.
    Derived classes can override methods that were abstract in the base class. 
    - T



19. True/False.
    In a derived class, you can override a method that was neither virtual non abstract in the base class.
    - F



20. True/False. 
    A class that implements an interface does not have to provide an implementation for all of the members of the interface.
    - F



21. True/False. 
    A class that implements an interface is allowed to have other members that aren’t defined in the interface.
    - T



22. True/False. 
    A class can have more than one base class.
    - F



23. True/False. 
    A class can implement more than one interface.
    - T