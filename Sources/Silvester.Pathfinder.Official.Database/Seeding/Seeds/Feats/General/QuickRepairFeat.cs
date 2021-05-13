using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class QuickRepairFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("48c371fb-6e9c-4d4f-965d-d56694b52100");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Quick Repair",
                Level = 1,
                FeatTypeId = FeatTypes.Instances.General.ID,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("79f8ff8b-a14d-4621-ab56-df66be388a38"), Type = Utilities.Text.TextBlockType.Text, Text = "You take 1 minute to Repair an item. If you’re a master in Crafting, it takes 3 actions. If you’re legendary, it takes 1 action." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("850cf013-7103-4c37-8bb9-b1a66c3fb583"), RequiredSkillId = Skills.Instances.Crafting.ID, RequiredProficiencyId = Proficiencies.Instances.Trained.ID };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.General.ID;
            yield return Traits.Instances.Skill.ID;
        }
    }
}
