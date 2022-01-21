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
    public class Bloodthirsty : Template
    {
        public static readonly Guid ID = Guid.Parse("6c1464cc-24d1-4e28-99f0-81647b761a64");

        protected override WeaponPropertyRune GetWeaponPropertyRune()
        {
            return new WeaponPropertyRune
            {
                Id = ID,
                Name = "Bloodthirsty",
            };
        }

        protected override IEnumerable<WeaponPropertyRuneVariant> GetWeaponPropertyRuneVariants()
        {
            yield return new WeaponPropertyRuneVariant
            {
                Id = Guid.Parse("c46a7758-2d0c-4acd-afa1-7d6413f645ca"),
                Name = "Bloodthirsty",
                Usage = "Etched onto a slashing or piercing melee weapon.",
                Level = 16,
                Price = 850000,
                PotencyId = Potencies.Instances.Standard.ID,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("bcfb9751-cc20-4158-b6e9-2782df0b1f98"), "The magic in this rune sings in time with your attacks and coaxes you into finishing your opponent. When you critically hit a target that's taking persistent bleed damage, your target becomes drained 1.")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("3dd96f30-0621-4861-8975-0b650f5f40b5"), ActionTypes.Instances.Reaction.ID, "Activate", action => 
                    {
                        action
                            .Kind("Envision")
                            .Trigger("You reduce a creature to 0 Hit Points with the weapon.")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("2ab621e7-a1df-4834-bd22-c07e9535e395"), "You gain a number of temporary Hit Points equal to twice the creature's level. These Hit Points remain for 1 minute.");
                            });
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("459be614-696e-4cf6-8146-70e42017b5d4"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("47ff4759-5efe-4611-aec2-8f11529b4370"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("a54a46f0-2e89-4272-bb5d-97178ac6ea91"), Traits.Instances.Necromancy.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6244f3b4-ae03-4293-8237-33021b0a1f85"),
                SourceId = Sources.Instances.GrandBazaar.ID,
                Page = 42
            };
        }
    }
}
