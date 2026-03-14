#region Part 01

#region Q1
// What is an interface in C#? 
//interface is a reference type that defines a contract for classes and structs to follow

//Why do we use interfaces instead of depending on concrete classes directly? 
//Interfaces allow for loose coupling between classes not like the abstract classes that are tightly coupled to the implementation of the class

//Mention at least three benefits of using interfaces.
// 1. Interfaces allow for multiple inheritance
// 2. Interfaces promote code reusability and Loose coupling
// 3. Interfaces provide a way to achieve polymorphism

#endregion
#region Q2

//A: need explicit interface implementation as it doesn't know which method to call

//B: Two solutions to solve this problem are:
// 1. Explicit interface implementation: ((IEnglishSpeaker)translator).Speak(); , ((IArabicSpeaker)translator).Speak();
// 2. Create new objects for each interface:
//  Translator translator = new Translator();
// IEnglishSpeaker englishSpeaker = translator , IArabicSpeaker arabicSpeaker = translator;

//C: No we cannot call the Speak method directly on the person object because it is not clear which Speak method to call,
//as both interfaces have a method with the same name.
//We need to use explicit interface implementation or create new objects for each interface to resolve this ambiguity.

#endregion
#region Q3

// Shallow copy is a copy of an object that copies the reference to the original object, while deep copy creates a new object and copies all the values of the original object to the new object.
// If we want just a copy for reading or writing we can use shallow copy, but if we want to modify the copy without affecting the original object we should use deep copy.
// shallow copy has higher risk than deep copy because if we modify the copy it will affect the original object.

#endregion
#region Q4

// Will print :
// Dev - Testing
// QA - Testing


#endregion

#endregion

#region Part 02



#endregion