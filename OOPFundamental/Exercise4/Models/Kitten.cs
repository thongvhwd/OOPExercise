namespace Exercise4.Models
{
    class Kitten : Cat
    {
        public new bool Sex
        {
            get
            {
                return base.Sex = false;
            }
        }
        public override AnimalSound Sound()
        {
            return AnimalSound.Meow;
        }
    }
}
