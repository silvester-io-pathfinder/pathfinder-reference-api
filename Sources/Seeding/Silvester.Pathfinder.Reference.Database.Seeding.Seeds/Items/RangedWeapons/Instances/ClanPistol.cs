using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.RangedWeapons.Instances
{
    public class ClanPistol : Template
    {
        public static readonly Guid ID = Guid.Parse("4ec8d977-d324-49a8-b69c-af8b263eaeb1");

        protected override RangedWeapon GetRangedWeapon()
        {
            return new RangedWeapon
            {
                Id = ID,
                Name = "Clan Pistol",
                WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
                WeaponGroupId = WeaponGroups.Instances.Firearm.ID,
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("6d15a106-cbc9-413e-81cf-555f6c2f06ba"), "The tradition of dwarves displaying their clan affiliations with special clan daggers goes back millennia, but many of the dwarf clans of Dongun Hold have their own take on the tradition, with promising young gunsmiths claiming their adulthood by crafting a specialized personal firearm using the clan's unique smithing traditions. Losing or being forced to surrender their clan pistol is a terrible embarrassment for the dwarves that carry them.");;
        }

        protected override IEnumerable<RangedWeaponVariant> GetRangedWeaponVariants()
		{
            yield return new RangedWeaponVariant
            {
                Id = Guid.Parse("d89381fe-7fef-4a06-9387-7ef4e86217da"),
                Name = "Clan Pistol",
                Hands = "1",
                Price = 500,
                Reload = 1,
                Range = 80,
                Damage = "1d6",
                DamageTypeId = DamageTypes.Instances.Piercing.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                BulkId = Bulks.Instances.LightBulk.ID,
            };
        }

		protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("9db5ba2c-c161-4414-9dbd-e8faf5027ee5"), Traits.Instances.Concussive.ID);
            builder.Add(Guid.Parse("7939f232-a921-4abf-8ed5-a35f48f40a21"), Traits.Instances.Dwarf.ID);
            builder.Add(Guid.Parse("3328bd06-5e95-401a-b6d6-b718f93efc30"), Traits.Instances.Fatal.ID, "d10");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("65a3348f-fd8e-41f2-817d-e6b65e6c207a"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 151
            };
        }
    }
}
