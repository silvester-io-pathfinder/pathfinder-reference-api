using NpgsqlTypes;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Models
{
    public class PlayMode : BaseEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public ICollection<SkillAction> SkillActions { get; set; } = new List<SkillAction>();
    }
}
