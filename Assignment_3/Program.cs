namespace Assignment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1  Overloading, Overriding, and Binding 
            #region What is the difference between Method Overloading and Method Overriding? 
            // Method Overloading --> provide multiple methods with the same name but different parameter lists, defined in same class
            // Method Overriding --> provide a new implementation of a method that is already defined in a base class, defined in derived class
            #endregion

            #region What is the difference between Static Binding and Dynamic Binding?
            // Static Binding --> the method to be called is determined at compile time based on the type of the reference
            // Dynamic Binding --> the method to be called is determined at runtime based on the actual type of the object
            #endregion
            #endregion

            #region Q2  Sealed Classes and Methods
            // purpose of the sealed keyword when applied to a class --> to prevent other classes from inheriting from it
            // purpose of the sealed keyword when applied to a method --> to prevent derived classes from overriding it
            // Can a sealed method be overridden? --> No, a sealed method cannot be overridden in derived classes.
            #endregion


        }
    }
}
