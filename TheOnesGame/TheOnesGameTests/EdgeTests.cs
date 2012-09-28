using NUnit.Framework;
using TheOnesGame;

namespace TheOnesGameTests
{
    [TestFixture]
    public class EdgeTests
    {
//        [Test]
//        public void A_two_point_user_story_on_position_1_is_moved_to_done()
//        {
//            var userStory = new UserStory(2);
//            var edge = new Edge();
//
//            edge.SetPosition(1, userStory);
//            edge.MoveStoryOn(1);
//
//            Assert.That(edge.CompleteStory, Is.EqualTo(userStory));
//        }

        [Test]
        public void User_story_position_can_be_set_on_an_edge()
        {
            var userStory = new UserStory(2);
            var edge = new Edge();

            edge.SetPosition(1, userStory);
            Assert.That(edge.GetStoryOnPosition(1), Is.EqualTo(userStory));
        }
    }
}
