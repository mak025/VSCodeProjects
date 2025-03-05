namespace TinderForPets.Model
{
    public class Animal
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public string AnimSex { get; set; }
        public string AnimRace { get; set; }

        public Animal(string name, string description, string imagepath, string animsex, string animrace)
        {
            Name = name;
            Description = description;
            ImagePath = imagepath;
            AnimSex = animsex;
            AnimRace = animrace;
        }
    }
}
