using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.BeastGuns.Instances
{
    public class SpiderGun : Template
    {
        public static readonly Guid ID = Guid.Parse("fac5c3ba-7c02-40e1-8014-aaba62842c23");

        public static readonly Guid STANDARD_ID = Guid.Parse("a53d1b63-651d-498b-8b1a-cb2a0d053a52");
        public static readonly Guid GREATER_ID = Guid.Parse("b6690d74-54b7-453c-8bfe-f7eba92176dc");
        public static readonly Guid MAJOR_ID = Guid.Parse("156a310c-4d7f-4b52-8e9f-f78b0425ed7d");

        protected override BeastGun GetBeastGun()
        {
            return new BeastGun
            {
                Id = ID,
                Name = "Spider Gun",
                WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
                WeaponGroupId = WeaponGroups.Instances.Firearm.ID
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("d6a0c43e-9898-4ba6-81fc-f963f6f1ba36"), "A spider gun is a +1 striking weapon. It's a distinct type of martial firearm made from the fangs and spinneret of a Large spider. It deals 1d10 poison damage with a range increment of 30 feet and reload 1. On a critical hit, the venom clings to the target and they take persistent poison damage equal to 1d4 + the number of weapon damage dice. A spider gun does not add critical specialization effects. The gun can be activated to fire webbing that hampers other creatures.");
        }

        protected override IEnumerable<BeastGunVariant> GetBeastGunVariants()
        {
            yield return new BeastGunVariant
            {
                Id = STANDARD_ID,
                Name = "Spider Gun",
                CraftingRequirements = "The initial raw materials for the spider gun must include the fangs and spinneret of a giant spider or other Large spider.",
                Level = 6,
                Price = 25000,
                Hands = "2",
                Range = 30,
                Reload = 1,
                Damage = "2d10",
                DamageTypeId = DamageTypes.Instances.Poison.ID,
                PotencyId = Potencies.Instances.Standard.ID,
                BulkId = Bulks.Instances.TwoBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("f7d174d6-52b5-40ba-aa98-b443699984c1"), "It's a +1 striking weapon.")
					.Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("22abfce0-5793-4cf0-ad14-15b43a73459a"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Frequency("Once per round.")
                            .Traits(traits => 
                            {
                                traits.Add(Guid.Parse("ea965e8c-9d9c-4063-af70-f31a5a1ae3c5"), Traits.Instances.Conjuration.ID);
                                traits.Add(Guid.Parse("3fb2ad44-5db5-48e9-896c-258ae239aebe"), Traits.Instances.Magical.ID); 
                            })
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("6ddb604b-f762-4811-aef1-961c302023c2"), "You fire a mass of webbing at a square within 30 feet. That square becomes covered in webbing for 1 minute. A square covered with the webbing from a spider gun can be cleared by a single attack or effect that deals at least 5 slashing damage or 1 fire damage. A square has AC 5, and it automatically fails its saving throws. The first time each turn a creature in the webbing begins to use a move action or enters the webbing during a move action, it must attempt an Athletics check or Reflex save against DC 20. On a success, it moves normally through the webbing and clears away the webbing from any squares it enters this turn. On a failure, it treats squares of webbing as difficult terrain this turn, and on a critical failure, it's immobilized for 1 round or until it Escapes (DC 20) or destroys the webbing.");
                            });
                    })
                    .Build()
            };

            yield return new BeastGunVariant
            {
                Id = GREATER_ID,
                Name = "Spider Gun (Greater)",
                CraftingRequirements = "The initial raw materials for the spider gun must include the fangs and spinneret of a giant spider or other Large spider.",
                Level = 9,
                Price = 140000,
                Hands = "2",
                Range = 30,
                Reload = 1,
                Damage = "2d10",
                DamageTypeId = DamageTypes.Instances.Poison.ID,
                PotencyId = Potencies.Instances.Greater.ID,
                BulkId = Bulks.Instances.TwoBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("cc3749b9-5efd-43ba-b1f3-12859c1d28b9"), "The gun's webbing requires at least 15 slashing damage or 5 fire damage to clear away and the DC is 25.")
					.Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("55ca2890-ead9-45d6-95c8-924ca8b2170f"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Frequency("Once per round.")
                            .Traits(traits =>
                            {
                                traits.Add(Guid.Parse("1c559103-eefd-41bb-adbe-16eca9d44285"), Traits.Instances.Conjuration.ID);
                                traits.Add(Guid.Parse("34966979-d090-4759-87b5-ce5a8b775c7f"), Traits.Instances.Magical.ID);
                            })
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("ed0954f3-671d-4ae3-9e1b-9f3698e8aa80"), "You fire a mass of webbing at a square within 30 feet. That square becomes covered in webbing for 1 minute. A square covered with the webbing from a spider gun can be cleared by a single attack or effect that deals at least 15 slashing damage or 5 fire damage. A square has AC 5, and it automatically fails its saving throws. The first time each turn a creature in the webbing begins to use a move action or enters the webbing during a move action, it must attempt an Athletics check or Reflex save against DC 20. On a success, it moves normally through the webbing and clears away the webbing from any squares it enters this turn. On a failure, it treats squares of webbing as difficult terrain this turn, and on a critical failure, it's immobilized for 1 round or until it Escapes (DC 25) or destroys the webbing.");
                            });
                    })
                    .Build()
            };

            yield return new BeastGunVariant
            {
                Id = MAJOR_ID,
                Name = "Spider Gun (Major)",
                CraftingRequirements = "The initial raw materials for the spider gun must include the fangs and spinneret of a giant spider or other Large spider.",
                Level = 15,
                Price = 650000,
                Hands = "2",
                Range = 30,
                Reload = 1,
                Damage = "3d10",
                DamageTypeId = DamageTypes.Instances.Poison.ID,
                PotencyId = Potencies.Instances.Major.ID,
                BulkId = Bulks.Instances.TwoBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("0aa1d893-09ca-4cee-b633-a578e19865a4"), "A major spider gun is a +2 greater striking weapon. The gun's webbing requires at least 25 slashing damage or 15 fire damage to clear away and the DC is 34.")
					.Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("e917c0ef-abdf-46f7-9458-92a38c151870"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Frequency("Once per round.")
                            .Traits(traits =>
                            {
                                traits.Add(Guid.Parse("13190845-f631-45dc-a133-14b2f352f522"), Traits.Instances.Conjuration.ID);
                                traits.Add(Guid.Parse("9cb1f756-78d1-43c6-8522-d9a4a478599a"), Traits.Instances.Magical.ID);
                            })
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("30a26e5b-2bab-4807-acd0-01032f4e441a"), "You fire a mass of webbing at a square within 30 feet. That square becomes covered in webbing for 1 minute. A square covered with the webbing from a spider gun can be cleared by a single attack or effect that deals at least 25 slashing damage or 15 fire damage. A square has AC 5, and it automatically fails its saving throws. The first time each turn a creature in the webbing begins to use a move action or enters the webbing during a move action, it must attempt an Athletics check or Reflex save against DC 20. On a success, it moves normally through the webbing and clears away the webbing from any squares it enters this turn. On a failure, it treats squares of webbing as difficult terrain this turn, and on a critical failure, it's immobilized for 1 round or until it Escapes (DC 34) or destroys the webbing.");
                            });
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("f1f35eb4-678b-4d44-bb91-fef6677d7668"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("7bf93ad6-4cf9-426a-8c3b-4b73aa1ef2ab"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("7483dfe4-f19f-4e37-84c4-526c705fda56"), Traits.Instances.Magical.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5304f595-caab-4fda-9b0a-0b440e309606"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 155
            };
        }
    }
}
