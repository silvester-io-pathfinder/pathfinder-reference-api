using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class NimbleRoll : Template
    {
        public static readonly Guid ID = Guid.Parse("4fb7c70d-0d77-4ca4-bff2-67ba98d800d9");

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
            yield return new TextBlock { Id = Guid.Parse("69b3ece4-40a1-4e9b-b128-eb35c02766c2"), Type = TextBlockType.Text, Text = "You can use (feat: Nimble Dodge) before attempting a Reflex save, in addition to its original trigger. If you do, the circumstance bonus applies to your Reflex save against the triggering effect." };
            yield return new TextBlock { Id = Guid.Parse("322f5067-2f01-4bea-a458-66a0900e39c9"), Type = TextBlockType.Text, Text = "When you use (feat: Nimble Dodge) and the triggering attack fails or critically fails, or when you succeed or critically succeed at the saving throw, you can also (action: Stride) up to 10 feet as part of the reaction. If you do, the reaction gains the (trait: move) trait. You can use Nimble Roll while (action: Flying | Fly) or (action: Swimming | Swim) instead of (action: Striding | Stride) if you have the corresponding movement type." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("58d38a3e-5295-4ff6-bae9-c9cbc06a02b7"), Feats.Instances.NimbleDodge.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9d69f072-ccc6-47b1-97de-fbfa4a6c6633"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
