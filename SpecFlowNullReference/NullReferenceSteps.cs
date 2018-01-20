using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace SpecFlowNullReference
{
    [Binding]
    public class NullReferenceSteps
    {
        private const string Key = "SomeKey";
        private const string IsNullKey = Key + "isNull";
        private object value;

        [Given(@"I set null value to ScenarioContext")]
        public void GivenISetNullValueToScenarioContext()
        {
            string theValue = null;
            ScenarioContext.Current.Set<object>(theValue, Key);
            ScenarioContext.Current.Set<object>(theValue==null, IsNullKey);
        }

        [When(@"I get value from ScenarioContext")]
        public void WhenIGetValueFromScenarioContext()
        {
            var keyIsnull = ScenarioContext.Current.Get<bool>(IsNullKey);

            if (keyIsnull)
                value = null;
            else 
                value = ScenarioContext.Current.Get<object>(Key);
            
        }

        [Then(@"the value should be null")]
        public void ThenNullReferenceExceptionIsThrown()
        {
            Assert.IsNull(value);
        }
    }
}