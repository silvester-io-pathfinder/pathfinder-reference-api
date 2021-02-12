using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class QuickSwimFeat : AbstractFeatTemplate
    {
        protected override string FeatType => "General";
        protected override string ActionType => "No Action";

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = Guid.Parse("eda136b0-c9e5-4b60-abd3-cc534c043a00"),
                Name = "Quick Swim",
                Level = 7
            };
        }

        protected override IEnumerable<FeatDetailsBlock> GetDetailBlocks()
        {
            yield return new FeatDetailsBlock { Id = Guid.Parse("08b12c02-c83f-43de-be5c-dd9ec87334cf"), Text = "You Swim 5 feet farther on a success and 10 feet farther on a critical success, to a maximum of your Speed. If you’re legendary in Athletics, you gain a swim Speed equal to your Speed." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites(FeatSeeder seeder)
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("8c0101c8-da77-49a0-b727-b56b58eafbcc"), RequiredSkillId = seeder.GetSkill("Athletics"), RequiredProficiencyId = seeder.GetProficiency("Master") };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "General";
            yield return "Skill";
        }
    }
}
