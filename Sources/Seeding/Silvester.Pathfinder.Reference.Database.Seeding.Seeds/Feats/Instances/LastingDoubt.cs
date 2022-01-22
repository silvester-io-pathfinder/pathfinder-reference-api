using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LastingDoubt : Template
    {
        public static readonly Guid ID = Guid.Parse("7b0f6118-57f6-446d-86ad-eee8b52c2d84");

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
            yield return new TextBlock { Id = Guid.Parse("2b689cd0-81c2-4ecc-a719-a6e3535b8c8d"), Type = TextBlockType.Text, Text = $"When you cast doubt upon your foes, the effect lasts longer than usual. After being enfeebled 2 by your {ToMarkdownLink<Models.Entities.Feat>("Glimpse of Redemption", Feats.Instances.GlimpseOfRedemption.ID)}, the foe is enfeebled 1 for 1 minute. If you have {ToMarkdownLink<Models.Entities.Feat>("Weight of Guilt", Feats.Instances.WeightOfGuilt.ID)}, after being stupefied 2 by your {ToMarkdownLink<Models.Entities.Feat>("Glimpse of Redemption", Feats.Instances.GlimpseOfRedemption.ID)}, the foe is stupefied 1 for 1 minute or until the flat check from stupefied causes it to lose a spell, whichever comes first." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificCause(Guid.Parse("b7df0bda-caeb-4975-850d-7a666f11ba74"), Causes.Instances.Redeemer.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0528fd83-ab07-4873-ae76-eb7044a3e73b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
