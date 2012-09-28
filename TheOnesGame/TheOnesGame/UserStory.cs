namespace TheOnesGame
{
    public class UserStory
    {
        private readonly int _storyPoint;

        public UserStory(int storyPoint)
        {
            _storyPoint = storyPoint;
        }

        public int StoryPoint
        {
            get { return _storyPoint; }
        }
    }
}