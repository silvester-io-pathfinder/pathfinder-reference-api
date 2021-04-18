using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class QuickDisguiseFeat : AbstractFeatTemplate
    {
        protected override string FeatType => "General";
        protected override string ActionType => "No Action";

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = Guid.Parse("064690bd-cd97-47a5-9e4c-fb8672bb6225"),
                Name = "Quick Disguise",
                Level = 2
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9ac62ad5-c1ab-46ae-8e36-403268396a6e"), Type = Utilities.Text.TextBlockType.Text, Text = "You can set up a disguise in half the usual time (generally 5 minutes). If you’re a master, it takes one-tenth the usual time (usually 1 minute). If you’re legendary, you can create a full disguise and Impersonate as a 3-action activity." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites(FeatSeeder seeder)
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("f89492d8-f55d-445c-85a8-cd34e13549ee"), RequiredSkillId = seeder.GetSkill("Deception"), RequiredProficiencyId = seeder.GetProficiency("Expert") };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "General";
            yield return "Skill";
        }
    }
}
