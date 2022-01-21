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
    public class Antimagic : Template
    {
        public static readonly Guid ID = Guid.Parse("aaaa1bfc-1a6f-4a5a-b2e7-3b9c779aa014");

        protected override ArmorPropertyRune GetArmorPropertyRune()
        {
            return new ArmorPropertyRune
            {
                Id = ID,
                Name = "Antimagic",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("8f63efb2-6386-411c-999e-d0344722aae9"), "This intricate rune displaces spell energy.");;
        }

        protected override IEnumerable<ArmorPropertyRuneVariant> GetArmorPropertyRuneVariants()
        {
            yield return new ArmorPropertyRuneVariant
            {
                Id = Guid.Parse("0df7fbff-c4fd-4d0b-b113-347130169eac"),
                Name = "Antimagic",
                Usage = "Etched onto armor.",
                CraftingRequirements = "Supply one casting of dispel magic.",
                Level = 15,
                Price = 650000,
                PotencyId = Potencies.Instances.Standard.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("0d06772e-488b-4833-bbc4-d79f5c95d5f1"), "You gain a +1 status bonus to saving throws against magical effects.")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("e5792f47-f358-4737-ac35-f036cf4382d9"), ActionTypes.Instances.Reaction.ID, "Activate", action => 
                    {
                        action
                            .Kind("Command")
                            .Frequency("Once per day.")
                            .Trigger("A spell targets you or includes you in its area.")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("115e39fb-1c6b-4394-9b58-3c4abb81a45a"), "The armor attempts to counteract the triggering spell with the effect of a 7th-level dispel magic spell and a counteract modifier of +26.");
                            });
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("03817cc3-64f7-4a66-aaf4-d62e916cdf50"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("efce482e-c4f4-4e1e-8d77-f77d5d900ed9"), Traits.Instances.Transmutation.ID);
            builder.Add(Guid.Parse("3e3c37d7-38a6-4f82-9c12-8508a13ac3db"), Traits.Instances.Uncommon.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("336109a6-8dc4-47ec-921a-188bb51582e3"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 582
            };
        }
    }
}
