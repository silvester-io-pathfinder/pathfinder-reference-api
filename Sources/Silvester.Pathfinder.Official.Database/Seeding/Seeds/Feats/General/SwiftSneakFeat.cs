using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class SwiftSneakFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("3539bdbe-8e7f-45c0-a094-649d85d3adca");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Swift Sneak",
                Level = 7,
                FeatTypeId = FeatTypes.Instances.General.ID,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d0dfc3c2-425e-4551-9964-bbdf182c468b"), Type = Utilities.Text.TextBlockType.Text, Text = "You can move your full Speed when you Sneak. You can use Swift Sneak while Burrowing, Climbing, Flying, or Swimming instead of Striding if you have the corresponding movement type." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("48f78d64-fa2b-465d-83bb-b7b3d82d7709"), RequiredSkillId = Skills.Instances.Stealth.ID, RequiredProficiencyId = Proficiencies.Instances.Master.ID};
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.General.ID;
            yield return Traits.Instances.Skill.ID;
        }
    }
}
