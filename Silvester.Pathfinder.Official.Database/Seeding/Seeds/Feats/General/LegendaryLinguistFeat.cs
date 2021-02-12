using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class LegendaryLinguistFeat : AbstractFeatTemplate
    {
        protected override string FeatType => "General";
        protected override string ActionType => "No Action";

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = Guid.Parse("3afb7bd6-f0c2-4187-9d47-f7a06d512fd3"),
                Name = "Legendary Linguist",
                Level = 15
            };
        }

        protected override IEnumerable<FeatDetailsBlock> GetDetailBlocks()
        {
            yield return new FeatDetailsBlock { Id = Guid.Parse("6156f6a0-8ca3-4260-aa1c-8842c9a6d780"), Text = "You’re so skilled with languages you can create a pidgin instantly. You can always talk to any creature that has a language—even a language you don’t know —by creating a new pidgin language that uses simplified terms and conveys basic concepts. To do so, you must first understand at least what medium of communication the creature uses (speech, sign language, and so on)." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites(FeatSeeder seeder)
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("b7c2609b-e269-4df4-8aeb-2abf5fe06560"), RequiredSkillId = seeder.GetSkill("Society"), RequiredProficiencyId = seeder.GetProficiency("Legendary") };
            yield return new FeatPrerequisite { Id = Guid.Parse("1abf8f92-6500-471f-8a76-0890564bd71b"), RequiredFeatId = MultilingualFeat.ID};
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "General";
            yield return "Skill";
        }
    }
}
