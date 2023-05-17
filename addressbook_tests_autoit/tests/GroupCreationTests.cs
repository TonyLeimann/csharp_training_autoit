using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace addressbook_tests_autoit
{
    [TestFixture]
    public class GroupCreationTests:TestBase
    {
        [Test]
        public void TestGroupCreation()
        {
            
            var oldGroups = app.Groups.GetGroupListCount();

            GroupData newGroup = new GroupData()
            {
                Name = "test"
            };

            app.Groups.OpenGroupsDialog();

            app.Groups.Add(newGroup);

            var newGroups = app.Groups.GetGroupListCount();

      
            Assert.AreEqual(oldGroups + 1 , newGroups);

        }
    }
}
