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
    public class ImpalingFinisher : Template
    {
        public static readonly Guid ID = Guid.Parse("4929e5d7-2f39-4dfe-b7c2-962c92026fc7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Impaling Finisher",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f1c2cc0f-2f35-465d-98d8-152f8ce16a3e"), Type = TextBlockType.Text, Text = $"You stab two foes with a single thrust or bash them together with one punch. Make a bludgeoning or piercing melee {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} and compare the attack roll result against the AC of up to two foes. One foe must be adjacent to you, and the other foe must be adjacent to and directly behind the first foe, in a straight line from your space. Roll damage once and apply it to each creature you hit. An Impaling Finisher counts as two attacks when calculating your multiple attack penalty." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Finisher.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Swashbuckler.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ef6255ff-7900-4cc7-9209-d63070926e29"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
