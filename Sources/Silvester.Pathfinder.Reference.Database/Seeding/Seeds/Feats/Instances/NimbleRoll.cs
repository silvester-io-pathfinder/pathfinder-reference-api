using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class NimbleRoll : Template
    {
        public static readonly Guid ID = Guid.Parse("65a476e3-23d6-4cfb-af8b-c6ea8895eefa");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Nimble Roll",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8590a753-ad3b-4ae6-bdb5-a1a9551f8edd"), Type = TextBlockType.Text, Text = "You can use (feat: Nimble Dodge) before attempting a Reflex save, in addition to its original trigger. If you do, the circumstance bonus applies to your Reflex save against the triggering effect." };
            yield return new TextBlock { Id = Guid.Parse("5976c0c6-348a-4dc0-8a09-b37f02a04097"), Type = TextBlockType.Text, Text = "When you use (feat: Nimble Dodge) and the triggering attack fails or critically fails, or when you succeed or critically succeed at the saving throw, you can also (action: Stride) up to 10 feet as part of the reaction. If you do, the reaction gains the (trait: move) trait. You can use Nimble Roll while (action: Flying | Fly) or (action: Swimming | Swim) instead of (action: Striding | Stride) if you have the corresponding movement type." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("c0b2ac18-7108-46ab-9af3-45a7f6104dbf"), Feats.Instances.NimbleDodge.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9a630319-360d-40d3-b94e-fa7e51fbc260"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
