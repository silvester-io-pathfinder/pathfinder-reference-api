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
    public class FerociousGust : Template
    {
        public static readonly Guid ID = Guid.Parse("7cb25d4b-b83c-4231-b066-9f30f8a54f21");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ferocious Gust",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per 10 minutes"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1ea87f25-0530-4420-9170-e1f8478e9577"), Type = TextBlockType.Text, Text = $"With heavy wing beats, you whip up a furious gust and direct it at your opponents. This air blast has the effects of {ToMarkdownLink<Models.Entities.Spell>("gust of wind", Spells.Instances.GustOfWind.ID)} with a DC equal to your class DC or spell DC, whichever is higher." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("6541e94c-945d-41bd-9efb-edd7c172b427"), Traits.Instances.Air.ID);
            builder.Add(Guid.Parse("853995b1-c561-4ec9-9f1c-da1ab107f9eb"), Traits.Instances.Concentrate.ID);
            builder.Add(Guid.Parse("da19276a-b3cc-4f5e-89af-7441dc59ab0f"), Traits.Instances.Manipulate.ID);
            builder.Add(Guid.Parse("b66f6c57-6f0c-46ae-9336-76314f8edcaa"), Traits.Instances.Strix.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("19a85c41-615d-4975-965b-f34047743716"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
