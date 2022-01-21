using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.RangedWeapons.Instances
{
    public class PactBoundPistol : Template
    {
        public static readonly Guid ID = Guid.Parse("321d58ff-a8d7-45d7-9a05-47f361587625");

        protected override RangedWeapon GetRangedWeapon()
        {
            return new RangedWeapon
            {
                Id = ID,
                Name = "Pact-Bound Pistol",
                WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
                WeaponGroupId = WeaponGroups.Instances.Firearm.ID,
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("342b3f1b-50b8-449f-bf60-a6fea36037b5"), "Wielded in over a hundred duels by the famed Ustalavic noblewoman Countess Tasya Iserav, this +1 striking fearsome dueling pistol (Advanced Player's Guide 260) is a work of master craftsmanship, almost eerie in the axiomatic perfection present in each dimension and detail.");;
            builder.Text(Guid.Parse("cfce7245-ad65-48ee-8105-2f89e59a07d4"), "Commissioned at great expense and artfully designed by a team of the finest gunsmiths, this exquisite mahogany pistol has adamantine detailing. The ruby-eyed, leering devil's face that surrounds the barrel was intended to strike fear into the Countess's opponents-of which there were many. Countess Tasya credited this weapon with her exceptional success in dueling circles and refused to name the weapon's creators for fear their works would fall into an opponent's hands. In the past decade, seven replicas of the Countess's famed pistol have arisen, each said to be crafted by the Countess's anonymous gunsmiths. That each of these weapon's wielders have quickly risen to become exceptional duelists in their own right has lent credence to their claims. Despite public pressure, wielders of these replicas have refused to square off against the Countess.");;
            builder.Text(Guid.Parse("ba06f91a-a691-4c39-93e9-df1e09c855d6"), "Despite the weapon's beauty and utility, a pact-bound pistol is a cursed weapon and a physical manifestation of an infernal contract sworn between the bearer of the weapon and the Archdevil Mephistopheles. Each pact-bound pistol was crafted not by a team of master artisans, but by Countess Tasya Iserav herself, a secret diabolist and devoted priestess of The Crimson Son. The very act of firing the weapon is an acceptance of the contract's terms and causes the weapon to fuse to you. Thereafter, the weapon reappears in your possessions within 1 minute of you discarding it, and can't be destroyed or thrown away permanently, until the curse is removed.");;
            builder.Text(Guid.Parse("a43566cf-6429-4e72-b2b6-8b94b172cf05"), "Whenever you attack a living creature with the pact-bound pistol, text from the infernal contract is seared into your flesh, causing you to lose 1 Hit Point, or 2 Hit Points if the attack was a critical success. The text appears one sentence at a time, from the beginning to the end and is written in Infernal. When the contract is fully scribed (see below), you no longer lose Hit Points when you attack a living creature. These burned phrases heal over as scars which can't be removed while you are fused to the weapon, although they can be covered and disguised.");;
            builder.Text(Guid.Parse("bb9a1287-3fd7-48d7-9db9-169d2b2446d5"), "Each time a creature dies within 1 hour of being damaged by a pact-bound pistol, that creature must attempt a DC 25 Will saving throw. On a failure, their soul is consigned to the Archdevil Mephistopheles; their soul immediately goes to Hell and they can't be returned to life through any means short of divine intervention, a heist, or a successful appeal in the courts of Hell; even powerful magic such as wish is insufficient. After you have consigned 9 souls to Mephistopheles in this way, the contract is fully scribed upon your flesh. You become immune to fire damage and the pact-bound pistol becomes a +2 striking greater fearsome dueling pistol. Your soul belongs to Mephistopheles and immediately goes to Hell when you die. You can't be returned to life through any means, even through the divine intervention of a deity.");;
            builder.Text(Guid.Parse("4cb5fefc-183b-4bb9-b6c7-198ea90b5da4"), "Failing to wield a pact-bound pistol is a breach of contract. Each day you go without firing the pact-bound pistol at a living creature, you must attempt a Will saving throw. On a failure, you become stupefied 1. If you are already stupefied, the value of your stupefied condition increases by 1, to a maximum of stupefied 4. While you're fused with the pact-bound pistol, you can't reduce the value of your stupefied condition except by damaging a living creature with it. Whenever you damage a living creature with it, if you are suffering from the stupefied condition due to the pact-bound pistol, your stupefied condition is removed.");;
        }

        protected override IEnumerable<RangedWeaponVariant> GetRangedWeaponVariants()
		{
			yield return new RangedWeaponVariant
			{
				Id = Guid.Parse("dcc7d986-4105-4ef3-8ac3-e235f28ba78b"),
				Name = "Pact-Bound Pistol",
				Hands = "1",
				Price = 120000,
				Reload = 1,
				Range = 1,
				Damage = "2d6",
				DamageTypeId = DamageTypes.Instances.Piercing.ID,
				RarityId = Rarities.Instances.Rare.ID,
				BulkId = Bulks.Instances.LightBulk.ID,
			};
		}

		protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("87723ddb-b940-43ad-9452-6eff529d50bc"), Traits.Instances.Cursed.ID);
            builder.Add(Guid.Parse("f3598361-113b-4fcf-b22f-e86a237d0f3d"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("30dacce4-4c1e-4b6f-96d4-6841a4a47f70"), Traits.Instances.Evil.ID);
            builder.Add(Guid.Parse("2715c126-e0ad-46dc-9b88-f90b1b7e891c"), Traits.Instances.Fire.ID);
            builder.Add(Guid.Parse("398c638a-3733-4cc0-a921-bef6202aa68b"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("9d3633f2-d369-47da-ae1d-a73e9018eb44"), Traits.Instances.Concealable.ID);
            builder.Add(Guid.Parse("5408fa45-eb74-4356-85d9-565a576edae9"), Traits.Instances.Concussive.ID);
            builder.Add(Guid.Parse("4cba2b9c-a5e9-46f3-b6b7-6a13e6e48cf9"), Traits.Instances.Fatal.ID, "d10");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8134bc17-3664-4b04-81e8-36f073f5e9c6"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 161
            };
        }
    }
}
