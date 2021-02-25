using System.Text.Json;

namespace RoCrateValidator
{
    public class Validator
    {
        public bool IsValidRoCrate(string payload)
        {
            return IsValidJson(payload);
        }


        private bool IsValidJson(string payload)
        {
            bool isValid = false;
            var o = JsonSerializer.Deserialize<object>(payload);

            return isValid;
        }
    }
}
