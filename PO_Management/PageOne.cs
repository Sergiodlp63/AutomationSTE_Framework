using NIMSAutomationSTE;


namespace ComponentOne.PO_Management
{
    internal class PageOne : BasePage
    {

        public PageOne(COne_InceptionPoint results)
        {
            MyResults = results;
            Boom = new CTwo_Integration(MyResults);

        } //end of constructor

        public bool Create_Page1_UseCase_TrueFalse()
        {
            //validate the user can do this
            //where 'this' = Method 'C' = this button

            if (Boom.HTMLObject_x_TrueTrue() == false)
            {
                MyResults.Failed_Test("Page1 Controls: Could not click x button on page1. ");
                return false;
            }
            if (Boom.HTMLObject_y_TrueTrue() == false)
            {
                MyResults.Failed_Test("Page1 Controls: Could not select y option from dropdown box on page1. ");
                return false;
            }
            if (Boom.HTMLObject_z_TrueFalse() == false)
            {
                MyResults.Failed_Test("Page1 Controls: Could not select z tile from on page1. ");
                return false;
            }
            return true;
        }

        public bool Create_Page1_UseCase_TrueTrue()
        {
            //validate the user can do this
            //where 'this' = Method 'C' = this button

            if (Boom.HTMLObject_x_TrueTrue() == false)
            {
                MyResults.Failed_Test("Page1 Controls: Could not click x button on page1. ");
                return false;
            }
            if (Boom.HTMLObject_y_TrueTrue() == false)
            {
                MyResults.Failed_Test("Page1 Controls: Could not select y option from dropdown box on page1. ");
                return false;
            }
            if (Boom.HTMLObject_x_TrueTrue() == false)
            {
                MyResults.Failed_Test("Page1 Controls: Could not select z tile from on page1. ");
                return false;
            }
            return true;

        }
    } //end of class
} //end of namespace