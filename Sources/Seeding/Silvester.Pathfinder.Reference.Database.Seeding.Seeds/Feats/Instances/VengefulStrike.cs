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
    public class VengefulStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("b8b9dde7-fd72-4d46-9d3a-186bebdea441");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Vengeful Strike",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "A creature within your reach succeeds or critically succeeds at an attack against you.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d126ae81-c3fc-485a-b7ca-b9fac501dcdb"), Type = TextBlockType.Text, Text = $"When struck by an enemy, you respond in turn. Make a melee {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} against the triggering creature. This {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} doesn't count toward your multiple attack penalty, and your multiple attack penalty doesn't apply to this {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Barbarian.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Rage.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("52ea673b-5029-4a82-b29b-ff00d8baf4a7"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
