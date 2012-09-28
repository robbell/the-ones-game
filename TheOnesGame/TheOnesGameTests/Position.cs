using System.Collections.Generic;
using TheOnesGame;

namespace TheOnesGameTests
{
    public class Position
    {
        private readonly string _name;

        public Position(string name)
        {
            _name = name;
            UserStories = new List<UserStory>();
         
        }

        public string Name
        {
            get { return _name; }
        }

        public List<UserStory> UserStories { get; set; }
    }
}