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
    public class Musetouched : Template
    {
        public static readonly Guid ID = Guid.Parse("14f5e14e-1f9f-4f85-ae81-3677c4cc87d5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Musetouched",
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
            yield return new TextBlock { Id = Guid.Parse("fb4dd606-3ada-4a4c-ae8d-316588c0d4c0"), Type = TextBlockType.Text, Text = $"Your blood sings with the liberating power of the azatas, living embodiments of freedom from the wild realm of Elysium. You gain a +1 circumstance bonus to {ToMarkdownLink<Models.Entities.Action>("Escape", Actions.Instances.Escape.ID)}. When you roll a critical failure on a check to Escape, you get a failure instead, and when you roll a success, you get a critical success instead." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("6a1448aa-e596-415f-a0b2-1b7264fe8431"), Traits.Instances.Aasimar.ID);
            builder.Add(Guid.Parse("657f3907-bde3-4583-82cf-7bc52d2bb840"), Traits.Instances.Lineage.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8646824a-fe66-4027-a59b-10f0a134e024"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
