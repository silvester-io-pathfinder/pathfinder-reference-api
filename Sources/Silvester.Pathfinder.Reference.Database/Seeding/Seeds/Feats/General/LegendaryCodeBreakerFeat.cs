using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.General
{
    public class LegendaryCodeBreakerFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("06f5008a-8b53-4c11-b0ec-2176e135d8b8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Legendary Codebreaker",
                Level = 15,
                FeatTypeId = FeatTypes.Instances.General.ID,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c92cea06-9c7d-43a4-906d-e532765fd3f2"), Type = Utilities.Text.TextBlockType.Text, Text = "Your skill with languages and codes is so great that you can decipher information with little more than a quick read through a text. You can Decipher Writing using Society while reading at normal speed. If you slow down and spend the full amount of time that’s ordinarily required and roll a success, you get a critical success; if you critically succeed while spending the normal amount of time, you gain a nearly word-for-word understanding of the document." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("ad836b29-2ab7-4e76-8979-65e3f895a534"), RequiredSkillId = Skills.Instances.Society.ID, RequiredProficiencyId = Proficiencies.Instances.Legendary.ID };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.General.ID;
            yield return Traits.Instances.Skill.ID;
        }
    }
}
