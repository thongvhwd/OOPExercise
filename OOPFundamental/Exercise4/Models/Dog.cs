namespace Exercise4.Models
{
    class Dog : Animal
    {
        public override AnimalSound Sound()
        {
            return AnimalSound.Woof;
        }
    }
}
