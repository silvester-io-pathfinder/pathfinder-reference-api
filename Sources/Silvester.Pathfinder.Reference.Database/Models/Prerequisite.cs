using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Models
{
    //Parent Types
    public abstract class Prerequisite : BaseEntity
    {
        public Guid BindingId { get; set; }
        public BasePrerequisiteBinding Binding { get; set; } = default!;

        public abstract class BasePrerequisiteBinding : BaseEntity
        {

        }

        public class BackgroundPrerequisiteBinding : BasePrerequisiteBinding
        {
            public Guid BackgroundId { get; set; }
            public Background Background { get; set; } = default!;
        }

        public class FeatPrerequisiteBinding : BasePrerequisiteBinding
        {
            public Guid FeatId { get; set; }
            public Feat Feat { get; set; } = default!;
        }

        public class OrBinding : BasePrerequisiteBinding
        {
            public Guid PrerequisiteId { get; set; }
            public OrPrerequisite Prerequisite { get; set; } = default!;
        }
    }

    //Concrete Types
    public class SkillPrerequisite : Prerequisite
    {
        public Guid? RequiredSkillId { get; set; } = null;
        public Skill? RequiredSkill { get; set; } = default!;

        public Guid RequiredProficiencyId { get; set; }
        public Proficiency RequiredProficiency { get; set; } = default!;
    }

    public class RecallKnowledgePrerequisite : Prerequisite
    {
        public Guid RequiredProficiencyId { get; set; }
        public Proficiency RequiredProficiency { get; set; } = default!;

        public bool RequiresAssurance { get; set; }
    }

    public class FeatPrerequisite : Prerequisite
    {
        public Guid RequiredFeatId { get; set; }
        public Feat RequiredFeat { get; set; } = default!;
    }

    public class LevelPrerequisite : Prerequisite
    {
        public int RequiredLevel{ get; set; }
    }

    public class StatPrerequisite : Prerequisite
    {
        public int RequiredStatValue { get; set; }

        public Guid RequiredStatId { get; set; }
        public Stat RequiredStat { get; set; } = default!;
    }

    public class DeityPrerequisite : Prerequisite
    {
        public Guid RequiredDeityId { get; set; }
        public Deity RequiredDeity { get; set; } = default!;
    }

    public class LorePrerequisite : Prerequisite
    {
        public Guid RequiredProficiencyId { get; set; }
        public Proficiency RequiredProficiency { get; set; } = default!;

        public Guid? RequiredLoreId { get; set; }
        public Lore? RequiredLore { get; set; } 
    }

    public class AncestryPrerequisite : Prerequisite
    {
        public Guid RequiredAncestryId { get; set; }
        public Ancestry RequiredAncestry { get; set; } = default!;
    }

    public class OrPrerequisite : Prerequisite
    {
        public ICollection<Prerequisite> Choices { get; set; } = new List<Prerequisite>();
    }
}
