using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RampagingFerocity : Template
    {
        public static readonly Guid ID = Guid.Parse("78b0ac59-763e-4d82-9c99-f51606398a61");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Rampaging Ferocity",
                Level = 17,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You use Orc Ferocity.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ec907c1d-cff7-4d10-862a-c35240ceb003"), Type = TextBlockType.Text, Text = "You lash out viciously even as you fend off death. Make a single melee (action: Strike). If this (action: Strike) brings a foe to 0 Hit Points, this activation of (feat: Orc Ferocity) doesn&#39;t count against its frequency." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("168df9cd-e842-4093-bf56-8ac125b47e69"), Feats.Instances.OrcFerocity.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9603ea50-5956-4ecc-a991-13fbcff46523"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
