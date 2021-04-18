using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class ArcaneSenseFeat : AbstractFeatTemplate
    {
        protected override string FeatType => "General";
        protected override string ActionType => "No Action";

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = Guid.Parse("a6def9d1-3dd5-4d2f-8e75-1773753119d9"),
                Name = "Arcane Sense",
                Level = 1
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("72e1ef9e-b124-40eb-b185-e1f6199d6c77"), Type = Utilities.Text.TextBlockType.Text, Text = "Your study of magic allows you to instinctively sense its presence. You can cast 1st-level detect magic at will as an arcane innate spell. If you’re a master in Arcana, the spell is heightened to 3rd level; if you’re legendary, it is heightened to 4th level." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites(FeatSeeder seeder)
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("d117552a-f149-48fd-8ff1-425893fb7b00"), RequiredProficiencyId = seeder.GetProficiency("Trained"), RequiredSkillId = seeder.GetSkill("Arcana") };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "General";
            yield return "Skill";
        }
    }
}
