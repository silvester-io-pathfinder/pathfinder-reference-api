using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class BizarreMagicFeat : AbstractFeatTemplate
    {
        protected override string FeatType => "General";
        protected override string ActionType => "No Action";

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = Guid.Parse("1acd1549-a4de-477d-a3f4-e862c04c8a7a"),
                Name = "Bizarre Magic",
                Level = 7
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4ca461d1-0a65-42e2-8171-d30269bccf2c"), Type = Utilities.Text.TextBlockType.Text, Text = "You can draw upon strange variations in your spellcasting, whether or not you can cast occult spells. The DCs to Recognize Spells you cast and Identify Magic you use increase by 5." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites(FeatSeeder seeder)
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("eefa8738-3515-4eec-af4f-8ad520eff4a0"), RequiredSkillId = seeder.GetSkill("Occultism"), RequiredProficiencyId = seeder.GetProficiency("Master") };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "General";
            yield return "Skill";
        }
    }
}
