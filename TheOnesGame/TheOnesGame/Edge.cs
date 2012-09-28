using System;

namespace TheOnesGame
{
    public class Edge
    {
        private UserStory[] position = new UserStory[5];

        public void SetPosition(int i, UserStory userStory)
        {
            position[i - 1] = userStory;
        }

        public void MoveStoryOn(int i)
        {
            var userStory = GetStoryOnPosition(i);
            //if(story == null) return;

            if (userStory.StoryPoint == i + 1)
            {
                CompleteStory = userStory;
            }
            else
            {
                SetPosition(i + 1, userStory);
            }


            SetPosition(i, null);
        }

        public UserStory CompleteStory { get; set; }

        public UserStory GetStoryOnPosition(int i)
        {
            return position[i - 1];
        }
    }
}
