using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class MultilingualFeat : AbstractFeatTemplate
    {
        protected override string FeatType => "General";
        protected override string ActionType => "No Action";

        public static readonly Guid ID = Guid.Parse("8dc95af1-d049-457f-91f8-311ead81336d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Multilingual",
                Level = 1,
                Special = "You can select this feat multiple times. Each time, you learn additional languages."
            };
        }

        protected override IEnumerable<FeatDetailsBlock> GetDetailBlocks()
        {
            yield return new FeatDetailsBlock { Id = Guid.Parse("5983317e-3930-45c3-a5b2-d286fd3bf850"), Text = "You easily pick up new languages. You learn two new languages, chosen from common languages, uncommon languages, and any others you have access to. You learn an additional language if you are or become a master in Society and again if you are or become legendary." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites(FeatSeeder seeder)
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("620a99f0-9377-498b-a4cb-590441e62b51"), RequiredSkillId = seeder.GetSkill("Society"), RequiredProficiencyId = seeder.GetProficiency("Trained") };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "General";
            yield return "Skill";
        }
    }
}
