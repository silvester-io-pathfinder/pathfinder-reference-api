using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Silvester.Pathfinder.Official.Api.Rest.Documents.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DocumentType
    {
        [EnumMember(Value = "privacy-policies")]
        PrivacyPolicies,
        [EnumMember(Value = "license-agreements")]
        LicenseAgreements
    }
}
