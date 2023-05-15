using AutoItX3Lib;

namespace addressbook_tests_autoit
{
    public class HelperBase
    {
        protected static string WINTITLE;
        protected ApplicationManager manager;// protected - наслдники смогли получить к нему доступ
        protected AutoItX3 aux;
        public HelperBase(ApplicationManager manager)
        {
            this.manager = manager;
            aux = manager.Aux;
            WINTITLE = ApplicationManager.WINTITLE;
        }
    }
}