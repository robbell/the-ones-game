using System;
using System.Linq;
using TheOnesGame;

namespace TheOnesGameConsole
{
    public class OnesLib
    {
        public static int ParsePositionToMoveFrom(string input)
        {
            var positionToMovefrom = Convert.ToInt32(input.Last() - '0');
            return positionToMovefrom;
        }

        public static string GetStoryText(UserStory story)
        {
            return story == null ? "-" : story.StoryPoint.ToString();
        }
    }
}