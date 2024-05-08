using ComponentOne.PO_Management;


namespace NIMSAutomationSTE.ScriptingEnvironment
{
    internal class TestBuilder
    {
        PageOne page_One;
        Page_Zero page_Zero;
        COne_InceptionPoint _results;
        public TestBuilder(COne_InceptionPoint results)
        {
            _results = results;
            page_One = new PageOne(results);
            page_Zero = new Page_Zero(results);
        }

        public void TestBuilder_LaunchSimulation_TrueFalse()
        {

            //start of script
            if (page_Zero.Create_Page0_UseCase_TrueTrue() == false)
            {
                _results.Failed_Test("TB: Could not validate a completed Page0 UseCase(n) transaction.");
                return;
            }

            if (page_One.Create_Page1_UseCase_TrueFalse() == false)
            {
                _results.Failed_Test("TB: Could not validate a completed Page1 UseCase(n) transaction.");
                return;
            }


        }

    }
}