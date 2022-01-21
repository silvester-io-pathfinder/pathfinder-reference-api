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
    public class TenguGaleBlade : Template
    {
        public static readonly Guid ID = Guid.Parse("14ab5e55-3b4a-445c-b2e0-9f938b9a4895");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Tengu Gale Blade",
				WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
				WeaponGroupId = WeaponGroups.Instances.Sword.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("33bbfe2f-2ccd-446d-8b13-19d04fb968a4"),
				Name = "Tengu Gale Blade",
				Price = 400,
				Hands = "1",
				Damage = "1d6",
				DamageTypeId = DamageTypes.Instances.Slashing.ID,
				BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("1be8c32a-4489-420c-9c79-7a489123903a"), "This fan-shaped sword, designed by members of the tengu ancestry, has five broad blades that join at its hilt. Tengu sailors also use gale blades as makeshift weather vanes, as the sword spins to show the wind's direction when loosely held aloft.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("4668dff7-e165-45b2-83db-e5985ee1cd6d"), Traits.Instances.Agile.ID);
            builder.Add(Guid.Parse("7894c528-8bce-4fbf-be4a-df9a78b3de7f"), Traits.Instances.Disarm.ID);
            builder.Add(Guid.Parse("e8cce5dc-9454-437e-adf8-816a779fc22d"), Traits.Instances.Finesse.ID);
            builder.Add(Guid.Parse("88e82902-1a67-46c9-9aa3-01e89e24cb2f"), Traits.Instances.Tengu.ID);
            builder.Add(Guid.Parse("a6e76d2e-3f84-4578-9de3-11d99daf15e4"), Traits.Instances.Uncommon.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b47a76b0-18f2-42da-af53-9200251c89b1"),
                SourceId = AdvancedPlayersGuide.ID,
                Page = 248
            };
        }
    }
}
