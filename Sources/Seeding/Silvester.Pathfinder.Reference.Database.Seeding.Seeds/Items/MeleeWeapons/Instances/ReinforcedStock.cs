using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.MeleeWeapons.Instances
{
    public class ReinforcedStock : Template
    {
        public static readonly Guid ID = Guid.Parse("5bcc4bf9-bc33-40bc-8bdf-846cee787084");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Reinforced Stock",
				WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
				WeaponGroupId = WeaponGroups.Instances.Club.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("e4cbd236-1158-4327-9810-36861142e2e2"),
				Name = "Reinforced Stock",
				Price = 20,
				Hands = "1 or 2.",
				Damage = "1d4",
				DamageTypeId = DamageTypes.Instances.Bludgeoning.ID,
				BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("15d3b2c6-5b9d-46dc-b157-bde4bff39c83"), "A reinforced stock is a weighted crossbow, firearm haft, or grip customized for striking in melee.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("0f7d4d7b-bd8b-417f-aabc-98b59726c0b1"), Traits.Instances.Attached.ID);
            builder.Add(Guid.Parse("e5cdfbf5-c4db-401c-a422-8382783d85a1"), Traits.Instances.Finesse.ID);
            builder.Add(Guid.Parse("13906a5c-4063-484e-b0b1-295ead743aaf"), Traits.Instances.TwoHand.ID); //TODO: d6
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c7a412a0-284f-472c-8f90-4986bd904faf"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 150
            };
        }
    }
}
