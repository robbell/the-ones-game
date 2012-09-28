using System;

namespace TheOnesGame
{
    public class Edge
    {
        private UserStory[] position = new UserStory[5];

        public void SetPosition(int i, UserStory userStory)
        {
            position[i] = userStory;
        }

        public void MoveStoryOn(int i)
        {
            
        }

        public UserStory CompleteStory
        {
            get { return null; }
            set { throw new NotImplementedException(); }
        }

        public UserStory GetStoryOnPosition(int i)
        {
            return position[i];
        }
    }
}
