using NIMSAutomationSTE;

namespace ComponentOne.PO_Management
{
    internal class Page_Zero : BasePage
    {


        public Page_Zero(COne_InceptionPoint results)
        {
            MyResults = results;
            Boom = new CTwo_Integration(MyResults);

        } //end of constructor

        public bool Create_Page0_UseCase_TrueFalse()
        {
            //validate the user can do this
            //where 'this' = Method 'C' = this button

            if (Boom.HTMLObject_x_TrueTrue() == false)
            {
                MyResults.Failed_Test("BZNESS Controls: Could Not Find Method 'A' on SUT page. ");
                return false;
            }
            if (Boom.HTMLObject_y_TrueTrue() == false)
            {
                MyResults.Failed_Test("BZNESS Controls: Could Not Find Method 'B' on SUT page. ");
                return false;
            }
            if (Boom.HTMLObject_z_TrueFalse() == false)
            {
                MyResults.Failed_Test("BZNESS Controls: Could Not Find Method 'C' on SUT page. ");
                return false;
            }
            return true;
        }

        public bool Create_Page0_UseCase_TrueTrue()
        {
            //validate the user can do this
            //where 'this' = Method 'C' = this button

            if (Boom.HTMLObject_x_TrueTrue() == false)
            {
                MyResults.Failed_Test("BZNESS Controls: Could Not Find Method 'A' on SUT page. ");
                return false;
            }
            if (Boom.HTMLObject_y_TrueTrue() == false)
            {
                MyResults.Failed_Test("BZNESS Controls: Could Not Find Method 'B' on SUT page.");
                return false;
            }
            if (Boom.HTMLObject_x_TrueTrue() == false)
            {
                MyResults.Failed_Test("BZNESS Controls: Could Not Find Method 'C' on SUT page. ");
                return false;
            }
            return true;

        }

    } //end of class
} //end of namespace