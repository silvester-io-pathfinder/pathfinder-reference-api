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
    public class AnimalisticResistance : Template
    {
        public static readonly Guid ID = Guid.Parse("faa9e64f-48c4-432b-8994-665955996040");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Animalistic Resistance",
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
            yield return new TextBlock { Id = Guid.Parse("a643cce8-054d-400b-bc71-c20a0fd72ec4"), Type = TextBlockType.Text, Text = $"Your animalistic connections help you resist natural afflictions. You gain a +2 circumstance bonus to saves to resist diseases and poisons." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("8b91ec50-58fa-40d7-a762-06f5583c54ec"), Traits.Instances.Beastkin.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0a3d1308-b0aa-49a8-9af4-61f7d711b9bb"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
