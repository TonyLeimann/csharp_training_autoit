using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoItX3Lib;

namespace addressbook_tests_autoit
{
    public class ApplicationManager
    {
        public static string WINTITLE = "Free Address Book";

        public AutoItX3 aux;//ссылка
        public GroupHelper groupHelper;
        public ApplicationManager() // конструктор
        {
            aux = new AutoItX3();// инициализация
            aux.Run(@"C:\Tools\FreeAddressBookPortable\AddressBook.exe","",aux.SW_SHOW);//запуск приложения, можно только путь передать
            aux.WinWait(WINTITLE);
            aux.WinActivate(WINTITLE);
            aux.WinWaitActive(WINTITLE);
            
            groupHelper = new GroupHelper(this);// инициализаця в конструкторе, передаем ссылку на ApplicationManager
                                                // для обращения к своему менедежеру и к другим помощникам
        }

        public void Stop()
        {
            aux.ControlClick(WINTITLE, "", "WindowsForms10.BUTTON.app.0.2c908d510");
        }
       

        public AutoItX3 Aux { get { return aux; } }// доступ к aux
        public GroupHelper Groups
        {
            get { return groupHelper; } // возвращает поле
        }
    }


}
