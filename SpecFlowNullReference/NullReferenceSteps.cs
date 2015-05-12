using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace SpecFlowNullReference
{
    [Binding]
    public class NullReferenceSteps
    {
        private const string Key = "SomeKey";
        private object value;
        private NullReferenceException exception;

        [Given(@"I set null value to ScenarioContext")]
        public void GivenISetNullValueToScenarioContext()
        {
            ScenarioContext.Current.Set<object>(null, Key);
        }

        [When(@"I get value from ScenarioContext")]
        public void WhenIGetValueFromScenarioContext()
        {
            value = ScenarioContext.Current.Get<object>(Key);
        }

        [Then(@"the value should be null")]
        public void ThenNullReferenceExceptionIsThrown()
        {
            Assert.IsNull(value);
        }
    }
}