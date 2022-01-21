using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.ArmorPropertyRunes.Instances
{
    public class Soaring : Template
    {
        public static readonly Guid ID = Guid.Parse("a3e92834-573a-417f-9ffa-710c6ac73bff");

        protected override ArmorPropertyRune GetArmorPropertyRune()
        {
            return new ArmorPropertyRune
            {
                Id = ID,
                Name = "Soaring",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("cdcf5422-2d5d-4724-a17b-f09f6094bc65"), "A set of soaring armor helps you fly faster and protects you and nearby allies from falling.");;
        }

        protected override IEnumerable<ArmorPropertyRuneVariant> GetArmorPropertyRuneVariants()
        {
            yield return new ArmorPropertyRuneVariant
            {
                Id = Guid.Parse("47be5207-8598-4900-99bb-ffe41368b1e5"),
                Name = "Soaring",
                Usage = "Etched onto armor.",
                Level = 14,
                Price = 375000,
                PotencyId = Potencies.Instances.Standard.ID,
				BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("8ae1ed0d-92bc-462e-b18c-daf665416dbb"), "While wearing soaring armor, you gain a +10-foot item bonus to your fly Speed, if you have one. As normal, if your fly Speed is based on your land Speed and you already have an item bonus to your land Speed, these bonuses aren't cumulative.")
					.Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("f3c28f6d-d789-4e72-80a9-c362ce75ab60"), ActionTypes.Instances.Reaction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Command")
                            .Trigger("You or a creature within 60 feet of you is falling.")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("e6dc67af-4cb3-44c8-9fd2-bbb9e051fae2"), "You cast feather fall on the triggering creature.");
                            });
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("6d7c2726-e0d7-405b-81e1-964ac01e56d8"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("2b15128a-ee8b-4f2f-9f6e-266ea8db2333"), Traits.Instances.Abjuration.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4dc7607b-00e0-400d-bf86-5acb21368509"),
                SourceId = Sources.Instances.AncestryGuide.ID,
                Page = 139
            };
        }
    }
}
