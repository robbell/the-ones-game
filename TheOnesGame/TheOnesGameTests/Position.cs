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
         
        }

        public string Name
        {
            get { return _name; }
        }

        public UserStory UserStory { get; set; }
    }
}