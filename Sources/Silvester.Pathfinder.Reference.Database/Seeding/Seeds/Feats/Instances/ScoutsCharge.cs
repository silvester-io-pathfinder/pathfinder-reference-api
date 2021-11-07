using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ScoutsCharge : Template
    {
        public static readonly Guid ID = Guid.Parse("53b8dd5e-f0b1-4b28-ad00-10f42fa2c37a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Scout's Charge",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("80547c1b-49ee-43d4-bc0a-395f48d50d48"), Type = TextBlockType.Text, Text = "You meander around unpredictably, and then ambush your opponents without warning. Choose one enemy. (action: Stride), (action: Feint) against that opponent, and then make a (action: Strike) against that foe. For your (action: Feint), you can attempt a Stealth check instead of the Deception check that’s usually required, because you use the terrain around you to catch your foe off-guard." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("92cc0ab4-295d-48f7-9f53-b3629019f72e"), Feats.Instances.ScoutDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d85e9f59-7d4c-4378-a74b-372bfc00243f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
