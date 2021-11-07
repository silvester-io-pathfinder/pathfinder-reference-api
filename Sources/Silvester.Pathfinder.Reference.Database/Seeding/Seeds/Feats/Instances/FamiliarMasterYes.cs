using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FamiliarMasterYes : Template
    {
        public static readonly Guid ID = Guid.Parse("43a25762-ad0b-4545-bf89-69e20801082d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Familiar Master - Yes",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ba7fa3f4-2c67-49a2-a2b3-38f4f39d0948"), Type = TextBlockType.Text, Text = "You already have a familiar, you gain the (feat: Enhanced Familiar) feat." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c9ba6be0-e87c-4f70-8405-2839289c7e52"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
