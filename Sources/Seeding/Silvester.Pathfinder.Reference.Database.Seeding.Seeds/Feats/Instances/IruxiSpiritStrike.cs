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
    public class IruxiSpiritStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("f07bf2c2-f05a-4069-a967-621ad5c0578b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Iruxi Spirit Strike",
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
            yield return new TextBlock { Id = Guid.Parse("0789e7a1-4df2-488b-afa2-07f6e2640674"), Type = TextBlockType.Text, Text = $"Your iruxi unarmed attacks channel the spiritual energy of your ancestors. Any unarmed attacks you acquire from iruxi heritages or ancestry feats gain the effects of a {ToMarkdownLink<Models.Items.Instances.WeaponPropertyRune>("ghost touch", Items.WeaponPropertyRunes.Instances.GhostTouch.ID)} property rune." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Lizardfolk.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0ed21bfc-0d81-48a2-b4bb-626c6abaf210"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
