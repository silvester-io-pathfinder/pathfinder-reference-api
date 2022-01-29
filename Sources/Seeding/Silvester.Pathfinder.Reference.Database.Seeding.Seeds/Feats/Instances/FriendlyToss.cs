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
    public class FriendlyToss : Template
    {
        public static readonly Guid ID = Guid.Parse("de048fbd-593c-44db-a42e-4e7706840098");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Friendly Toss",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c3261371-4d31-43cb-97cf-7a2067600e05"), Type = TextBlockType.Text, Text = $"You toss your friends around the battlefield. Pick up an adjacent ally of your size or smaller and throw them to an unoccupied space you can see within 30 feet. Their movement doesn't trigger reactions. Your ally ends this movement on their feet and doesn't take damage from the fall. If your ally ends this movement within melee reach of at least one enemy, they can make a melee {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} against an enemy within their reach as a reaction." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("6a28155f-4ba8-4fa6-9c38-11df3c9275e6"), Traits.Instances.Barbarian.ID);
            builder.Add(Guid.Parse("7f3012a3-482f-4c85-ab8a-8415d0304d5d"), Traits.Instances.Manipulate.ID);
            builder.Add(Guid.Parse("7d18a5ff-7d25-4b15-99ef-ea28ba348ea3"), Traits.Instances.Rage.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e9fb79b0-26fa-4e41-81cb-1c5f08628295"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
