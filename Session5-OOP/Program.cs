namespace Session5_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 — Theoretical Questions

            #region Q1  Object Copying
            //a) What happens when you assign one object variable to another object variable?
            //copy the reference 

            //b) Does assigning one object to another create a new object? Explain.
            //No,it only copies the reference to the object and both variables point to the same object in heap

            //c) What is the difference between copying an object and copying its reference?
            //copying object : create a new object with the same data
            //copying reference : two variables point to the same object and not create a new object

            #endregion

            #region Q2  Shallow Copy vs Deep Copy
            //a) What is a Shallow Copy?
            //create new object and copies all value type fields as actual data, for reference type fields only the reference are copied - both objects point to the same object

            //b) What is a Deep Copy?
            //create new object and copies all nested objects,the original and the copy are independent

            //c) What happens to reference-type members when a Shallow Copy is created?
            //the original and the copy objects share the same object

            //d) What happens to reference-type members when a Deep Copy is created?
            //the original and the copy objects are independent 

            //e) Give one situation where Deep Copy would be safer than Shallow Copy.
            //when the copy object must be independent from the original,especially when it contains reference type members may be modified without changing the original object

            #endregion

            #region Q3  Static Members
            //a) What is a static field, and how is it different from an instance field?
            //static field belongs to the class itself and one copy shared by all objects
            //instance field belongs to object and each object has its own copy

            //b) What is a static method? Can a static method directly access instance members?
            //static method belongs to the class and it accessed using the class name
            //static method cannot directly access instance members because instance members belong to specific object

            //c) What is a static constructor, and when is it executed?
            //static constructor initializes static members,it cannot take any parameters
            //it executed only one time automatically by CLR before first use of class

            //d) What is a static class? Can you create an object from a static class?
            //static class contains static members and cannot be instantiated
            //no,cannot create an object from a static class because the static members are accessed using the class name

            #endregion

            #region Q4  Extension Methods
            //a) What is an Extension Method?
            //let me to add new method to existing types without modifying the original type or creating a new derived type

            //b) What keyword must be used in the first parameter of an extension method?
            //this keyword 

            //c) Where must an extension method be declared?
            //inside a static class

            //d) Can an extension method access private members of the class it extends?
            //no

            #endregion
            #endregion

            #region Q4  Extension Methods


            #endregion
        }
    }
}
