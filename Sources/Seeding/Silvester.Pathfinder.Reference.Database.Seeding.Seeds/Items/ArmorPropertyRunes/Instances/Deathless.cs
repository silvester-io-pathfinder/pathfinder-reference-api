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
    public class Deathless : Template
    {
        public static readonly Guid ID = Guid.Parse("386c1a29-92f2-40f0-a07c-d2ef085237f6");
        public static readonly Guid STANDARD_ID = Guid.Parse("910d870e-c394-472c-895e-97fc9cde3982");

        protected override ArmorPropertyRune GetArmorPropertyRune()
        {
            return new ArmorPropertyRune
            {
                Id = ID,
                Name = "Deathless",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("346e0d60-e52c-436a-b2d8-50d117bd2600"), "These symbols fortify your body's grasp on your soul, keeping it tethered when death approaches.");
        }

        protected override IEnumerable<ArmorPropertyRuneVariant> GetArmorPropertyRuneVariants()
        {
            yield return new ArmorPropertyRuneVariant
            {
                Id = STANDARD_ID,
                Name = "Deathless",
                Usage = "Etched onto armor.",
                Level = 7,
                Price = 33000,
                PotencyId = Potencies.Instances.Standard.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("42e158aa-a7c6-4771-9dc6-2cd326affb2c"), ActionTypes.Instances.Reaction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Envision")
                            .Frequency("Once per day.")
                            .Trigger("You gain the doomed or wounded condition.")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("eb2f2bf3-b9d4-4ab7-841c-febb053a7932"), "You reduce the value of the triggering condition by 1.");
                            });
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("352c5e17-b438-4edc-9d34-c504b7e76b1e"), Traits.Instances.Healing.ID);
            builder.Add(Guid.Parse("ec7dbd64-6336-4deb-8736-a411de446b08"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("ac54ca4a-3c1a-4a6e-86fe-9db85c471692"), Traits.Instances.Necromancy.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0d3cc2ab-741b-48be-ab60-5a50b214c3a4"),
                SourceId = Sources.Instances.GrandBazaar.ID,
                Page = 10
            };
        }
    }
}
