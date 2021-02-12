using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class SlipperySecretsFeat : AbstractFeatTemplate
    {
        protected override string FeatType => "General";
        protected override string ActionType => "No Action";

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = Guid.Parse("d466988f-8d00-4230-ab88-5c963abbecd1"),
                Name = "Slippery Secrets",
                Level = 7
            };
        }

        protected override IEnumerable<FeatDetailsBlock> GetDetailBlocks()
        {
            yield return new FeatDetailsBlock { Id = Guid.Parse("c2f95e6a-d3ee-41a3-b9c5-2ce52b87cb28"), Text = "You elude and evade attempts to uncover your true nature or intentions. When a spell or magical effect tries to read your mind, detect whether you are lying, or reveal your alignment, you can attempt a Deception check against the spell or effect’s DC. If you succeed, the effect reveals nothing." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites(FeatSeeder seeder)
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("e63447fc-7fdf-4723-be38-734253bb6e15"), RequiredSkillId = seeder.GetSkill("Deception"), RequiredProficiencyId = seeder.GetProficiency("Master")};
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "General";
            yield return "Skill";
        }
    }
}
