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
    public class ArborealsRevenge : Template
    {
        public static readonly Guid ID = Guid.Parse("120c5dd7-cbd4-4123-8c2b-11a53e41f603");

        protected override RangedWeapon GetRangedWeapon()
        {
            return new RangedWeapon
            {
                Id = ID,
                Name = "Arboreal's Revenge",
                WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
                WeaponGroupId = WeaponGroups.Instances.Firearm.ID,
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("7e5feb6c-b94b-43f4-ad5d-c7e20f913c5d"), "This walnut and brass +1 striking blunderbuss has a natural look, with wood worn smooth by time, but left knotted and gnarled. The handgrip beneath the flared muzzle is a wellpositioned bulging tree knot, and the long stock looks as if it was grown to fit you. On closer examination, the whorls and rings in the wood resemble eyes.");;
            builder.Text(Guid.Parse("f702304f-601e-4380-b4f0-bfb1101afd37"), "Arboreal's revenge is a haunted firearm constructed with wood hewn from a living arboreal, slaying the arboreal and trapping its spirit in the firearm. Perhaps a patient wielder could one day put the arboreal's spirit to rest, or at least come to terms with it, abating the drawbacks of the weapon while keeping its advantages.");;
            builder.Text(Guid.Parse("7f545b03-4c20-4ee2-ba77-8a42abd38540"), "When you first fire arboreal's revenge, the blunderbuss fuses with you, after which it's almost impossible to remove it from your possession with a remove curse or similar effect, like many cursed items. You gain weakness 5 to fire and the flat check for you to recover from persistent fire damage increases from 15 to 17, or from 10 to 12 if you receive appropriate help.");;
            builder.Text(Guid.Parse("5b527725-88cc-45bb-8419-b1d4ebfd1b03"), "Whenever you wield arboreal's revenge, the arboreal spirit bound to the blunderbuss attempts to overtake you. The wood handgrip sprouts roots which grow around your hand, binding both of your hands to the firearm. You gain a +4 circumstance bonus to your Reflex DC when defending against checks to Disarm you. However, you can't Release your grip on the blunderbuss until you forcibly tear off the roots, though they do allow you to move your hands enough (and only enough) to reload and fire the blunderbuss. Tearing off the roots takes 1 minute.");;
            builder.Text(Guid.Parse("3cb2535d-f3f8-43a1-808a-34a68987e5cd"), "The arboreal haunting the firearm can use the following two effects whenever it wants, often using them at random. You can coax it into performing them each intentionally once per day, with the following activations.");;
        }

        protected override IEnumerable<RangedWeaponVariant> GetRangedWeaponVariants()
		{
			yield return new RangedWeaponVariant
			{
				Id = Guid.Parse("7e61aa03-4c02-4733-8172-772552913207"),
				Name = "Arboreal's Revenge",
				Hands = "2",
				Price = 800,
				Reload = 1,
				Range = 40,
				Damage = "2d8",
				DamageTypeId = DamageTypes.Instances.Piercing.ID,
				RarityId = Rarities.Instances.Rare.ID,
				BulkId = Bulks.Instances.TwoBulk.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("a97a7c85-31a7-4d1c-9fda-40c92962d09b"), ActionTypes.Instances.FreeAction.ID, "Activate", action =>
                    {
                        action
                           .Kind("Command")
                           .Frequency("Once per day.")
                           .Details(effect =>
                           {
                               effect.Text(Guid.Parse("94a0c47e-86a9-4ba1-b0f8-2f1d3f4410ec"), "The arboreal haunting the blunderbuss attempts to regrow itself into a new physical body by sprouting from the bodies of all the creatures that the firearm recently harmed. You and all creatures within 60 feet damaged by arboreal's revenge within the last minute must attempt a DC 20 Fortitude saving throw. On a failure, they take a -10-foot circumstance penalty to their Speeds as roots rapidly sprout from their wounds, which lasts until they Escape (DC 20).");
                           });
                    })
                    .Add(Guid.Parse("a1dd8ba0-18d0-4531-917f-89e6e0ffdf39"), ActionTypes.Instances.TwoActions.ID, "Activate", action =>
                    {
                        action
                           .Kind("Command, Interact")
                           .Frequency("Once per day.")
                           .Details(effect =>
                           {
                               effect.Text(Guid.Parse("d3097d09-dbc7-441e-a63c-0c8beb5f6902"), "You cast barkskin from the blunderbuss as a 2ndlevel primal spell. However, the weakness to fire imposed by barkskin is cumulative with the weakness to fire imposed by this weapon's curse, for a total of weakness 8 to fire.");
                           });
                    })
                    .Build()
            };
		}

		protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("1f4583f3-fe5c-4a89-ab79-be48ce895e9e"), Traits.Instances.Cursed.ID);
            builder.Add(Guid.Parse("70e75f34-f85a-4ae5-b5e1-209ce8778ca0"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("5114427a-863b-4b5c-9de4-9a4867664568"), Traits.Instances.Transmutation.ID);
            builder.Add(Guid.Parse("0fc55713-eff3-42bb-9b9b-8365901084f2"), Traits.Instances.Concealable.ID);
            builder.Add(Guid.Parse("23e36fbc-a4bb-44d7-b126-214257e9c1d7"), Traits.Instances.Scatter.ID, "10 ft."); 
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2a1bec97-f557-47f6-a765-1234618397bb"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 160
            };
        }
    }
}
