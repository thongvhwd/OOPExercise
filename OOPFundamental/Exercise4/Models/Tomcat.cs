namespace Exercise4.Models
{
    class Tomcat : Cat
    {
        public new bool Sex
        {
            get
            {                
                return base.Sex = true;
            }
        }
        public override AnimalSound Sound()
        {
            return AnimalSound.Tomtom;
        }
    }
}
