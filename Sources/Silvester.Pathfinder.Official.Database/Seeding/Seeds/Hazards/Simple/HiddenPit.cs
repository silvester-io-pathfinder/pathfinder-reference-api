using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Hazards.Simple
{
    public class HiddenPit : AbstractHazardTemplate
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Hazard GetHazard(HazardSeeder seeder)
        {
            return new Hazard
            {
                Id = ID,
                Description = "",
                Level = ,
                ArmorClass = ,
                Fortitude = ,
                Reflex = ,
                HitPoints = ,
                Hardness = ,
                BrokenThreshold = ,
                Reset = "",
                CanBeDetectedMagically = ,
                CanBeDetectedAtAll = ,
                TypeId = seeder.GetHazardTypeByName("").Id,
                AttackTypeId = seeder.GetAttackTypeByName("").Id,
                Damage = ""
            };
        }

        protected override IEnumerable<string> GetImmunities()
        {
            yield return "";
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "";
        }

        protected override HazardReaction GetReaction(HazardSeeder seeder)
        {
            return new HazardReaction
            {
                Name = "",
                Effect = "",
                Trigger = ""
            };
        }

        protected override HazardDetectionRequirement? GetDetectionRequirement(HazardSeeder seeder)
        {
            return new HazardDetectionRequirement
            {
                Id = Guid.Parse(""),
                Addendum = "",
                RequiredProficiencyId = seeder.GetProficiencyByName("").Id,
                DifficultyCheck =
            };
        }

        protected override IEnumerable<HazardDisableRequirement> GetDisableRequirements(HazardSeeder seeder)
        {
            yield return new HazardDisableRequirement
            {
                Id = Guid.Parse(""),
                SkillId = seeder.GetSkillByName("").Id,
                RequiredProficiencyId = seeder.GetProficiencyByName("").Id,
                Description = "",
                DifficultyCheck =
            };
        }

        protected override IEnumerable<HazardDispellRequirement> GetDispellRequirements(HazardSeeder seeder)
        {
            yield return new HazardDispellRequirement
            {
                Id = Guid.Parse(""),
                Level = ,
                Description = "",
                CounteractDifficultyCheck =
            };
        }
    }
}
