using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTest.Common.General
{
    public static class AppConstants
    {
        public struct StatusCodes
        {
            public const int Success = 200;
            public const int Error = 422;
            public const int NotFound = 404;

        }

        public static readonly object[] EmptyValues = { Guid.Empty, string.Empty, null };

       
        public struct Messages
        {
            public const string EditSuccessFully = "Editing completed successfully...";

            public const string EditFailed = "Something went wrong!";

            public const string AddSuccess = "Add successfully";

            public const string AddFailed = "An error occurred while adding!";

            public const string SavedSuccess = "Saved successfully";

            public const string SavedFailed = "An error occurred!";

            public const string NotFound = "This Driver Not Found!";

            
            public const string ErrorFile = "This file cannot be attached!";

            public const string RequiredMessage = "Required";

            public const string DeletedSuccess = "Deleted successfully";

            public const string DeletedFailed = "An error occurred while deleting";

         
            public const string ChangedStatusSuccess = "Status changed successfully..";
            public const string ChangedStatusFailed = "An error occurred while changing the status!";
            public const string NameAlreadyExists = "The name already exists!";

            public const string NameRequired = "Name Is Required";

           
        }
        public struct Schema
        {
     
            public const string Guide = nameof(Guide);

        }


    }
}
