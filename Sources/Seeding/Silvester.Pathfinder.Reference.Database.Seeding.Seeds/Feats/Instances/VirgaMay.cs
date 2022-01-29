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
    public class VirgaMay : Template
    {
        public static readonly Guid ID = Guid.Parse("1dc43c59-df0b-4327-ae39-426646037cf8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Virga May",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6a34150c-9a15-4863-b3a7-c3a09fdbbd5c"), Type = TextBlockType.Text, Text = $"Born of a storm hag, you have one crystal-blue or rain-gray eye. You share your mother's power over wind and storm. You can cast {ToMarkdownLink<Models.Entities.Spell>("electric arc", Spells.Instances.ElectricArc.ID)} as an occult innate cantrip. As normal, a cantrip is heightened to a spell level equal to half your level rounded up." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("d1a359e8-ad7a-49ea-89bd-1c73eea40dfa"), Traits.Instances.Changeling.ID);
            builder.Add(Guid.Parse("75e92ec5-0560-466b-8801-cb12e47e99a7"), Traits.Instances.Lineage.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7fc07fc6-6b69-47f6-b08c-076812017308"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
