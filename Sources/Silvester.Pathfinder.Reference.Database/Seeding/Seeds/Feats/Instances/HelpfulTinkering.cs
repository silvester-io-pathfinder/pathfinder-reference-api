using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HelpfulTinkering : Template
    {
        public static readonly Guid ID = Guid.Parse("97d9a3fd-c84b-4bed-90f1-f6f407767a98");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Helpful Tinkering",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per 10 minutes"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1b1f1c1d-17f0-497c-a1f4-e93957f3fcfe"), Type = TextBlockType.Text, Text = "You don’t just tinker with your own innovation, you fiddle with your allies’ weapons as well (for their benefit, of course). Choose an ally in your reach and one of their weapons. Attempt a Crafting check against a high DC for your level." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificClassFeature(Guid.Parse("64225264-5e2d-469c-81dd-d6373df6652d"), ClassFeatures.Gunslingers.OffensiveBoost.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("33dd2f96-fefe-4490-a303-cba4b8155676"),
                
                Success = "For 1 minute, the chosen ally’s (action: Strikes | Strike) with the chosen weapon gain the same offensive boost your innovation has.",
                
                CriticalFailure = "Your ally takes damage of the type and amount that your offensive boost normally deals on a successful (action: Strike).", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("eafb2200-1799-49d6-88e7-9a9327989d96"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
