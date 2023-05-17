using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Threading;

namespace addressbook_tests_autoit
{
    public class GroupHelper:HelperBase
    {
        public static string GROUPWINTITLE = "Group editor";
       public GroupHelper(ApplicationManager manager) : base(manager) { } // в базовый класс сохраняем ссылку на менеджер

        public void Add(GroupData newGroup)
        {
            aux.ControlClick(GROUPWINTITLE, "", "WindowsForms10.BUTTON.app.0.2c908d53");
            aux.WinWait(GROUPWINTITLE);
            aux.Send(newGroup.Name);
            aux.WinWait(GROUPWINTITLE);
            aux.Send("{ENTER}");
            aux.WinWait(GROUPWINTITLE);
            CloseGroupDialog();
            aux.WinWait(WINTITLE);

        }

        public int GetGroupListCount()
        {
            
            OpenGroupsDialog();
            string count = aux.ControlTreeView(GROUPWINTITLE, "", "WindowsForms10.SysTreeView32.app.0.2c908d51",
                                 "GetItemCount","#0","");
            CloseGroupDialog();
            return int.Parse(count);
        }

        public void CloseGroupDialog()
        {
            aux.ControlClick(GROUPWINTITLE, "", "WindowsForms10.BUTTON.app.0.2c908d54");
        }

        public void OpenGroupsDialog()
        {
            aux.ControlClick(WINTITLE, "", "WindowsForms10.BUTTON.app.0.2c908d512");
            aux.WinWait(GROUPWINTITLE);
        }

        public void CheckGroupAnotherCreate()
        {
            aux.WinWait("Group editor");

            string checkGroup = aux.ControlTreeView("Group editor", "", "WindowsForms10.SysTreeView32.app.0.2c908d51", "Exists", "#0|#1", "");


            if (int.Parse(checkGroup) == 0)
            {
                GroupData group = new GroupData()
                {
                    Name = "test"
                };


                Add(group);
            }
                      
        }

        public void SelectDeleteGroup()
        {
            OpenGroupsDialog();
            aux.ControlTreeView("Group editor", "", "WindowsForms10.SysTreeView32.app.0.2c908d51", "Select", "#0|#1", "");
            aux.ControlClick("Group editor", "", "WindowsForms10.BUTTON.app.0.2c908d51");
            aux.WinWait("Delete group");

        }

        public void ConfirmDeleteGroup()
        {
            aux.ControlClick("Delete group", "", "WindowsForms10.BUTTON.app.0.2c908d52");
            aux.ControlClick("Delete group", "", "WindowsForms10.BUTTON.app.0.2c908d53");

            CloseGroupDialog();

            aux.WinWait(WINTITLE);

        }

    }
}