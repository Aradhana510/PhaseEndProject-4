namespace CustomerTest
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void UserInfo_GetUserId_ReturnsUserId()
        {
            // Arrange
            var userInfo = new UserInfo { UserId = 1 };

            // Act
            int userId = userInfo.UserId;

            // Assert
            Assert.AreEqual(1, userId);
        }

        [Test]
        public void UserInfo_SetUserId_CanSetUserId()
        {
            // Arrange
            var userInfo = new UserInfo();

            // Act
            userInfo.UserId = 2;

            // Assert
            Assert.AreEqual(2, userInfo.UserId);
        }


    }
}