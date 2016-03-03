using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace FizzBuzzWpf.Specs
{
    [Binding]
    public class AcceptanceTests
    {     
        [Given(@"I have entered (.*) into the FizzBuzzApp")]
        public void GivenIHaveEnteredIntoTheFizzBuzzApp(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I press Fizzbuzzinator")]
        public void WhenIPressFizzbuzzinator()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            ScenarioContext.Current.Pending();
        }

    }
}
