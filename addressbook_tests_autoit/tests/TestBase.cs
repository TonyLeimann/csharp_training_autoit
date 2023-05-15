using NUnit.Framework;

namespace addressbook_tests_autoit
{
    public class TestBase
    {

        public ApplicationManager app;

        [SetUp]// выполняется один единствнный раз, перед всеми тестовыми методами
        
        public void InitApplication()
        {
            app = new ApplicationManager(); // инициализация
        }

        [TearDown]
        public void StopApplication()
        {
            app.Stop();
        }
    }
}
