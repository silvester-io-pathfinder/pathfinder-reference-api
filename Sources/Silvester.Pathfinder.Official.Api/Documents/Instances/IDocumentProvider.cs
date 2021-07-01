using Silvester.Pathfinder.Official.Api.Documents.Models;
using Silvester.Pathfinder.Official.Documents.Models;

namespace Silvester.Pathfinder.Official.Api.Documents.Instances.PrivacyPolicies
{
    public interface IDocumentProvider
    {
        public DocumentType Type { get; }
        public int Version { get; }
        public Document Document { get; }
    }
}