using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.WeaponPropertyRunes.Instances
{
    public class GhostTouch : Template
    {
        public static readonly Guid ID = Guid.Parse("1080858f-20b5-4b69-a1d0-138f7230aba8");

        protected override WeaponPropertyRune GetWeaponPropertyRune()
        {
            return new WeaponPropertyRune
            {
                Id = ID,
                Name = "Ghost Touch",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("d34d732c-49ed-4cbb-be44-d340acfb9302"), "The weapon can harm creatures without physical form. A ghost touch weapon is particularly effective against incorporeal creatures, which almost always have a specific vulnerability to ghost touch weapons. Incorporeal creatures can touch, hold, and wield ghost touch weapons (unlike most physical objects).");
        }

        protected override IEnumerable<WeaponPropertyRuneVariant> GetWeaponPropertyRuneVariants()
        {
            yield return new WeaponPropertyRuneVariant
            {
                Id = Guid.Parse("f7b83dda-01b3-4baf-b4df-ec8e2ea0bdc0"),
                Name = "Ghost Touch",
                Usage = "Etched onto a melee weapon.",
                Price = 7500,
                Level = 4,
                PotencyId = Potencies.Instances.Standard.ID,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("5153d658-bd0a-4ae9-9102-0eb06aab363f"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("3754bf52-15ea-4e9f-ab4c-d602b8e57c1c"), Traits.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("415b4896-96d5-4f3a-930c-5951809fa3ca"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 584
            };
        }
    }
}
