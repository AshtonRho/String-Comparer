using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Comparer
{
    class Validation_Result
    {
        public bool ValidationSuccess;
        public string Message;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userInput"> data entered by user </param>
        /// <returns> true if all checks pass </returns>

        public bool ValidateUserInput(string userInput)
        {
            //presence check
            if(userInput.Length == 0)
            {
                Message = "presence check failed";
                return false;
            }

            //length check
            if(userInput.Length > 1024)
            {
                Message = "there should be no more than 1024 characters";
                return false;
            }
            
        }

    }
}
