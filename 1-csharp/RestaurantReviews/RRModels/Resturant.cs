using System.Collections.Generic;
/// <summary>
/// Namespace for the models/ custom data structures involved in Restaurant Reviews
/// </summary>
namespace RRModels 
{

/// <summary>
/// Data structure used to define a restaurant 
/// </summary>
    public class Resturant 
    {
        public Resturant(string name, string city, string state)
        {
            this.Name = name;
            this.City = city;
            this.State = state;
        }

        public Resturant()
        {
            
        }
        // Class Members
        // Constructor- used to create an instance of the class.
        // Fields- defines the characteristics of a class.
        // Methods- defines the behavior of a class.
        // Properties- aka smart fields, are accessor methods used to access private backing fields.
        // * NOTE: Properties = Getters/ Setters in java
        
        /// <summary>
        /// This describes the name of your resturant
        /// </summary>
        /// <value></value>
        public string Name { get; set;}
        
        /// <summary>
        /// This describes the location of your resturant
        /// </summary>
        /// <value></value>
        public string City { get; set;}
        
        /// <summary>
        /// This describes the state of your resturant
        /// </summary>
        /// <value></value>
        public string State { get; set;}
       
        /// <summary>
        /// This describes the review of your particular resturant
        /// </summary>
        /// <value></value>
        public List<Review> Reviews { get; set; }

        public override string ToString()
        {
            return $"------------------------------\nName: {Name} \n\nLocation: {City}, {State} \n------------------------------";
        }
    }
}