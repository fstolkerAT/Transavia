﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.2.0.0
//      SpecFlow Generator Version:2.2.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SpecFlow
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("SpecFlowFeatureTransavia")]
    public partial class SpecFlowFeatureTransaviaFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "SpecFlowFeatureTransavia.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "SpecFlowFeatureTransavia", "  This feature file contains some manual and automated regression test scenario\'s" +
                    ".\r\n  Manual tests: 2 test cases, both happy flow. (BTW: the can be run automated" +
                    " as well.)\r\n  Automated tests: 2 test cases,  1 happy flow, 1 unhappy flow.", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("1A User wants to book a flight with blue miles")]
        [NUnit.Framework.CategoryAttribute("Manual")]
        public virtual void _1AUserWantsToBookAFlightWithBlueMiles()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("1A User wants to book a flight with blue miles", new string[] {
                        "Manual"});
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
  testRunner.Given("I am a user who wants to book a flight at \"https://www.transavia.com/en-NL/home/\"" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
  testRunner.And("I have entered departure airport \"Amsterdam (Schiphol), Nederland\" and destinatio" +
                    "n \"Alicante, Spanje\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
  testRunner.And("I have entered departure date \"15-09-2017\" and return date \"16-09-2017\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
  testRunner.And("I have entered number of travellers 1 adults, 0 kids, 0 babies and including blue" +
                    " miles \"yes\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
  testRunner.When("I press the search button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 13
  testRunner.Then("I will see a list of possible flights on page \"Outbound flight\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("1B User wants to book a flight (same as 1A) but without blue miles. Afterwards, r" +
            "esults can be compared (manually).")]
        [NUnit.Framework.CategoryAttribute("Manual")]
        public virtual void _1BUserWantsToBookAFlightSameAs1AButWithoutBlueMiles_AfterwardsResultsCanBeComparedManually_()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("1B User wants to book a flight (same as 1A) but without blue miles. Afterwards, r" +
                    "esults can be compared (manually).", new string[] {
                        "Manual"});
#line 16
this.ScenarioSetup(scenarioInfo);
#line 17
  testRunner.Given("I am a user who wants to book a flight at \"https://www.transavia.com/en-NL/home/\"" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 18
  testRunner.And("I have entered departure airport \"Amsterdam (Schiphol), Netherlands\" and destinat" +
                    "ion \"Alicante, Spain\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
  testRunner.And("I have entered departure date \"15-09-2017\" and return date \"16-09-2017\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
  testRunner.And("I have entered number of travellers 1 adults, 0 kids, 0 babies and including blue" +
                    " miles \"no\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 21
  testRunner.When("I press the search button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 22
  testRunner.Then("I will see a list of possible flights on page \"Outbound flight\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("2 User wants to book a flight for his/her family")]
        [NUnit.Framework.CategoryAttribute("Automated")]
        [NUnit.Framework.CategoryAttribute("TestInitialize")]
        public virtual void _2UserWantsToBookAFlightForHisHerFamily()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("2 User wants to book a flight for his/her family", new string[] {
                        "Automated",
                        "TestInitialize"});
#line 26
this.ScenarioSetup(scenarioInfo);
#line 27
  testRunner.Given("I am a user who wants to book a flight at \"https://www.transavia.com/en-NL/home/\"" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 28
  testRunner.And("I have entered departure airport \"Amsterdam (Schiphol), Netherlands\" and destinat" +
                    "ion \"Alicante, Spain\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
  testRunner.And("I have entered departure date \"13-10-2017\" and return date \"20-10-2017\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
  testRunner.And("I have entered number of travellers 2 adults, 1 kids, 1 babies and including blue" +
                    " miles \"yes\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
  testRunner.When("I press the search button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 32
  testRunner.Then("I will see a list of possible flights on page \"Outbound flight\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("3 User wants to book a flight with return on same day, which is not possible for " +
            "the destination (FAILED test)")]
        [NUnit.Framework.CategoryAttribute("Automated")]
        public virtual void _3UserWantsToBookAFlightWithReturnOnSameDayWhichIsNotPossibleForTheDestinationFAILEDTest()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("3 User wants to book a flight with return on same day, which is not possible for " +
                    "the destination (FAILED test)", new string[] {
                        "Automated"});
#line 35
this.ScenarioSetup(scenarioInfo);
#line 36
  testRunner.Given("I am a user who wants to book a flight at \"https://www.transavia.com/en-NL/home/\"" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 37
  testRunner.And("I have entered departure airport \"Amsterdam (Schiphol), Netherlands\" and destinat" +
                    "ion \"Vienna, Austria\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
  testRunner.And("I have entered departure date \"13-10-2017\" and return date \"13-10-2017\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 39
  testRunner.And("I have entered number of travellers 1 adults, 0 kids, 0 babies and including blue" +
                    " miles \"no\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 40
  testRunner.When("I press the search button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 41
  testRunner.Then("I will see a list of possible flights on page \"Outbound flight\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
