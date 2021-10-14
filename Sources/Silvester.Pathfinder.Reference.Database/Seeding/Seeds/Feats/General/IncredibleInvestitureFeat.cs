using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.General
{
    public class IncredibleInvestitureFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("9b475bb4-2086-4f81-b4ab-ef3f8f09f5db");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Incredible Investiture",
                Level = 11,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7be3eec5-5c9b-4f76-b412-3bec0c802dd6"), Type = Utilities.Text.TextBlockType.Text, Text = "You have an incredible ability to invest more magic items. Increase your limit on invested items from 10 to 12." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new StatPrerequisite { Id = Guid.Parse("11098127-44c6-4d82-9977-981fc20e637b"), RequiredStatValue = 16, RequiredStatId = Stats.Instances.Charisma.ID };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.General.ID;
            yield return Traits.Instances.Skill.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("52727a8b-73e2-4f54-8827-975cbe0e6ebe"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 262
            };
        }
    }
}
