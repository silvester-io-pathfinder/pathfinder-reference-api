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
    public class ScoutsWarning : Template
    {
        public static readonly Guid ID = Guid.Parse("9c35b21f-e7df-468d-abce-fb12063feb0d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Scout's Warning",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You are about to roll a Perception or Survival check for initiative.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("09c5fb26-a4fd-474c-9e95-d216e22d451a"), Type = TextBlockType.Text, Text = $"You visually or audibly warn your allies of danger, granting them each a +1 circumstance bonus to their initiative rolls. Depending on whether you use gestures or call out, this action gains either the {ToMarkdownLink<Models.Entities.Trait>("visual", Traits.Instances.Visual.ID)} or {ToMarkdownLink<Models.Entities.Trait>("auditory", Traits.Instances.Auditory.ID)} trait, respectively." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("fbfbd63f-75ba-492e-98d8-619143121ed6"), Traits.Instances.Ranger.ID);
            builder.Add(Guid.Parse("f4dcbfa2-189f-4d34-8bfa-344f9d0ade72"), Traits.Instances.Rogue.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dd94f112-fb5b-40ca-9599-69f7f3845419"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
