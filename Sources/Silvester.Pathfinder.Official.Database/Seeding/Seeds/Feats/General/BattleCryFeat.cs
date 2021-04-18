using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class BattleCryFeat : AbstractFeatTemplate
    {
        protected override string FeatType => "General";
        protected override string ActionType => "No Action";

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = Guid.Parse("5ac7371e-af01-460e-a188-198481c67505"),
                Name = "Battle Cry",
                Level = 7
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1fe89bb7-ca01-4a5f-9d34-8699b45c9829"), Type = Utilities.Text.TextBlockType.Text, Text = "When you roll initiative, you can yell a mighty battle cry and Demoralize an observed foe as a free action. If you’re legendary in Intimidation, you can use a reaction to Demoralize your foe when you critically succeed at an attack roll." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites(FeatSeeder seeder)
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("d1f28e19-88e4-4a8e-969a-581b93527bc7"), RequiredSkillId = seeder.GetSkill("Intimidation"), RequiredProficiencyId = seeder.GetProficiency("Master") };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "General";
            yield return "Skill";
        }
    }
}
