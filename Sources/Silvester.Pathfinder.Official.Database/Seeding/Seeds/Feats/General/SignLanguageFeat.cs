using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class SignLanguageFeat : AbstractFeatTemplate
    {
        protected override string FeatType => "General";
        protected override string ActionType => "No Action";

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = Guid.Parse("7aded813-2325-4a4d-aea7-077680584823"),
                Name = "Sign Language",
                Level = 1
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0f984b03-0710-45ec-b3d2-8b79b3bad4d1"), Type = Utilities.Text.TextBlockType.Text, Text = "You learn the sign languages associated with the languages you know, allowing you to sign and understand signs. Sign languages typically require both hands to convey more complex concepts, and they are visual rather than auditory." };
            yield return new TextBlock { Id = Guid.Parse("6f804bdb-e8ea-4b94-b8da-9dd428098588"), Type = Utilities.Text.TextBlockType.Text, Text = "Sign language is difficult to understand during combat due to the level of attention needed, unlike basic gestures like pointing at a foe to suggest a target. Sign language is hard to use in areas of low visibility, just like speech is difficult in a noisy environment." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites(FeatSeeder seeder)
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("83519dcb-ddc3-4a7f-b404-b6822034a00e"), RequiredSkillId = seeder.GetSkill("Society"), RequiredProficiencyId = seeder.GetProficiency("Trained") };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "General";
            yield return "Skill";
        }
    }
}
