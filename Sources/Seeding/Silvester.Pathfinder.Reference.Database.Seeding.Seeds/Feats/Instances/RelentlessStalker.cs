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
    public class RelentlessStalker : Template
    {
        public static readonly Guid ID = Guid.Parse("b9502a49-e614-4005-b820-4066ecdfa17b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Relentless Stalker",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An adjacent creature you are hunting attempts to move away from you using an action that has the move trait.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0680aa4d-b941-4488-8247-fa104fb37d78"), Type = TextBlockType.Text, Text = $"Your hunted prey cannot escape your relentless pursuit. {ToMarkdownLink<Models.Entities.Action>("Stride", Actions.Instances.Stride.ID)} up to your Speed in tandem with the triggering creature, remaining adjacent to the foe throughout its movement until it stops moving or you run out of movement. You can ignore difficult terrain during this movement unless the difficult terrain is caused by a {ToMarkdownLink<Models.Entities.Trait>("magical", Traits.Instances.Magical.ID)} effect." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Move.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Ranger.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("55eabd3d-a295-4d85-b5fa-a825af5d62ff"),
                SourceId = Sources.Instances.FallOfPlaguestone.ID,
                Page = -1
            };
        }
    }
}
