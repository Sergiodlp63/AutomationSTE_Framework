using ComponentOne.PO_Management;
using NIMSAutomationSTE;
using NIMSAutomationSTE.ScriptingEnvironment;


namespace ComponentOne
{
    public class LaunchAndRun
    {
        private COne_InceptionPoint MyResults;

        public LaunchAndRun(COne_InceptionPoint results)
        {
            MyResults = results;
        }

        static void Main(string[] args)
        {
            COne_InceptionPoint results = new COne_InceptionPoint();
            //launch url here

            // E2E test case called from scripting here

            //Run_TC001_TF.RunTC001_TrueTrue();

            TestBuilder tb = new TestBuilder(results);

            tb.TestBuilder_LaunchSimulation_TrueFalse();


            // Assertion method
            Console.WriteLine(results.TestHandler_OutputMessage);

        }

    }// end of class
} //end of namespace