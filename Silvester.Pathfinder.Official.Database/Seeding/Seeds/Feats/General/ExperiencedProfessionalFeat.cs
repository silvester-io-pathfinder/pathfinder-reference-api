using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class ExperiencedProfessionalFeat : AbstractFeatTemplate
    {
        protected override string FeatType => "General";
        protected override string ActionType => "No Action";

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = Guid.Parse("0e715099-8cfd-449b-a6b0-37467f68accc"),
                Name = "Experienced Professional",
                Level = 1
            };
        }

        protected override IEnumerable<FeatDetailsBlock> GetDetailBlocks()
        {
            yield return new FeatDetailsBlock { Id = Guid.Parse("5ca60765-3953-40b6-8d4a-0532b2e4c80d"), Text = "You carefully safeguard your professional endeavors to prevent disaster. When you use Lore to Earn Income, if you roll a critical failure, you instead get a failure. If you’re an expert in Lore, you gain twice as much income from a failed check to Earn Income, unless it was originally a critical failure." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites(FeatSeeder seeder)
        {
            yield return new LorePrerequisite { Id = Guid.Parse("e412585e-1ba6-4f86-9c06-7f7ce9ae82f9"), RequiredProficiencyId = seeder.GetProficiency("Trained") };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "General";
            yield return "Skill";
        }
    }
}
