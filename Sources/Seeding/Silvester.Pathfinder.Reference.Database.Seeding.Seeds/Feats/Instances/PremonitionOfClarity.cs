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
    public class PremonitionOfClarity : Template
    {
        public static readonly Guid ID = Guid.Parse("ce72e436-b663-4200-b556-f8cc84c6cf1c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Premonition of Clarity",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You fail a saving throw against a mental effect.",
                Frequency = "once per hour"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5d7c2d67-6eba-4587-ae4a-edace360fcec"), Type = TextBlockType.Text, Text = $"Your deity sends you a vision of faith to steel you against mental attacks. Reroll the triggering saving throw with a +2 circumstance bonus. You must use the second result, even if it's worse." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("e24f06e9-4521-4e17-a6e8-1c2d13961cf2"), Traits.Instances.Cleric.ID);
            builder.Add(Guid.Parse("e38b740b-9132-4d1f-88e5-ff6542f92fb5"), Traits.Instances.Fortune.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9b1756ac-9cc9-4366-854e-5f510ea44469"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
