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
    public class ShaitanSkin : Template
    {
        public static readonly Guid ID = Guid.Parse("4fb16bbc-b808-40a8-b06a-653a08b59743");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shaitan Skin",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ab2884f0-6317-4c56-955d-cbe62e0e7e35"), Type = TextBlockType.Text, Text = $"When in danger, you can harden the stone in your skin into armor, much like a shaitan. You can cast {ToMarkdownLink<Models.Entities.Spell>("stoneskin", Spells.Instances.Stoneskin.ID)} on yourself only, 3 times per day as a 4th-level arcane innate spell." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("d6ae79fb-f201-4549-b0a1-65f5b92ac24a"), Traits.Instances.Oread.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3851d6f5-6a26-49cb-ba1f-770fa91daccc"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
