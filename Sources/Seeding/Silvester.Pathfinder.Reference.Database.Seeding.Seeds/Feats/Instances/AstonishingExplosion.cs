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
    public class AstonishingExplosion : Template
    {
        public static readonly Guid ID = Guid.Parse("c85a6e7c-63f0-4510-aa7a-2f551dfeb6cc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Astonishing Explosion",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You use Quick Alchemy to craft an alchemical bomb that deals splash damage and is at least 2 levels lower than your advanced alchemy level.",
                Frequency = "once per minute"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("cedd3e03-7644-47d5-b899-0f82b25719b2"), Type = TextBlockType.Text, Text = $"Your bomb incorporates an explosive spark of wonder that leaves witnesses dumbfounded. Any target hit by your {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} with the bomb is fascinated by you for 1 round. On a critical success, the target is also stunned 1." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Additive.ID, "2");
            builder.Add(Guid.Parse(""), Traits.Instances.Alchemist.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a4123cab-e580-4514-a36a-9744b1766376"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
