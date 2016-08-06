﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace DecisionTech.PriceCalculation.Specs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class PriceCalculationFeature : Xunit.IClassFixture<PriceCalculationFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "PriceCalculation.feature"
#line hidden
        
        public PriceCalculationFeature()
        {
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-GB"), "PriceCalculation", "\tIn order to get prices right\r\n\tAs a shop owner\r\n\tI want to calculate them whethe" +
                    "r there are discounts to be applied or not", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
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
        
        public virtual void SetFixture(PriceCalculationFeature.FixtureData fixtureData)
        {
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute(DisplayName="Customer buys 1 bread, 1 butter and 1 milk")]
        [Xunit.TraitAttribute("FeatureTitle", "PriceCalculation")]
        [Xunit.TraitAttribute("Description", "Customer buys 1 bread, 1 butter and 1 milk")]
        public virtual void CustomerBuys1Bread1ButterAnd1Milk()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Customer buys 1 bread, 1 butter and 1 milk", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Quantity",
                        "Name"});
            table1.AddRow(new string[] {
                        "1",
                        "bread"});
            table1.AddRow(new string[] {
                        "1",
                        "butter"});
            table1.AddRow(new string[] {
                        "1",
                        "milk"});
#line 7
 testRunner.Given("the basket has", ((string)(null)), table1, "Given ");
#line 12
 testRunner.When("I total the basket", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 13
 testRunner.Then("the price should be £2.95", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Customer buys 2 butter and 2 bread")]
        [Xunit.TraitAttribute("FeatureTitle", "PriceCalculation")]
        [Xunit.TraitAttribute("Description", "Customer buys 2 butter and 2 bread")]
        public virtual void CustomerBuys2ButterAnd2Bread()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Customer buys 2 butter and 2 bread", ((string[])(null)));
#line 15
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Quantity",
                        "Name"});
            table2.AddRow(new string[] {
                        "2",
                        "butter"});
            table2.AddRow(new string[] {
                        "2",
                        "bread"});
#line 16
 testRunner.Given("the basket has", ((string)(null)), table2, "Given ");
#line 20
 testRunner.When("I total the basket", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 21
 testRunner.Then("the price should be £3.10", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Customer buys 4 milk")]
        [Xunit.TraitAttribute("FeatureTitle", "PriceCalculation")]
        [Xunit.TraitAttribute("Description", "Customer buys 4 milk")]
        public virtual void CustomerBuys4Milk()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Customer buys 4 milk", ((string[])(null)));
#line 23
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Quantity",
                        "Name"});
            table3.AddRow(new string[] {
                        "4",
                        "milk"});
#line 24
 testRunner.Given("the basket has", ((string)(null)), table3, "Given ");
#line 27
 testRunner.When("I total the basket", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 28
 testRunner.Then("the price should be £3.45", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Customer buys 2 butter, 1 bread and 8 milk")]
        [Xunit.TraitAttribute("FeatureTitle", "PriceCalculation")]
        [Xunit.TraitAttribute("Description", "Customer buys 2 butter, 1 bread and 8 milk")]
        public virtual void CustomerBuys2Butter1BreadAnd8Milk()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Customer buys 2 butter, 1 bread and 8 milk", ((string[])(null)));
#line 30
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Quantity",
                        "Name"});
            table4.AddRow(new string[] {
                        "2",
                        "butter"});
            table4.AddRow(new string[] {
                        "1",
                        "bread"});
            table4.AddRow(new string[] {
                        "8",
                        "milk"});
#line 31
 testRunner.Given("the basket has", ((string)(null)), table4, "Given ");
#line 36
 testRunner.When("I total the basket", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 37
 testRunner.Then("the price should be £9.00", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                PriceCalculationFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                PriceCalculationFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
