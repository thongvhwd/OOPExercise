namespace Exercise4.Models
{
    class Frog : Animal
    {
        public override AnimalSound Sound()
        {
            return AnimalSound.Croak;
        }
    }
}
