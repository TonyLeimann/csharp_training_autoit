using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Threading;

namespace addressbook_tests_autoit
{
    [TestFixture]
    public class GroupRemovalTests:TestBase
    {
        [Test]
        public void GroupRemovalTest()
        {
          
            app.Groups.OpenGroupsDialog();
            app.Groups.CheckGroupAnotherCreate();

            var oldGroups = app.Groups.GetGroupListCount();

            app.Groups.SelectDeleteGroup();
            app.Groups.ConfirmDeleteGroup();

            var newGroups = app.Groups.GetGroupListCount();
                      

            Assert.AreEqual(oldGroups - 1, newGroups);

        }


    }
}
