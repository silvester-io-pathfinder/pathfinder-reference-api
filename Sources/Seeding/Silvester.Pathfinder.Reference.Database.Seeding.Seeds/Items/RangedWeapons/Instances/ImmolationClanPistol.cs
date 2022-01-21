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
    public class ImmolationClanPistol : Template
    {
        public static readonly Guid ID = Guid.Parse("84d2f182-9cab-4da0-a79a-9c00583c4bdc");

        protected override RangedWeapon GetRangedWeapon()
        {
            return new RangedWeapon
            {
                Id = ID,
                Name = "Immolation Clan Pistol",
                WeaponCategoryId = WeaponCategories.Instances.Martial.ID,
                WeaponGroupId = WeaponGroups.Instances.Firearm.ID,
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("fa7e455e-7ca8-4372-928a-e6c72dc23b1e"), "This charred and blackened +2 striking clan pistol is coated in a thick layer of soot and grease and its retort sounds uncomfortably like a scream. Clearly at dangerous risk of misfire, this weapon claimed the life of its dwarven crafter shortly after completion and is haunted by that pained spirit. This ever-burning spirit keeps the firearm warm to the touch, regardless of surrounding environment.");;
            builder.Text(Guid.Parse("0be6b702-fbc9-451e-901b-56ddc5cacdb3"), "No matter how much you clean and maintain it, an immolation clan pistol is always at risk of a misfire, and the flat check to avoid a misfire is DC 7 rather than DC 5. On a misfire, an immolation hand cannon releases a blast of concentrated fire, dealing you 2d6 fire damage and 2d6 persistent fire damage.");;
            builder.Text(Guid.Parse("3cdb6425-2299-4ed4-bbe4-471340afd2b6"), "An immolation clan pistol fuses with you when you first fire it. While you�re fused with the immolation clan pistol, the pained spirit haunts your dreams, forcing you to relive its death each night. If you fired the immolation clan pistol that day, you are unharmed by these dreams. If you didn�t fire the immolation clan pistol that day, but still possess it, you awaken fatigued. If you no longer possess the immolation clan pistol, the spirit of its dwarven smith is enraged by your neglect; you awaken fatigued and aflame, taking 2d6 persistent fire damage.");;
            builder.Text(Guid.Parse("08a10cfb-1679-47b8-851c-f731a2915277"), "Regardless, these nightmares possess clues to the spirit�s life. If you take the immolation hand cannon to the site of its creation and repair it with tools belonging to the tormented spirit, you might be able to break the curse. If the spirit is set free, this weapon becomes a +2 greater striking flaming hand cannon with no other abilities or curses.");;
        }

        protected override IEnumerable<RangedWeaponVariant> GetRangedWeaponVariants()
		{
			yield return new RangedWeaponVariant
            {
                Id = Guid.Parse("5d727204-d010-401b-a479-fbebdbd3b293"),
                Name = "Immolation Clan Pistol",
                Hands = "1",
                Price = 500,
                Reload = 1,
                Range = 80,
                Damage = "3d6",
                DamageTypeId = DamageTypes.Instances.Piercing.ID,
                RarityId = Rarities.Instances.Rare.ID,
                BulkId = Bulks.Instances.OneBulk.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("cb3a450b-fc47-46bb-a0d3-ed611ebbb899"), ActionTypes.Instances.TwoActions.ID, "Activate", action => 
                    {
                        action
                            .Kind("Command, Interact")
                            .Frequency("Once per day.")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("fcbbd8ad-5f13-4e7a-af97-6b215047bfdd"), "You allow yourself to become partially possessed by the immolated spirit bound to the hand cannon. For 1 minute, you look like a flaming corpse. During this time, you gain a +2 status bonus to Intimidation checks and the immolation hand cannon becomes a +2 striking flaming hand cannon.");
                            });
                    })    
                    .Build()
            };
		}

		protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("34719127-3f65-4e24-872f-492b123521d1"), Traits.Instances.Cursed.ID);
            builder.Add(Guid.Parse("3fbd10a3-2a23-414f-aad5-62f679fe1282"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("b0dd3c07-c12b-41bf-bc6d-6291029ff5ce"), Traits.Instances.Fire.ID);
            builder.Add(Guid.Parse("3a8d9002-ccac-4ea3-910c-8e956d75bfaf"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("ad38171e-50c1-4ed5-8157-5db6fa5f9e89"), Traits.Instances.Concussive.ID);
            builder.Add(Guid.Parse("ba29a3c1-0bdb-40ae-994c-5dff9e5a3a2c"), Traits.Instances.Dwarf.ID);
            builder.Add(Guid.Parse("e3fd2335-e95a-4538-8fb5-a6b0dcf0de67"), Traits.Instances.Fatal.ID, "d10"); 
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6eb35c9a-b1ef-42ee-bfe9-c5884f910e23"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 160
            };
        }
    }
}
