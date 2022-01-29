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
    public class CannonCornerShot : Template
    {
        public static readonly Guid ID = Guid.Parse("ac42ef87-9be7-4ea5-a872-1841d81dc086");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cannon Corner Shot",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c5c38b33-b6b7-43b0-9276-ea98f7e51890"), Type = TextBlockType.Text, Text = $"By loading special ammunition in a particular way, you can make your siege weapons do all manner of tricks that other siege engineers can barely even imagine. If you personally contribute an additional Load action to the siege weapon's loading, above the minimum, you can change a burst into a line twice as long as the size of the burst, or vice versa (so a 10-foot burst turns into a 20-foot line, or a 20-foot line turns into a 10-foot burst)." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("029a9987-9872-4749-82e5-aab488a31b12"), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("66904533-b3b3-4079-b277-9640f439c4b8"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
