using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class InvokeTheElements : Template
    {
        public static readonly Guid ID = Guid.Parse("8b042d60-2cc1-488a-a0a6-3b66bbd75772");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Invoke the Elements",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c7aacb65-9884-4f61-9552-a3eac15a0231"), Type = TextBlockType.Text, Text = "You summon an aura of shimmering heat, flurrying snow, crashing waves, or swirling wind and lightning. For 1 minute, you gain concealment against creatures more than 5 feet away, and any creature that ends its turn within 5 feet of you suffers 1d12 damage (basic Reflex save using your class DC or spell DC, whichever is higher). At 13th and 17th level, this damage increases by 1d12. A veil may changeling deals fire damage, a snow may changeling deals cold damage, a brine may changeling deals bludgeoning damage and the effect gains the (trait: water) trait, and a virga may changeling deals electricity damage." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("ef55af66-e068-49ae-92fc-ec12e8661ad4"), or => 
            {
                or.HaveSpecificFeat(Guid.Parse("cf2d1859-3570-4e29-9785-1e3c7d9054fa"), Feats.Instances.BrineMay.ID);
                or.HaveSpecificFeat(Guid.Parse("ede0cc1b-7a16-4352-a11a-f9e8fc4de649"), Feats.Instances.SnowMay.ID);
                or.HaveSpecificFeat(Guid.Parse("9411e431-6957-4223-a614-6696ca7911e4"), Feats.Instances.VeilMay.ID);
                or.HaveSpecificFeat(Guid.Parse("ffcf73ad-26b4-4b42-98d5-feeb823cf3bb"), Feats.Instances.VirgaMay.ID);
            });
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("edaa0dd6-7b84-48f1-902c-2297b1014885"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
