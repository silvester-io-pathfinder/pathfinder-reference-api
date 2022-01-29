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
    public class FeyCantrips : Template
    {
        public static readonly Guid ID = Guid.Parse("5c35f6a7-86c7-498f-b5e3-7406818e8a70");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fey Cantrips",
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
            yield return new TextBlock { Id = Guid.Parse("467c2a82-6726-4bfb-b031-90c80e4a88a7"), Type = TextBlockType.Text, Text = $"You've learned the cantrips sprites have used since time immemorial. You gain {ToMarkdownLink<Models.Entities.Spell>("dancing lights", Spells.Instances.DancingLights.ID)} and {ToMarkdownLink<Models.Entities.Spell>("ghost sound", Spells.Instances.GhostSound.ID)} as primal innate cantrips. If you have the grig heritage, you also gain {ToMarkdownLink<Models.Entities.Spell>("detect magic", Spells.Instances.DetectMagic.ID)}, and if you have the draxie heritage, you gain {ToMarkdownLink<Models.Entities.Spell>("prestidigitation", Spells.Instances.Prestidigitation.ID)}." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Sprite.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fba5770f-4198-4fa0-bc44-2f04994bfdf7"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
