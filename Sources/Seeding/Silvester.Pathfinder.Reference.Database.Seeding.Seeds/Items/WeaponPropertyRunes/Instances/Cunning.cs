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
    public class Cunning : Template
    {
        public static readonly Guid ID = Guid.Parse("bab86729-ac81-4292-bf39-e86a51c24fcf");

        protected override WeaponPropertyRune GetWeaponPropertyRune()
        {
            return new WeaponPropertyRune
            {
                Id = ID,
                Name = "Cunning",
            };
        }

        protected override void GetInlineActions(IInlineActionCollectionBuilder builder)
        {
            builder.Add(Guid.Parse("752ce6e0-d83f-47f5-b05a-29ed9a6bff51"), ActionTypes.Instances.FreeAction.ID, "Activate", action =>
            {
                action
                    .Kind("Envision")
                    .Frequency("Once per minute.")
                    .Requirements("On your previous action this turn, you used this weapon to hit and damage a creature that has blood or other vital fluids.")
                    .Details(effect =>
                    {
                        effect.Text(Guid.Parse("5950c894-55ee-4a46-a454-adadb0a1151b"), "You learn the secrets the weapon gleaned from the creature's blood. Attempt to Recall Knowledge about the target of the required attack, gaining an item bonus to the Recall Knowledge skill check equal to the weapon's item bonus to attack rolls from its potency rune. If the required attack was a critical hit, you also gain a +2 circumstance bonus to this check.");
                    });
            });
        }

        protected override IEnumerable<WeaponPropertyRuneVariant> GetWeaponPropertyRuneVariants()
        {
            yield return new WeaponPropertyRuneVariant
            {
                Id = Guid.Parse("1e2e2357-47c3-4f71-9491-5aab77b26b6a"),
                Name = "Cunning",
                Usage = "Etched on a slashing or piercing weapon.",
                Price = 14000,
                Level = 5,
                PotencyId = Potencies.Instances.Standard.ID,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
				Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("fe507108-08ea-4fa8-9696-d9bbcde9f30d"), "The weapon performs divination magic on the blood of your foes, granting you insight into their abilities and weaknesses.")
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("4e1344de-f289-42d7-ac77-550d80aef8cd"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("59098d68-cc78-4932-bd4b-bddc7a08b3ad"), Traits.Instances.Divination.ID);
            builder.Add(Guid.Parse("5148d4b4-f118-4aec-ac68-cf82630fcde9"), Traits.Instances.Magical.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fd320d9a-e42e-4185-87b5-d32e6de99bee"),
                SourceId = Sources.Instances.PathfinderSocietyGuide.ID,
                Page = 123
            };
        }
    }
}
