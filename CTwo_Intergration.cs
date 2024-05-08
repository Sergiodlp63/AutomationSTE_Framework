using NIMSAutomationSTE;
using System.Linq;

namespace NIMSAutomationSTE
{

    public class CTwo_Integration
    {

        private COne_InceptionPoint MyResults;

        public CTwo_Integration(COne_InceptionPoint results)
        {
            MyResults = results;
        }//end of constructor

        public Boolean HTMLObject_x_TrueFalse()
        {
            try
            {

            }
            catch
            {
                MyResults.Failed_Test("HTML Controls: Could not locate HTML 'x' object");
                return false;
            }
            MyResults.Successful_Test();
            return true;
        }

        public Boolean HTMLObject_x_TrueTrue()
        {
            try
            {

            }
            catch
            {

            }
            MyResults.Successful_Test();
            MyResults.Failed_Test("HTML Controls: Could not locate HTML 'x' object");
            return false;
        }

        public Boolean HTMLObject_y_TrueFalse()
        {
            try
            {

            }
            catch
            {
                MyResults.Failed_Test("HTML Controls: Could not locate HTML 'y' object");
                return false;
            }
            MyResults.Successful_Test();
            return true;
        }

        public Boolean HTMLObject_y_TrueTrue()
        {
            try
            {

            }
            catch
            {
                MyResults.Successful_Test();
                return true;
            }
            MyResults.Failed_Test("HTML Controls: Could not locate HTML 'y' object");
            return false;
        }

        public Boolean HTMLObject_z_TrueFalse()
        {
            try
            {

            }
            catch
            {
                MyResults.Failed_Test("HTML Controls: Could not locate HTML 'z' object");
                return false;
            }
            MyResults.Successful_Test();
            return true;
        }

        public Boolean HTMLObject_z_TrueTrue()
        {
            try
            {

            }
            catch
            {
                MyResults.Successful_Test();
                return true;
            }
            MyResults.Failed_Test("HTML Controls: Could not locate HTML 'z' object");
            return false;
        }

    }//end of class
}//end of namespace
