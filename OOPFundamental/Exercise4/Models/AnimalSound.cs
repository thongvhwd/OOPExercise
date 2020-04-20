using System.ComponentModel;

namespace Exercise4.Models
{
    enum AnimalSound
    {
        [Description("Dog")]
        Woof,
        [Description("Frog")]
        Croak,
        [Description("Cat")]
        Mew,
        [Description("Kitten")]
        Meow,
        [Description("Tomcat")]
        Tomtom,
    }
}
