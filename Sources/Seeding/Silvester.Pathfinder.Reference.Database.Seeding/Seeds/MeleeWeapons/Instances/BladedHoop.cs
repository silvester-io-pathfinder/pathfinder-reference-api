using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Bulks.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DamageTypes.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponCategories.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponGroups.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.MeleeWeapons.Instances
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
                Description = "This circular hoop has blades along its outer edge. You can wield it in two hands (using the two-hand damage) or by spinning it around an arm. While you spin the hoop, it gains the free-hand trait. Setting the hoop spinning takes 1 Interact action. In addition to the normal restrictions of the free-hand trait, extended use of the arm for locomotion (such as to Climb) interferes with the hoop's spinning and forces you to Release the hoop. You can't spin a hoop underwater. Keeping the hoop spinning requires a free action each round, which has the concentrate and manipulate traits. You can keep a hoop spinning as an exploration activity, but doing so for more than 10 minutes makes you fatigued, similarly to Hustling.",
                Price = 250,
                Damage = "1d6",
                Hands = "0+",
                BulkId = OneBulk.ID,
                WeaponCategoryId = Advanced.ID,
                WeaponGroupId = Knife.ID,
                DamageTypeId = Slashing.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Finesse.ID;
            yield return Traits.Instances.Sweep.ID;
            yield return Traits.Instances.TwoHand.ID;
            yield return Traits.Instances.Uncommon.ID;
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
