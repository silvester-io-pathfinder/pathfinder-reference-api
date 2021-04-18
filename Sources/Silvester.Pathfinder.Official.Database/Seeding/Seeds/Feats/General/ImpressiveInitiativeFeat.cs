using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class ImpressiveInitiativeFeat : AbstractFeatTemplate
    {
        protected override string FeatType => "General";
        protected override string ActionType => "No Action";

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = Guid.Parse("3d690c93-0e1b-42c8-9d62-4e4219729dec"),
                Name = "Impressive Initiative",
                Level = 1
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("44cfef57-7ea2-4289-bab1-9721399c2190"), Type = Utilities.Text.TextBlockType.Text, Text = "You react more quickly than others can. You gain a +2 circumstance bonus to initiative rolls." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites(FeatSeeder seeder)
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("52cc51ea-a378-4653-90bd-6fde5569ae0b"), RequiredSkillId = seeder.GetSkill("Performance"), RequiredProficiencyId = seeder.GetProficiency("Trained") };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "General";
        }
    }
}
