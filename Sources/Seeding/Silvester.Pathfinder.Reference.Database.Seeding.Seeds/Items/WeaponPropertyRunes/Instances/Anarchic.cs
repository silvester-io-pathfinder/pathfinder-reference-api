using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.WeaponPropertyRunes.Instances
{
    public class Anarchic : Template
    {
        public static readonly Guid ID = Guid.Parse("74492dda-e75d-4927-9e82-4fe95e9ca396");

        protected override WeaponPropertyRune GetWeaponPropertyRune()
        {
            return new WeaponPropertyRune
            {
                Id = ID,
                Name = "Anarchic",
            };
        }

        protected override IEnumerable<WeaponPropertyRuneVariant> GetWeaponPropertyRuneVariants()
        {
            yield return new WeaponPropertyRuneVariant
            {
                Id = Guid.Parse("f860a640-0e15-4a5c-afab-6d6db3a08f79"),
                Name = "Anarchic",
                Usage = "Etched onto a weapon without an axiomatic rune.",
                CraftingRequirements = "You are chaotic.",
                Level = 11,
                Price = 140000,
                RarityId = Rarities.Instances.Common.ID,
                PotencyId = Potencies.Instances.Standard.ID,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
				Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("8f72b0cc-7525-4564-9df2-b6a023da280a"), "An anarchic rune is jagged and asymmetrical, channeling chaotic energy. A weapon with this rune deals an additional 1d6 chaotic damage against lawful targets. If you are lawful, you are enfeebled 2 while carrying or wielding this weapon.")
                    .Text(Guid.Parse("eb05e944-f51c-4cc7-89c0-5f832b21620b"), "When you critically succeed at a Strike with this weapon against a lawful creature, roll 1d6. On a 1 or 2, you deal double minimum damage; on a 3 or 4, double your damage normally; on a 5 or 6, you deal double maximum damage.")
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("e5eb051a-9439-441f-8bde-77d4d4db6ffd"), Traits.Instances.Chaotic.ID);
            builder.Add(Guid.Parse("bcd379c8-f5bb-4a2c-ae60-71d130897cef"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("976a2b4d-98ae-4eb3-b644-6e3a27942ebf"), Traits.Instances.Magical.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a0b8eb1f-9079-4686-9aca-5b2047cd28fd"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 583
            };
        }
    }
}
