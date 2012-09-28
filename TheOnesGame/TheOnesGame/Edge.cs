using System;

namespace TheOnesGame
{
    public class Edge
    {
        private UserStory[] position = new UserStory[5];

        public void SetPosition(int i, UserStory userStory)
        {
            position[i-1] = userStory;
        }

        public void MoveStoryOn(int i)
        {
            var userStory = GetStoryOnPosition(i);
            //if(story == null) return;
            SetPosition(i+1, userStory);
        }

        public UserStory CompleteStory
        {
            get { return null; }
            set { throw new NotImplementedException(); }
        }

        public UserStory GetStoryOnPosition(int i)
        {
            return position[i-1];
        }
    }
}
