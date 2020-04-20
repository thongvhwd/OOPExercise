namespace Exercise4.Models
{
    abstract class Animal
    {
        public double Age { get; set; }
        public string Name { get; set; }
        public bool Sex { get; set; }
        public abstract AnimalSound Sound();
        public static string IdentifyAnimalBySound(AnimalSound sound)
        {
            switch (sound)
            {
                case AnimalSound.Woof:
                    return typeof(Dog).Name;
                case AnimalSound.Croak:
                    return typeof(Frog).Name;
                case AnimalSound.Mew:
                    return typeof(Cat).Name;
                case AnimalSound.Meow:
                    return typeof(Kitten).Name;
                case AnimalSound.Tomtom:
                    return typeof(Tomcat).Name;
                default: return "unidentified animal";
            }
        }
    }
}
