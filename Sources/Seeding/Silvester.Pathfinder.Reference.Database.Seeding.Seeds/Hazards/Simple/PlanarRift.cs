using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Hazards.Simple
{
    public class PlanarRift : Template
    {
        public static readonly Guid ID = Guid.Parse("d038f033-4ea9-45ee-b0fa-c5707d5eda89");

        protected override Hazard GetHazard()
        {
            return new Hazard
            {
                Id = ID,
                Name = "Planar Rift",
                Description = "A rift attempts to draw creatures into another plane(the GM chooses the specific plane).",
                Level = 13,
                CanBeDetectedMagically = false,
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
            yield return Traits.Instances.Magical.ID;
            yield return Traits.Instances.Trap.ID;
        }

        protected override void GetActions(InlineActionCollectionBuilder builder)
        {
            builder.Add(Guid.Parse("c2534177-226c-402f-aae3-bc40111eed8d"), ActionTypes.Instances.Reaction.ID, "Into the Great Beyond", action =>
            {
                action
                    .Trigger("A creature moves within 10 feet of the rift.")
                    .Traits(traits =>
                    {
                        traits.Add(Guid.Parse("8e938dd1-8014-4446-a6b5-dbc94319fe5a"), Traits.Instances.Conjuration.ID);
                        traits.Add(Guid.Parse("81ecf571-d7de-4c13-8cb1-f36133619e60"), Traits.Instances.Occult.ID);
                        traits.Add(Guid.Parse("82078d4b-b793-49bf-8547-cbb144cb48ef"), Traits.Instances.Teleportation.ID);
                    })
                    .Details(details =>
                    {
                        details.Text(Guid.Parse("ae24d667-ccda-431a-a998-7e754abfee8e"), "The triggering creature and all creatures within 30 feet of the rift are drawn into another plane. Each creature can attempt a DC 33 Reflex save to avoid this fate.");
                    });
            });
        }

        protected override HazardDetectionRequirement GetDetectionRequirement()
        {
            return new HazardDetectionRequirement
            {
                Id = Guid.Parse("b2d72108-a773-409c-a190-793667d2ba60"),
                RequiredProficiencyId = Proficiencies.Instances.Trained.ID,
                DifficultyCheck = 35
            };
        }

        protected override IEnumerable<HazardDisableRequirement> GetDisableRequirements()
        {
            yield return new HazardDisableRequirement
            {
                Id = Guid.Parse("4c0d2ac8-48f8-4612-b8ab-72db8b4aa831"),
                SkillId = Skills.Instances.Thievery.ID,
                RequiredProficiencyId = Proficiencies.Instances.Master.ID,
                Description = "To assemble a rift seal using objects strongly grounded to your plane.",
                DifficultyCheck = 33
            };
        }

        protected override IEnumerable<HazardDispellRequirement> GetDispellRequirements()
        {
            yield return new HazardDispellRequirement
            {
                Id = Guid.Parse("4c0d2ac8-48f8-4612-b8ab-72db8b4aa831"),
                Level = 7,
                Description = "To counteract the rift.",
                CounteractDifficultyCheck = 31
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4c0d2ac8-48f8-4612-b8ab-72db8b4aa831"),
                SourceId = CoreRulebook.ID,
                Page = 525
            };
        }
    }
}
