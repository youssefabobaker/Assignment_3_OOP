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

            #region Part 02 — Practical 
            //String driver = "Ahmed Mohamed";
            //Console.WriteLine("-------------------------------------------------------------------");
            //Console.WriteLine($"Driver: {driver}");
            //Console.WriteLine("-------------------------------------------------------------------");
            //DeliveryCenter deliveryCenter = new DeliveryCenter();
            //deliveryCenter.CenterName = driver;

            //string trackingCode;
            //string description;
            //decimal weight;
            //decimal deliveryFee;
            //string city;
            //string street;
            //int number;
            //DeliveryAddress destination;
            //bool isAdded;

            //Console.WriteLine("Enter Standard Shipment Details:");
            //Console.Write("Tracking Code: ");
            //trackingCode = Console.ReadLine()!;
            //Console.Write("Description: ");
            //description = Console.ReadLine()!;
            //Console.Write("Weight: ");
            //weight = decimal.Parse(Console.ReadLine()!);
            //Console.Write("Delivery Fee: ");
            //deliveryFee = decimal.Parse(Console.ReadLine()!);
            //Console.Write("City: ");
            //city = Console.ReadLine()!;
            //Console.Write("Street: ");
            //street = Console.ReadLine()!;
            //Console.Write("Bulding Number: ");
            //number = int.Parse(Console.ReadLine()!);
            //destination = new DeliveryAddress(city, street, number);
            //StandardShipment standardShipment = new StandardShipment(trackingCode, description, weight, deliveryFee, destination);
            //isAdded = deliveryCenter.AddShipment(standardShipment);
            //if (isAdded)
            //{
            //    Console.WriteLine("StandardShipment added successfully.");
            //    Console.WriteLine();

            //}
            //else
            //{
            //    Console.WriteLine("Failed to add Standard shipment.");
            //    Console.WriteLine();

            //}

            //Console.WriteLine("Enter Express Shipment Details:");
            //Console.Write("Tracking Code: ");
            //trackingCode = Console.ReadLine()!;
            //Console.Write("Description: ");
            //description = Console.ReadLine()!;
            //Console.Write("Weight: ");
            //weight = decimal.Parse(Console.ReadLine()!);
            //Console.Write("Delivery Fee: ");
            //deliveryFee = decimal.Parse(Console.ReadLine()!);
            //Console.Write("City: ");
            //city = Console.ReadLine()!;
            //Console.Write("Street: ");
            //street = Console.ReadLine()!;
            //Console.Write("Bulding Number: ");
            //number = int.Parse(Console.ReadLine()!);
            //destination = new DeliveryAddress(city, street, number);
            //Console.Write("ExtraFee: ");
            //decimal extraFee = decimal.Parse(Console.ReadLine()!);
            //ExpressShipment expressShipment = new ExpressShipment(trackingCode, description, weight, deliveryFee, destination, extraFee);
            //isAdded = deliveryCenter.AddShipment(expressShipment);
            //if (isAdded)
            //{
            //    Console.WriteLine("Express Shipment added successfully.");
            //    Console.WriteLine();

            //}
            //else
            //{
            //    Console.WriteLine("Failed to add Expressshipment.");
            //    Console.WriteLine();

            //}

            //Console.WriteLine("Enter International Shipment Details:");
            //Console.Write("Tracking Code: ");
            //trackingCode = Console.ReadLine()!;
            //Console.Write("Description: ");
            //description = Console.ReadLine()!;
            //Console.Write("Weight: ");
            //weight = decimal.Parse(Console.ReadLine()!);
            //Console.Write("Delivery Fee: ");
            //deliveryFee = decimal.Parse(Console.ReadLine()!);
            //Console.Write("City: ");
            //city = Console.ReadLine()!;
            //Console.Write("Street: ");
            //street = Console.ReadLine()!;
            //Console.Write("Bulding Number: ");
            //number = int.Parse(Console.ReadLine()!);
            //destination = new DeliveryAddress(city, street, number);
            //Console.Write("CustomsFee: ");
            //decimal customsFee = decimal.Parse(Console.ReadLine()!);
            //Console.Write("DestinationCountry: ");
            //String destinationCountry = Console.ReadLine()!;
            //InternationalShipment internationalShipment = new InternationalShipment(trackingCode, description, weight, deliveryFee, destination, destinationCountry, customsFee);
            //isAdded = deliveryCenter.AddShipment(internationalShipment);
            //if (isAdded)
            //{
            //    Console.WriteLine("International Shipment added successfully.");
            //    Console.WriteLine();

            //}
            //else
            //{
            //    Console.WriteLine("Failed to add International shipment.");
            //    Console.WriteLine();

            //}

            //Console.WriteLine("-------------------------------------------------------------------");
            //Console.WriteLine("All Shipments in the Delivery Center:");
            //Console.WriteLine("-------------------------------------------------------------------");
            //deliveryCenter.PrintAllShipments();
            //Console.WriteLine();

            //Console.WriteLine("-------------------------------------------------------------------");
            //Console.WriteLine("All Shipments using Delivery Helper:");
            //Console.WriteLine("-------------------------------------------------------------------");
            //Console.WriteLine("standardShipment:");
            //DeliveryHelper.PrintShipmentDetails(standardShipment);
            //Console.WriteLine();
            //Console.WriteLine("expressShipment:");
            //DeliveryHelper.PrintShipmentDetails(expressShipment);
            //Console.WriteLine();
            //Console.WriteLine("internationalShipment:");
            //DeliveryHelper.PrintShipmentDetails(internationalShipment);
            //Console.WriteLine();

            //Console.WriteLine("-------------------------------------------------------------------");
            //Console.WriteLine("Updating Weight... ");
            //Console.WriteLine("-------------------------------------------------------------------");
            //Console.WriteLine($"original weight of standardShipment: {standardShipment.Weight} KG");
            //standardShipment.UpdateWeight(5);
            //Console.WriteLine($"updated weight of standardShipment: {standardShipment.Weight} KG");
            //standardShipment.UpdateWeight(5, 0.5m);
            //Console.WriteLine($"updated weight of standardShipment After Packing: {standardShipment.Weight} KG");
            //Console.WriteLine();


            //Shipment[] shipments = new Shipment[3];
            //shipments[0] = standardShipment;
            //shipments[1] = expressShipment;
            //shipments[2] = internationalShipment;
            //Console.WriteLine("-------------------------------------------------------------------");
            //Console.WriteLine("Printing Using Shipment[]...");
            //Console.WriteLine("-------------------------------------------------------------------");
            //foreach (Shipment shipment in shipments)
            //{
            //    shipment.PrintShipment();
            //    Console.WriteLine();
            //}
            #endregion
        }
    }
}
