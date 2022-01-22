using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System;
using System.Collections.Generic;


namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.MagicAmmunitions.Instances
{
    public class SpellstrikeAmmunition : Template
    {
        public static readonly Guid ID = Guid.Parse("806d11ad-5da6-4329-8a1f-492c01af37e5");

        protected override MagicAmmunition GetMagicAmmunition()
        {
            return new MagicAmmunition
            {
                Id = ID,
                Name = "Spellstrike Ammunition",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("ff7820c4-781c-47be-b77f-98d95d284c13"), "Mystic patterns create a magic reservoir within this ammunition. You activate spellstrike ammunition by Casting a Spell into the ammunition. The spell must be of a spell level the ammunition can hold, and the spell must be able to target a creature other than the caster. A creature hit by activated spellstrike ammunition is targeted by the spell. If the creature isn�t a valid target for the spell, the spell is lost.");
            builder.Text(Guid.Parse("6ef0830c-03b1-46bb-a700-56b34b25fa3e"), "The ammunition affects only the target hit, even if the spell would normally affect more than one target. If the spell requires a spell attack roll, use the result of your ranged attack roll with the ammunition to determine the degree of success of the spell. If the spell requires a saving throw, the target attempts the save against your spell DC.");
            builder.Text(Guid.Parse("f3232d67-c592-45c1-97db-baea583534e4"), "The maximum level of spell the ammunition can hold determines its item level and Price.");
        }

        protected override IEnumerable<MagicAmmunitionVariant> GetMagicAmmunitionVariants()
        {
            yield return new MagicAmmunitionVariant
            {
                Id = Guid.Parse("f089f594-db6e-4ea0-add8-d59250b48e72"),
                Name = "Spellstrike Ammunition (Type I)",
                Level = 3,
                Price = 1200,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("eeb36c9a-b936-447c-9f3b-4e25c6511cf3"), "Can hold a maximum spell level of 1.")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("7ee809ff-1725-459d-8f92-261edf4d1533"), ActionTypes.Instances.TwoActions.ID, "Activate", action =>
                    {
                        action.Kind("Cast a Spell");
                    })
                    .Build()
            };

            yield return new MagicAmmunitionVariant
            {
                Id = Guid.Parse("cdd6f0d3-3789-411e-9bf5-6b203cfd9b2e"),
                Name = "Spellstrike Ammunition (Type II)",
                Level = 5,
                Price = 3000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("2080db58-1240-4e7d-8d3c-6eb3af9ec4e1"), "Can hold a maximum spell level of 2.")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("9906884d-bc22-46d8-9ea7-4ef4e5f759ed"), ActionTypes.Instances.TwoActions.ID, "Activate", action =>
                    {
                        action.Kind("Cast a Spell");
                    })
                    .Build()
            };

            yield return new MagicAmmunitionVariant
            {
                Id = Guid.Parse("8ca518c4-a5f4-4440-b53d-d9ed4224efa4"),
                Name = "Spellstrike Ammunition (Type III)",
                Level = 7,
                Price = 7000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("d2aa77eb-9741-4d89-8df1-bb7fe8a41d9b"), "Can hold a maximum spell level of 3.")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("454e0acb-01a8-463c-a63d-8901b95c7edd"), ActionTypes.Instances.TwoActions.ID, "Activate", action =>
                    {
                        action.Kind("Cast a Spell");
                    })
                    .Build()
            };

            yield return new MagicAmmunitionVariant
            {
                Id = Guid.Parse("104cc824-2ff3-4816-bc79-4377b17d2807"),
                Name = "Spellstrike Ammunition (Type IV)",
                Level = 9,
                Price = 15000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("6f418d2b-1009-4e04-a747-067e07bf22f6"), "Can hold a maximum spell level of 4.")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("f4bf9422-1f41-434a-a0e3-699d9f06c9cc"), ActionTypes.Instances.TwoActions.ID, "Activate", action =>
                    {
                        action.Kind("Cast a Spell");
                    })
                    .Build()
            };

            yield return new MagicAmmunitionVariant
            {
                Id = Guid.Parse("e0f17d8f-e394-495d-9a4b-fa488fd3bb26"),
                Name = "Spellstrike Ammunition (Type V)",
                Level = 11,
                Price = 30000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("307a753b-41ac-4760-861d-32ef81605cc4"), "Can hold a maximum spell level of 5.")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("03edcb4e-b613-487a-9a63-c9a94dc06ad6"), ActionTypes.Instances.TwoActions.ID, "Activate", action =>
                    {
                        action.Kind("Cast a Spell");
                    })
                    .Build()
            };

            yield return new MagicAmmunitionVariant
            {
                Id = Guid.Parse("a52964e7-c001-47c9-9878-53eeee083fde"),
                Name = "Spellstrike Ammunition (Type VI)",
                Level = 13,
                Price = 60000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("0b551ec1-bf94-4b1f-a841-941c9e1ba863"), "Can hold a maximum spell level of 6.")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("9df9f88b-7bd0-4532-80cb-4c388b567bc1"), ActionTypes.Instances.TwoActions.ID, "Activate", action =>
                    {
                        action.Kind("Cast a Spell");
                    })
                    .Build()
            };

            yield return new MagicAmmunitionVariant
            {
                Id = Guid.Parse("be9895e3-5822-4baa-9db4-41ac717114fa"),
                Name = "Spellstrike Ammunition (Type VII)",
                Level = 15,
                Price = 130000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("6e9886bd-49fe-40b5-8696-3224f3fe4a97"), "Can hold a maximum spell level of 7.")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("5a8e0c7e-5e32-4743-a9a8-4f32c694f42d"), ActionTypes.Instances.TwoActions.ID, "Activate", action =>
                    {
                        action.Kind("Cast a Spell");
                    })
                    .Build()
            };

            yield return new MagicAmmunitionVariant
            {
                Id = Guid.Parse("f791ec33-8773-42a2-95d3-cbeb7ce3f8b3"),
                Name = "Spellstrike Ammunition (Type VIII)",
                Level = 17,
                Price = 300000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("34fac62a-a311-4d69-ae9c-87e94df2dc60"), "Can hold a maximum spell level of 8.")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("584e8367-b4bf-443f-b216-d6c710d48f6b"), ActionTypes.Instances.TwoActions.ID, "Activate", action =>
                    {
                        action.Kind("Cast a Spell");
                    })
                    .Build()
            };

            yield return new MagicAmmunitionVariant
            {
                Id = Guid.Parse("69caa2d5-d26e-477d-9d9e-9027fbdd0141"),
                Name = "Spellstrike Ammunition (Type IX)",
                Level = 19,
                Price = 800000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("4d66e426-c682-4db8-871e-7e1afd6a281a"), "Can hold a maximum spell level of 9.")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("d491f88b-01dd-4e51-9ffa-72a9a9128195"), ActionTypes.Instances.TwoActions.ID, "Activate", action =>
                    {
                        action.Kind("Cast a Spell");
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("16886925-b32f-4289-a352-15122d68d5a7"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("cc5c4c34-de84-4790-998d-339a70d6d65c"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("fc7ec11e-babf-4e24-8348-4f537f9a7a33"), Traits.Instances.Transmutation.ID);
        }

        protected override IEnumerable<Guid> GetCraftableAs()
        {
            yield break;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4ad4090b-98d9-4d91-808a-e43f454680fc"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 560
            };
        }
    }
}
