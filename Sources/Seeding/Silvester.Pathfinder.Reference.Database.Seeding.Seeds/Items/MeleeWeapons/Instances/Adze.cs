using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Bulks.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DamageTypes.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponCategories.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponGroups.Instances;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.MeleeWeapons.Instances
{
    public class Adze : Template
    {
        public static readonly Guid ID = Guid.Parse("7cd52d10-6bde-4be4-9435-2ab4d65f5390");

        protected override MeleeWeapon GetMeleeWeapon()
        {
            return new MeleeWeapon
            {
                Id = ID,
                Name = "Adze",  
                WeaponCategoryId = Martial.ID,
                WeaponGroupId = Axe.ID,
            };
        }

        protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
        {
            yield return new MeleeWeaponVariant
            {
                Id = Guid.Parse("faaf87f3-28c6-4d24-8120-318f70bc5e09"),
                Name = "Adze",
                Price = 100,
                Hands = "2",
                Damage = "1d10",
                DamageTypeId = DamageTypes.Instances.Slashing.ID,
                BulkId = Bulks.Instances.TwoBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("8d41cd66-4ec1-4fbd-9127-4d49252e8996"), "A common cutting tool, an adze resembles an axe—but the cutting edge is horizontal, rather than vertical. The adze's shape makes it popular among wood workers, and grippli builders often use them to construct their treetop homes. The tool also serves as an effective weapon, due in part to the immense strength required to swing it.")
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("44bae141-30aa-4bf7-9122-b83675e76289"), Traits.Instances.Forceful.ID);
            builder.Add(Guid.Parse("87750791-0cd1-4611-8b81-a7b53a2111f5"), Traits.Instances.Grippli.ID);
            builder.Add(Guid.Parse("fb187fb6-caef-4b69-8280-7a542acc3d3c"), Traits.Instances.Sweep.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fdc045a1-6bbd-4305-95a7-dfbab443580c"),
                SourceId = AncestryGuide.ID,
                Page = 138
            };
        }
    }
}
