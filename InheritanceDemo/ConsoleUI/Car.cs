namespace ConsoleUI
{
    public class Car
    {
        public int NumberOfWheels { get; set; }
        public int NumberOfDoors { get; set; }
        public void StartEngine()
        {

        }

        public void StopEngine()
        {

        }
    }
}

// Inheritance is a way of creating classes built on existing classes.
// In here, a Supra is a type of car, so we don't need to copy all the existing properties but just inherit them. 
// So in context, the parent class is Car and the child class is Supra.