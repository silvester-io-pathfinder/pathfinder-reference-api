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
    public class ShoryAeromancer : Template
    {
        public static readonly Guid ID = Guid.Parse("5a969dce-e5ff-442d-9301-777c37518039");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shory Aeromancer",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ffc34b77-07a8-4c5b-b8d1-56b0d3fa60a3"), Type = TextBlockType.Text, Text = $"~ Access: Garundi, Mauxi, or Tian-Yae ethnicity" };
            yield return new TextBlock { Id = Guid.Parse("8d46638f-7aa2-48c2-a6d9-e893c510bb97"), Type = TextBlockType.Text, Text = $"Your ancestors hailed from the flying cities of the Shory, and a few simple tricks have come down through the ages to you. You can cast 4th-level {ToMarkdownLink<Models.Entities.Spell>("fly", Spells.Instances.Fly.ID)} on yourself as an innate arcane spell once per day." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4138e55b-0f07-44a8-8f05-85d569d0834f"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
