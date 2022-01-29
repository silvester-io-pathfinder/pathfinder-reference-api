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
    public class WardAgainstCorruption : Template
    {
        public static readonly Guid ID = Guid.Parse("cd92e6d3-a6f6-458f-b97d-2f844ab3188e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ward Against Corruption",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6acf225d-78bf-4337-a457-cf02cb47df61"), Type = TextBlockType.Text, Text = $"Your soul is warded against the power of undeath and plague, as well as that of the evil former psychopomps known as sahkils. You gain a +1 circumstance bonus to saving throws against {ToMarkdownLink<Models.Entities.Trait>("death", Traits.Instances.Death.ID)} effects, disease, and all effects from undead or sahkils. This bonus increases to +2 against an undead or sahkil's {ToMarkdownLink<Models.Entities.Trait>("death", Traits.Instances.Death.ID)} effect or disease." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("87203b8a-7ba5-418b-8dfc-ae68bed28c0e"), Traits.Instances.Duskwalker.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("93e76eb0-069e-4c9a-baa9-ae5e26c94572"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
