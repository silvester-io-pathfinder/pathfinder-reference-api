using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LastingDoubt : Template
    {
        public static readonly Guid ID = Guid.Parse("e9fdbca1-a4ee-4745-9644-15b07b06265c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Lasting Doubt",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6e045514-ea24-4ee3-88bb-c1a46dc3b05c"), Type = TextBlockType.Text, Text = "When you cast doubt upon your foes, the effect lasts longer than usual. After being enfeebled 2 by your (feat: Glimpse of Redemption), the foe is enfeebled 1 for 1 minute. If you have (feat: Weight of Guilt), after being stupefied 2 by your (feat: Glimpse of Redemption), the foe is stupefied 1 for 1 minute or until the flat check from stupefied causes it to lose a spell, whichever comes first." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificCause(Guid.Parse("8055f5cb-0fef-430c-9bd3-ff5276d1a29c"), Causes.Instances.Redeemer.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5d436209-63e5-400d-9813-adceebed5be1"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
