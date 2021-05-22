using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class CloudJumpFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("9ab4e3c9-f592-4c0d-ac6e-adb33651feca");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cloud Jump",
                Level = 15,
                FeatTypeId = FeatTypes.Instances.General.ID,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("70b38a25-db58-44a1-8785-a7124775e352"), Type = Utilities.Text.TextBlockType.Text, Text = "You unparalleled athletic skill allows you to jump impossible distances. Triple the distance you Long Jump (so you could jump 60 feet on a successful DC 20 check). When you High Jump, use the calculation for a Long Jump but don’t triple the distance." };
            yield return new TextBlock { Id = Guid.Parse("98e7f9c9-8027-485d-af27-2de34ee1e1da"), Type = Utilities.Text.TextBlockType.Text, Text = "You can jump a distance greater than your Speed by spending additional actions when you Long Jump or High Jump. For each additional action spent, add your Speed to the limit on how far you can Leap." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("638cc413-e502-4f9c-9183-da9958c38df9"), RequiredSkillId = Skills.Instances.Athletics.ID, RequiredProficiencyId = Proficiencies.Instances.Legendary.ID };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.General.ID;
            yield return Traits.Instances.Skill.ID;
        }
    }
}
