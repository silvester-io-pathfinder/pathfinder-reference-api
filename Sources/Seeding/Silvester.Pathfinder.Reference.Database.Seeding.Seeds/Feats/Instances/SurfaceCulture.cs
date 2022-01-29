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
    public class SurfaceCulture : Template
    {
        public static readonly Guid ID = Guid.Parse("911be290-de51-427f-aded-8e0b3f9fc48c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Surface Culture",
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
            yield return new TextBlock { Id = Guid.Parse("ca751c9e-7336-48bd-80e4-25d504077a41"), Type = TextBlockType.Text, Text = $"~ Access: any surface dwarf ethnicity" };
            yield return new TextBlock { Id = Guid.Parse("24e7bf92-16ec-4429-a5ec-e06c61e5f13f"), Type = TextBlockType.Text, Text = $"Your interactions with other cultures on the surface have not only taught you about many other ancestries, but have also helped you realize the value of your own. You gain the trained proficiency rank in the Society skill (or another skill of your choice if you were already trained in Society), and you gain the {ToMarkdownLink<Models.Entities.Feat>("Additional Lore", Feats.Instances.AdditionalLore.ID)} skill feat for the Lore corresponding to your culture (for instance, Ouat Lore or Pahmet Lore)." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f9ab3cb7-07c7-433d-a317-a5c44bc5f3d1"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
