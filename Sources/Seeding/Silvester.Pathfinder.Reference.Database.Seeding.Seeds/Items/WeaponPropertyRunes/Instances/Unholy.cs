using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.WeaponPropertyRunes.Instances
{
    public class Unholy : Template
    {
        public static readonly Guid ID = Guid.Parse("97c626c9-64b6-4b0b-ac3b-c362d7d661c3");

        protected override WeaponPropertyRune GetWeaponPropertyRune()
        {
            return new WeaponPropertyRune
            {
                Id = ID,
                Name = "Unholy",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("90cf636b-4210-4594-8b28-5d5214fc3e8b"), "An unholy rune instills fiendish power into the etched weapon.");
        }

        protected override IEnumerable<WeaponPropertyRuneVariant> GetWeaponPropertyRuneVariants()
        {
            yield return new WeaponPropertyRuneVariant
            {
                Id = Guid.Parse("d86da8fd-78d2-420d-a04e-304c93154c7b"),
                Name = "Unholy",
                Usage = "Etched onto a weapon without a holy rune.",
                Level = 11,
                Price = 140000,
                PotencyId = Potencies.Instances.Standard.ID,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
				Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("957ce6ff-ee9e-43b2-bd73-0d65204bf7d8"), "A weapon with this rune deals an additional 1d6 evil damage when it hits a good target. If you are good, you are enfeebled 2 while carrying or wielding this weapon.")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("1a5b88e7-0abd-489f-91b9-b6e97a30c2fd"), ActionTypes.Instances.Reaction.ID, "Activate", action => 
                    {
                        action
                            .Kind("Command")
                            .Frequency("Once per day.")
                            .Trigger("You critically succeed at an attack roll against a good creature with the weapon.")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("271a7de2-d4d9-4be9-be52-e0ecfa05b83d"), "The target takes persistent bleed damage equal to 1d8 per weapon damage die of the etched weapon.");
                            });
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("ca33911d-e580-4b09-a43c-2a96c03403a4"), Traits.Instances.Evil.ID);
            builder.Add(Guid.Parse("2cfefd9c-bb53-4a13-ae1e-6e2332fd3745"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("30c9d120-fef5-421f-8d2e-867b9655e40f"), Traits.Instances.Magical.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c3c98b15-fdac-4f6c-982a-c904d7964247"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 585
            };
        }
    }
}
