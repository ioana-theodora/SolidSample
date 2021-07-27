using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ArdalisRating
{
    public class PolicySerializer
    {
        public Policy GetPolicyFromJsonString(string policyName)
        {
            return JsonConvert.DeserializeObject<Policy>(policyName,
                new StringEnumConverter());
        }
    }
}
