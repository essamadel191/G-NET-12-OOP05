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

using G_NET_12_OOP05.TicketBookingSystem;
using G_NET_12_OOP05.TicketBookingSystem.Interfaces;

// a.
Cinema cinema = new Cinema("Star Cinema");
cinema.OpenCinema();
Console.WriteLine();

// b. 
StandardTicket standard = new StandardTicket("Inception", 80, new SeatLocation('A', 5));
VIPTicket vip = new VIPTicket("Avengers", 200, true);
IMAXTicket imax = new IMAXTicket("Dune", 100, true); 

standard.Book();
vip.Book();
imax.Book();

cinema.AddTicket(standard);
cinema.AddTicket(vip);
cinema.AddTicket(imax);

// c. 
cinema.PrintAllTickets();
Console.WriteLine();

// d. 
VIPTicket vipClone = (VIPTicket)vip.Clone();
vipClone.MovieName = "Interstellar";

Console.WriteLine("--- Clone Test ---");
Console.WriteLine("Original : " + vip.ToString());
Console.WriteLine("Clone    : " + vipClone.ToString());
Console.WriteLine();

// e. 
standard.Cancel();
Console.WriteLine("--- After Cancellation ---");
standard.PrintTicket();
Console.WriteLine();

// f. 
BookingHelper.PrintAll(new IPrinting[] { standard, vip, imax });
Console.WriteLine();

// g. 
cinema.CloseCinema();

#endregion