using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class FascinatingPerformanceFeat : AbstractFeatTemplate
    {
        protected override string FeatType => "General";
        protected override string ActionType => "No Action";

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = Guid.Parse("d76bcd62-20d9-4fce-9fc1-735ec21a0cb2"),
                Name = "Fascinating Performance",
                Level = 1
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b95929b6-0cf7-4eb3-aa95-fa8f2f2c9ca0"), Type = Utilities.Text.TextBlockType.Text, Text = "When you Perform, compare your result to the Will DC of one observer. If you succeed, the target is fascinated by you for 1 round. If the observer is in a situation that demands immediate attention, such as combat, you must critically succeed to fascinate it and the Perform action gains the incapacitation trait. You must choose which creature you’re trying to fascinate before you roll your check, and the target is then temporarily immune for 1 hour." };
            yield return new TextBlock { Id = Guid.Parse("0589bdf3-abf3-4850-a9fe-5f8454150417"), Type = Utilities.Text.TextBlockType.Text, Text = "If you’re an expert in Performance, you can fascinate up to four observers; if you’re a master, you can fascinate up to 10 observers; and if you’re legendary, you can fascinate any number of observers at the same time." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites(FeatSeeder seeder)
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("a9682158-d756-4503-a952-454d8396b2a2"), RequiredSkillId = seeder.GetSkill("Performance"), RequiredProficiencyId = seeder.GetProficiency("Trained") };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "General";
            yield return "Skill";
        }
    }
}
