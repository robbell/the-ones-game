using System;
using NUnit.Framework;
using TheOnesGame;

namespace TheOnesGameTests
{
    [TestFixture]
    public class EdgeTests
    {
       [Test]
        public void A_two_point_user_story_on_position_1_is_moved_to_done()
        {
            var userStory = new UserStory(2);
            var edge = new Edge();

            edge.SetPosition(1, userStory);
                Assert.That(edge.CompleteStory, Is.EqualTo(null));

            edge.MoveStoryOn(1);

            Assert.That(edge.CompleteStory, Is.EqualTo(userStory));
        }

        [Test]
        public void User_story_position_can_be_set_on_an_edge()
        {
            var userStory = new UserStory(2);
            var edge = new Edge();

            edge.SetPosition(1, userStory);
            Assert.That(edge.GetStoryOnPosition(1), Is.EqualTo(userStory));
        }


        [Test]
        public void User_story_can_be_moved_from_given_position_to_the_next_position()
        {
            var userStory = new UserStory(3);
            var edge = new Edge();
            const int startingPosition = 1;
            edge.SetPosition(startingPosition,userStory);

            edge.MoveStoryOn(startingPosition);
            Assert.That(edge.GetStoryOnPosition(startingPosition+1), Is.EqualTo(userStory));
            Assert.That(edge.GetStoryOnPosition(startingPosition), Is.EqualTo(null));
        }


        [Test]
        public void User_story_can_be_set_to_first_and_last_position()
        {
            var userStory = new UserStory(5);
            var edge = new Edge();

            edge.SetPosition(1, userStory);
            edge.SetPosition(5, userStory);

            Assert.That(edge.GetStoryOnPosition(1), Is.EqualTo(userStory));
            Assert.That(edge.GetStoryOnPosition(5), Is.EqualTo(userStory));
        }

        [Test]
        public void User_story_throws_out_of_bounds_exception_for_position_less_than_one()
        {
            var userStory = new UserStory(2);
            var edge = new Edge();

            Assert.That(() => edge.SetPosition(0, userStory), Throws.TypeOf<IndexOutOfRangeException>());
        }

        [Test]
        public void User_story_throws_out_of_bounds_exception_for_position_greater_than_five()
        {
            var userStory = new UserStory(2);
            var edge = new Edge();

            Assert.That(() => edge.SetPosition(6, userStory), Throws.TypeOf<IndexOutOfRangeException>());
        }

//        [Test]
//        public void Story_Moves_to
//        {
//            var userStory = new UserStory(2);
//            var edge = new Edge();
//
//            edge.SetPosition(1, userStory);
//            Assert.That(edge.GetStoryOnPosition(1), Is.EqualTo(userStory));
//        }
    }
}
