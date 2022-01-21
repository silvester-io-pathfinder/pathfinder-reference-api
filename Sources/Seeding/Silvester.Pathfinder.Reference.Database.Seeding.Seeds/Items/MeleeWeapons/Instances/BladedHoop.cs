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
    public class BladedHoop : Template
    {
        public static readonly Guid ID = Guid.Parse("c7facb69-2744-4cec-b9b6-28fab446d5e8");

        protected override MeleeWeapon GetMeleeWeapon()
		{
			return new MeleeWeapon
			{
				Id = ID,
				Name = "Bladed Hoop",
				WeaponCategoryId = WeaponCategories.Instances.Advanced.ID,
				WeaponGroupId = WeaponGroups.Instances.Knife.ID,
			};
		}

		protected override IEnumerable<MeleeWeaponVariant> GetMeleeWeaponVariants()
		{
			yield return new MeleeWeaponVariant
			{
				Id = Guid.Parse("2f258c63-5a27-4b39-8f5e-b52dfea44909"),
				Name = "Bladed Hoop",
				Price = 250,
				Hands = "0+",
				Damage = "1d6",
				DamageTypeId = DamageTypes.Instances.Slashing.ID,
				BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("9d4a04c3-e42e-4fd2-bbf4-2ccfd3069414"), "This circular hoop has blades along its outer edge. You can wield it in two hands (using the two-hand damage) or by spinning it around an arm. While you spin the hoop, it gains the free-hand trait. Setting the hoop spinning takes 1 Interact action. In addition to the normal restrictions of the free-hand trait, extended use of the arm for locomotion (such as to Climb) interferes with the hoop's spinning and forces you to Release the hoop. You can't spin a hoop underwater. Keeping the hoop spinning requires a free action each round, which has the concentrate and manipulate traits. You can keep a hoop spinning as an exploration activity, but doing so for more than 10 minutes makes you fatigued, similarly to Hustling.")
					.Build()
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("0a6e1ada-879a-49fb-8025-95be68a84cfd"), Traits.Instances.Finesse.ID);
            builder.Add(Guid.Parse("d7d0ade5-5e38-4949-aabe-4cc223ad06cf"), Traits.Instances.Sweep.ID);
            builder.Add(Guid.Parse("a255264c-d901-4769-b308-f369470a3eeb"), Traits.Instances.TwoHand.ID);
            builder.Add(Guid.Parse("d1967bc7-aa1c-4799-acc4-d10bcf593020"), Traits.Instances.Uncommon.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9cc2bac0-af81-4e13-8b7a-98d1cc5d7f48"),
                SourceId = Pathfinder151.ID,
                Page = 77
            };
        }
    }
}
