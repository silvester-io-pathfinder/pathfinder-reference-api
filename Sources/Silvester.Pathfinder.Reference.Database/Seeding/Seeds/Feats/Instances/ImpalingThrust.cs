using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ImpalingThrust : Template
    {
        public static readonly Guid ID = Guid.Parse("bc4e4324-0922-4ddb-9a54-b74f2f79e640");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Impaling Thrust",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("838fa2b3-1fa3-46b9-a7d7-35c5fe3e5670"), Type = TextBlockType.Text, Text = "You impale your enemy and hold them in place with your weapon. Make a melee (action: Strike) with the required weapon. If the (action: Strike) hits and deals damage, your target is grabbed until they successfully (action: Escape), you attack with the required weapon, or you (action: Release) the required weapon, whichever comes first. When the target is no longer grabbed, they take persistent bleed damage equal to the number of weapon damage dice." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ef892e81-bd43-4dd9-89c7-0624d466bfd6"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
