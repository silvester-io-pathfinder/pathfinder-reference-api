using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class InstantBackup : Template
    {
        public static readonly Guid ID = Guid.Parse("236f83b3-3429-46a4-941c-eb8d5f15d232");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Instant Backup",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "Your attack with a firearm misfires.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5faeb877-51f4-4be2-a24c-9f3b42864240"), Type = TextBlockType.Text, Text = "Even as your firearm misfires, you quickly draw a backup weapon. (action: Release) the (trait: misfired|misfire) weapon if you so choose, and (action: Interact) to draw a one-handed weapon." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6e38e9a5-9ff5-4445-a062-ca0e27e735e4"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
