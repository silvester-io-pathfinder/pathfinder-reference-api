using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class VirtuosicPerformerFeat : AbstractFeatTemplate
    {
        protected override string FeatType => "General";
        protected override string ActionType => "No Action";

        public static readonly Guid ID = Guid.Parse("8ee11526-08b4-451e-8424-83704f0d1a70");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Virtuosic Performer",
                Level = 1
            };
        }

        protected override IEnumerable<FeatDetailsBlock> GetDetailBlocks()
        {
            yield return new FeatDetailsBlock { Id = Guid.Parse("98b0a02f-62cf-4fd1-bfc1-674b17c90563"), Text = "You have exceptional talent with one type of performance. You gain a +1 circumstance bonus when making a certain type of performance. If you are a master in Performance, this bonus increases to +2. Select one of the following specialties and apply the bonus when attempting Performance checks of that type. If it’s unclear whether the specialty applies, the GM decides." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites(FeatSeeder seeder)
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("747c834b-3909-4dd3-8396-8e1c6353f873"), RequiredSkillId = seeder.GetSkill("Performance"), RequiredProficiencyId = seeder.GetProficiency("Trained") };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "General";
            yield return "Skill";
        }
    }
}
