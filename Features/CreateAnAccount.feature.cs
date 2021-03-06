﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.5.0.0
//      SpecFlow Generator Version:3.5.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace testautomation.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.5.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("CreateAnAccount", SourceFile="Features\\CreateAnAccount.feature", SourceLine=0)]
    public partial class CreateAnAccountFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "CreateAnAccount.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "CreateAnAccount", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void CreateAnAccountWithValidUnregisteredEmailAddress(
                    string title, 
                    string first, 
                    string last, 
                    string email, 
                    string password, 
                    string day, 
                    string month, 
                    string year, 
                    string newsletters, 
                    string offers, 
                    string company, 
                    string addressline1, 
                    string addressline2, 
                    string city, 
                    string state, 
                    string country, 
                    string info, 
                    string home, 
                    string mobile, 
                    string alias, 
                    string zip, 
                    string accountname, 
                    string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "ui",
                    "account",
                    "createanaccount"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("title", title);
            argumentsOfScenario.Add("first", first);
            argumentsOfScenario.Add("last", last);
            argumentsOfScenario.Add("email", email);
            argumentsOfScenario.Add("password", password);
            argumentsOfScenario.Add("day", day);
            argumentsOfScenario.Add("month", month);
            argumentsOfScenario.Add("year", year);
            argumentsOfScenario.Add("newsletters", newsletters);
            argumentsOfScenario.Add("offers", offers);
            argumentsOfScenario.Add("company", company);
            argumentsOfScenario.Add("addressline1", addressline1);
            argumentsOfScenario.Add("addressline2", addressline2);
            argumentsOfScenario.Add("city", city);
            argumentsOfScenario.Add("state", state);
            argumentsOfScenario.Add("country", country);
            argumentsOfScenario.Add("info", info);
            argumentsOfScenario.Add("home", home);
            argumentsOfScenario.Add("mobile", mobile);
            argumentsOfScenario.Add("alias", alias);
            argumentsOfScenario.Add("zip", zip);
            argumentsOfScenario.Add("accountname", accountname);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create an account with valid unregistered email address", null, tagsOfScenario, argumentsOfScenario);
#line 4
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 5
 testRunner.Given("the create an account page is shown for the shopper \"email\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 6
 testRunner.When("the shopper enters the first name \"first\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 7
 testRunner.And("the shopper enters the last name \"last\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 8
 testRunner.And("the shopper enters the password \"password\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 9
 testRunner.And("the shopper enters the date of birth \"day\" \"month\" \"year\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 10
 testRunner.And("the shopper sets the newsletters to \"newsletters\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 11
 testRunner.And("the shopper set the offers to \"offers\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 12
 testRunner.And("the shopper enters the company \"company\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 13
 testRunner.And("the shopper enters the address line \"addressline1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 14
 testRunner.And("the shopper enters the city \"city\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 15
 testRunner.And("the shopper enters the state \"state\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 16
 testRunner.And("the shopper enters the country \"country\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 17
 testRunner.And("the shopper enters the zip \"zip\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 18
 testRunner.And("the shopper enters the info \"info\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 19
 testRunner.And("the shopper enters the home \"home\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 20
 testRunner.And("the shopper enters the mobile \"mobile\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 21
 testRunner.And("the shopper enters the alias \"alias\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 22
 testRunner.And("the shopper registers", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 23
 testRunner.Then("the shopper is shown the myaccount page for \"accountname\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Create an account with valid unregistered email address, ValidShoppers, Mr", new string[] {
                "ui",
                "account",
                "createanaccount"}, SourceLine=26)]
        public virtual void CreateAnAccountWithValidUnregisteredEmailAddress_ValidShoppers_Mr()
        {
#line 4
this.CreateAnAccountWithValidUnregisteredEmailAddress("Mr", "Bob", "Fossil", "bob.fossil@example.com", "password123", "12", "January", "1980", "true", "false", "Zoo", "Zoo Building", "1 Zoo Road", "Zoo", "Zoo State", "Zoo Country", "Test Test Test", "01223434343", "07799766543", "Work", "BS1 7AG", "accountname", ((string[])(null)));
#line hidden
        }
    }
}
#pragma warning restore
#endregion
