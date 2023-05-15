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
            //List<GroupData> oldGroups = app.Groups.GetGroupList();

            var oldGroups = app.Groups.GetGroupListCount();

            GroupData newGroup = new GroupData()
            {
                Name = "test"
            };

            app.Groups.Add(newGroup);

            var newGroups = app.Groups.GetGroupListCount();

            //List<GroupData> newGroups = app.Groups.GetGroupList();
            //oldGroups.Add(newGroup);
            //oldGroups.Sort();
            //newGroups.Sort();
            Assert.AreEqual(oldGroups + 1 , newGroups);

        }
    }
}
