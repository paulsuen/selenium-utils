namespace Riganti.Utils.Testing.Selenium.Core.Checkers.BrowserWrapperCheckers
{
    public class CheckIfAlertTextContains : ICheck<BrowserWrapper>
    {
        private readonly string expectedValue;
        private readonly bool caseSensitive;
        private readonly bool trim;

        public CheckIfAlertTextContains(string expectedValue, bool trim = true)
        {
            this.expectedValue = expectedValue;
            this.trim = trim;
        }

        public CheckResult Validate(BrowserWrapper wrapper)
        {
            var alert = wrapper.GetAlert();
            string alertText;
            string trimExpectedValue;
            if (trim)
            {
                alertText = alert.Text?.Trim();
                trimExpectedValue = expectedValue.Trim();
            }
            else
            {
                alertText = alert.Text;
                trimExpectedValue = expectedValue;
            }


            var isSucceeded = alertText != null && alertText.Contains(trimExpectedValue);

            return isSucceeded ? CheckResult.Succeeded : new CheckResult($"Alert does not contain expected value. Expected value: '{trimExpectedValue}', provided value: '{alertText}'");
        }
    }
}