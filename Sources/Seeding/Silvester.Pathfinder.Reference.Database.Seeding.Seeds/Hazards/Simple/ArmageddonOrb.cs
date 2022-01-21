using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Hazards.Simple
{
    public class ArmageddonOrb : Template
    {
        public static readonly Guid ID = Guid.Parse("e825d010-508c-4618-b2c1-7c8e54a14d96");

        protected override Hazard GetHazard()
        {
            return new Hazard
            {
                Id = ID,
                Name = "Armageddon Orb",
                Description = "A roiling red orb, forged from a drop of the god Rovagug's blood, rains fire from the sky when a specified condition is met.",
                Level = 23,
                CanBeDetectedMagically = true,
                TypeId = HazardTypes.Instances.Traps.ID,
                ComplexityId = HazardComplexities.Instances.Simple.ID
            };
        }

        protected override IEnumerable<HazardComponent> GetComponents()
        {
            yield break;
        }

        protected override IEnumerable<Guid> GetImmunities()
        {
            yield break;
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Rare.ID;
            yield return Traits.Instances.Magical.ID;
            yield return Traits.Instances.Trap.ID;
        }

        protected override void GetActions(InlineActionCollectionBuilder builder)
        {
            builder.Add(Guid.Parse("ea62e9d7-f1ba-4f23-abb7-0f76ec9dbaeb"), ActionTypes.Instances.Reaction.ID, "Burn it All", action =>
            {
                action
                    .Trigger("Special condition set by the trap's creator occurs; this is typically the event of their death.")
                    .Traits(traits =>
                    {
                        traits.Add(Guid.Parse("c2be3fb3-97f9-4303-95d9-43763d23a289"), Traits.Instances.Death.ID);
                        traits.Add(Guid.Parse("1338a1f1-b197-4118-8a6e-beb66d02aa58"), Traits.Instances.Divine.ID);
                        traits.Add(Guid.Parse("7b9eee53-60f6-40ee-bb59-2a2006536a2c"), Traits.Instances.Evocation.ID);
                        traits.Add(Guid.Parse("88200799-42ed-4e79-8e5f-4d1fe806d91e"), Traits.Instances.Fire.ID);
                    })
                    .Details(details =>
                    {
                        details.Text(Guid.Parse("bbf0858b-6ab3-4a6e-90f3-8e4ca74206a8"), "Fire rains from the sky in a 100-mile radius, dealing 10d6 fire damage to creatures and objects in the area. Each creature or object can attempt a DC 46 basic Reflex save. Any creature reduced to 0 Hit Points by this damage dies instantly. This is not enough damage to completely burn away a forest or level an entire mountain or city, but it typically kills most creatures in the area.");
                    });
            });
        }

        protected override HazardDetectionRequirement GetDetectionRequirement()
        {
            return new HazardDetectionRequirement
            {
                Id = Guid.Parse("bb69f5a8-1208-4b58-9923-dd4fbd3309b5"),
                RequiredProficiencyId = Proficiencies.Instances.Untrained.ID,
                DifficultyCheck = 10
            };
        }

        protected override IEnumerable<HazardDisableRequirement> GetDisableRequirements()
        {
            yield return new HazardDisableRequirement
            {
                Id = Guid.Parse("0e1b3b3d-aa2d-4963-8bb4-3485e14be099"),
                SkillId = Skills.Instances.Thievery.ID,
                RequiredProficiencyId = Proficiencies.Instances.Legendary.ID,
                Description = "to imbue thieves' tools with aspects representing Asmodeus and Sarenrae and use them to drain away the orb's power over 10 minutes; the character attempting this check takes 5 fire damage each round until the orb is depleted",
                DifficultyCheck = 48
            };
        }

        protected override IEnumerable<HazardDispellRequirement> GetDispellRequirements()
        {
            yield break;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0e1b3b3d-aa2d-4963-8bb4-3485e14be099"),
                SourceId = CoreRulebook.ID,
                Page = 526
            };
        }
    }
}
