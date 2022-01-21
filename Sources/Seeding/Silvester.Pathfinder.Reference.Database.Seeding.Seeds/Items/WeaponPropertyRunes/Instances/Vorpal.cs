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
    public class Vorpal : Template
    {
        public static readonly Guid ID = Guid.Parse("7f7dc195-f152-4e36-a6d3-db63888e3c58");

        protected override WeaponPropertyRune GetWeaponPropertyRune()
        {
            return new WeaponPropertyRune
            {
                Id = ID,
                Name = "Vorpal",
            };
        }

        protected override IEnumerable<WeaponPropertyRuneVariant> GetWeaponPropertyRuneVariants()
        {
            yield return new WeaponPropertyRuneVariant
            {
                Id = Guid.Parse("fc4fd64f-3b91-43be-bc8a-f4d8c2c1f172"),
                Name = "Vorpal",
                Usage = "Etched onto a slashing melee weapon.",
                Level = 17,
                Price = 1500000,
                PotencyId = Potencies.Instances.Standard.ID,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Rare.ID,
				Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("dbba7b53-ed42-4314-8b51-eb91c19ac5c0"), "Originally created as a means of slaying the legendary jabberwock, vorpal weapons prove equally effective against nearly any foe with a head.")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder() 
                    .Add(Guid.Parse("60123526-a8c9-4fbb-a825-2f56b712a385"), ActionTypes.Instances.Reaction.ID, "Activate", action => 
                    {
                        action
                            .Kind("Envision")
                            .Trigger("You roll a natural 20 on a Strike with the weapon, critically succeed, and deal slashing damage. The target must have a head.")
                            .Traits(traits =>
                            {
                                traits.Add(Guid.Parse("dbab1e80-03e3-48cb-8155-9e463929122c"), Traits.Instances.Death.ID);
                                traits.Add(Guid.Parse("09128f10-24ca-4e45-8227-8a523fc88f7a"), Traits.Instances.Incapacitation.ID);
                            })
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("ef7923e2-57d1-428f-8e05-2addccfbff54"), "The target must succeed at a DC 37 Fortitude save or be decapitated. This kills any creature except ones that don't require a head to live. For creatures with multiple heads, this usually kills the creature only if you sever its last head.");
                            });
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("1fbb60bd-f400-46e2-9863-347773e65c54"), Traits.Instances.Rare.ID);
            builder.Add(Guid.Parse("f616235e-2292-4021-a626-a8acd8182cdc"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("2d68563f-986c-4ab5-ab70-66e9159c3ae6"), Traits.Instances.Magical.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f5bd23f4-a281-4761-a73d-28f6ec9a8d42"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 585
            };
        }
    }
}
