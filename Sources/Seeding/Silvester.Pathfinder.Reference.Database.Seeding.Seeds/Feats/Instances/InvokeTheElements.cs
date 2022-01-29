using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class InvokeTheElements : Template
    {
        public static readonly Guid ID = Guid.Parse("15de3ee3-6046-4011-b881-b18ec1de9bdd");

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
            yield return new TextBlock { Id = Guid.Parse("61e8f779-7d31-4bd3-ac2f-dd2f36c05ade"), Type = TextBlockType.Text, Text = $"You summon an aura of shimmering heat, flurrying snow, crashing waves, or swirling wind and lightning. For 1 minute, you gain concealment against creatures more than 5 feet away, and any creature that ends its turn within 5 feet of you suffers 1d12 damage (basic Reflex save using your class DC or spell DC, whichever is higher). At 13th and 17th level, this damage increases by 1d12. A veil may changeling deals fire damage, a snow may changeling deals cold damage, a brine may changeling deals bludgeoning damage and the effect gains the {ToMarkdownLink<Models.Entities.Trait>("water", Traits.Instances.Water.ID)} trait, and a virga may changeling deals electricity damage." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("b17a1192-9458-475d-9c34-669219a403e6"), or => 
            {
                or.HaveSpecificFeat(Guid.Parse("36dbeed2-27f6-4a16-8c14-120aeeea53d5"), Feats.Instances.BrineMay.ID);
                or.HaveSpecificFeat(Guid.Parse("ab369acb-fce7-4a2f-ae08-9f2f5adc68d4"), Feats.Instances.SnowMay.ID);
                or.HaveSpecificFeat(Guid.Parse("487f3e76-ca20-4dfd-a76b-85df07e6d2e9"), Feats.Instances.VeilMay.ID);
                or.HaveSpecificFeat(Guid.Parse("26f01d55-6871-4146-a33b-e7d753b425b0"), Feats.Instances.VirgaMay.ID);
            });
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("d329fa4d-5717-49ed-a746-c92e82511a2d"), Traits.Instances.Changeling.ID);
            builder.Add(Guid.Parse("f1114cce-3085-48f4-b450-332531a4eb16"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("8e32afac-8f48-4fbf-b1a4-d2b61346b162"), Traits.Instances.Primal.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cb5de1f0-3a2f-4fa3-9df6-a2f7df34e331"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
