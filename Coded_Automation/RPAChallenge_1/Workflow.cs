//using RPAChallenges.ObjectRepository;
using System;
using System.Collections.Generic;
using System.Data;
using UiPath.CodedWorkflows;
using UiPath.Core;
using UiPath.Core.Activities.Storage;
using UiPath.Excel;
using UiPath.Excel.Activities;
//using UiPath.Excel.Activities.API;
//using UiPath.Excel.Activities.API.Models;
using UiPath.Orchestrator.Client.Models;
using UiPath.Testing;
using UiPath.Testing.Activities.TestData;
using UiPath.Testing.Activities.TestDataQueues.Enums;
using UiPath.Testing.Enums;
using UiPath.UIAutomationNext.API.Contracts;
using UiPath.UIAutomationNext.API.Models;
using UiPath.UIAutomationNext.Enums;

namespace RPAChallenges
{
    // For accessing UI Elements from Object Repository, you can use the Descriptors class e.g:
    public static class Elms
        {
            public static readonly string Address = "Address";
            public static readonly string CompanyName = "Company Name";
            public static readonly string Email = "Email";
            public static readonly string FirstName = "First Name";
            public static readonly string PhoneNumber = "Phone Number";
            public static readonly string RoleInCompany = "Role in Company";
            public static readonly string Start = "Start";
            public static readonly string Submit = "Submit";
            public static readonly string LastName = "Last Name";
        }
    public static class Data
        {
            public static readonly string Address = "Address";
            public static readonly string CompanyName = "Company Name";
            public static readonly string Email = "Email";
            public static readonly string FirstName = "First Name";
            public static readonly string PhoneNumber = "Phone Number";
            public static readonly string RoleInCompany = "Role in Company";
            public static readonly string Start = "Start";
            public static readonly string Submit = "Submit";
            public static readonly string LastName = "Last Name ";
        }
    public class Workflow : UiPathCodedWorkflow.CodedWorkflow
    {
        private const bool V1 = true;
        private const bool V = V1;

        [Workflow]
        
        public void Execute()
        {            
            //var SimulateStatus = UiPath.Core.SimulateEventType:True;
            var result = RunWorkflow("RPAChallenge_1\\ReadExcelData.xaml", new Dictionary<string, object>(){});
            
            DataTable dt_Data = (DataTable) result["out_dt_RPA"];
            
            var sapp = uiAutomation.Open("Chrome: Rpa Challenge");    // var screen = uiAutomation.Open(Descriptors.MyApp.FirstScreen);
            
            sapp.Click("Start");    // screen.Click(Descriptors.MyApp.FirstScreen.SettingsButton);
            
            foreach(DataRow row in dt_Data.Rows)
            {
                 sapp.TypeInto(Elms.Address, row[Data.Address].ToString()); 
                 sapp.TypeInto(Elms.FirstName, row[Data.FirstName].ToString());
                 sapp.TypeInto(Elms.LastName, row[Data.LastName].ToString());
                 sapp.TypeInto(Elms.CompanyName, row[Data.CompanyName].ToString());
                 sapp.TypeInto(Elms.RoleInCompany, row[Data.RoleInCompany].ToString());
                 sapp.TypeInto(Elms.Email, row[Data.Email].ToString());
                 sapp.TypeInto(Elms.PhoneNumber, row[Data.PhoneNumber].ToString());
                 sapp.Click(Elms.Submit);
            }
            
        }
    }
}