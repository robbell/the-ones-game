using NUnit.Framework;
using TheOnesGame;
using TheOnesGameConsole;

namespace TheOnesGameTests
{
    public class OnesLibTest
    {
        [TestCase("blue 2", Result = 2)]
        [TestCase("red 5", Result = 5)]
        [TestCase("green 3", Result = 3)]
        public int Parse_gets_position_from_user_input(string userInput)
        {
            return OnesLib.ParsePositionToMoveFrom(userInput);
        }

        [Test]
        public void Null_story_is_displayed_as_dash()
        {
            Assert.That(OnesLib.GetStoryText(null), Is.EqualTo("-"));
        }

        [Test]
        public void Story_value_is_displayed_as_string()
        {
            Assert.That(OnesLib.GetStoryText(new UserStory(3)), Is.EqualTo("3"));
        }
    }
}