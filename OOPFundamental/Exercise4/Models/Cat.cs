namespace Exercise4.Models
{
    class Cat : Animal
    {
        public override AnimalSound Sound()
        {
            return AnimalSound.Mew;
        }
    }
}
