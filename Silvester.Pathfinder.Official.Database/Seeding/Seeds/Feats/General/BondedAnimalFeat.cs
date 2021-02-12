using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class BondedAnimalFeat : AbstractFeatTemplate
    {
        protected override string FeatType => "General";
        protected override string ActionType => "No Action";

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = Guid.Parse("0422a543-ec8f-4c04-9e15-5b4fd5c1f065"),
                Name = "Bonded Animal",
                Level = 2
            };
        }

        protected override IEnumerable<FeatDetailsBlock> GetDetailBlocks()
        {
            yield return new FeatDetailsBlock { Id = Guid.Parse("0b8ded86-03cd-412f-a306-67aead75c577"), Text = "You forge strong connections with animals. You can spend 7 days of downtime regularly interacting with a normal animal (not a companion or other special animal) that is friendly or helpful to you. After this duration, attempt a DC 20 Nature check. If successful, you bond with the animal. The animal is permanently helpful to you, unless you do something egregious to break your bond. A helpful animal is easier to direct, as described under Command an Animal on page 249. Bonding with a new animal ends any previous bond you had. You can’t have both a bonded animal and an animal companion (though you can have both a bonded animal and a familiar)." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites(FeatSeeder seeder)
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("add7f52e-652d-4950-83bf-fc78dcec4a4b"), RequiredSkillId = seeder.GetSkill("Nature"), RequiredProficiencyId = seeder.GetProficiency("Expert") };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "Downtime";
            yield return "General";
            yield return "Skill";
        }
    }
}
