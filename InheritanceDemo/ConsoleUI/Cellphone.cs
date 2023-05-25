namespace ConsoleUI
{
    public class Cellphone : Phone
    {
        public string Carrier { get; set; }
    }
}

// Inheritance is a way of creating classes built on existing classes.
// In here, a Supra is a type of car, so we don't need to copy all the existing properties but just inherit them. 
// So in context, the parent class is Car and the child class is Supra and Fairlady.

// It is important to note that even though you can inherit from a parent that has a parent, you cannot inherit from multiple parents directly.

// A good rule of thumb checking inheritance is following the IS-A relationship. So for instance, A smartphone is a cellphone, a cellphone is a phone. Which is what we are doing here inheriting from the parent classes.