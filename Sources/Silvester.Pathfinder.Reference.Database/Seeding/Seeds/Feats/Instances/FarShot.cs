using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FarShot : Template
    {
        public static readonly Guid ID = Guid.Parse("5c5c9c24-04a9-4383-a5dc-e76a94454197");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Far Shot",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("63f724d0-7662-47a0-9a16-680b09a79e26"), Type = TextBlockType.Text, Text = "Your experience in the field has taught you how to focus your aim at a distance, increasing your accuracy. Double your weapons’ range increments." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5aa95914-cd49-4538-89a8-fb8e38019835"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
