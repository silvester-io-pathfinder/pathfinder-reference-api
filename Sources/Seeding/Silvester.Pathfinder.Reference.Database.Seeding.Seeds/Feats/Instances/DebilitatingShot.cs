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
    public class DebilitatingShot : Template
    {
        public static readonly Guid ID = Guid.Parse("6b83771d-6491-4f66-a095-25fceedfe0bb");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Debilitating Shot",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("256a62b2-2fd0-47fe-856a-4ca8c51f8e82"), Type = TextBlockType.Text, Text = $"Aiming for a weak point, you impede your foe with a precise shot. Make a ranged weapon {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}. If it hits and deals damage, the target is slowed 1 until the end of its next turn." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("c0c20276-e172-4583-b1f5-9dcf84e0ee87"), Traits.Instances.Fighter.ID);
            builder.Add(Guid.Parse("5cc6d8e3-678a-4c71-9037-cf06d2a53e7a"), Traits.Instances.Flourish.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5a1d307c-8650-4c06-9826-2aa7850cb1ff"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
