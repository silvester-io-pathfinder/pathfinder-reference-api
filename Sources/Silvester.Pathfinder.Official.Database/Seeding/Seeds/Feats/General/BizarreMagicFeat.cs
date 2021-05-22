using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class BizarreMagicFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("1acd1549-a4de-477d-a3f4-e862c04c8a7a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Bizarre Magic",
                Level = 7,
                FeatTypeId = FeatTypes.Instances.General.ID,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4ca461d1-0a65-42e2-8171-d30269bccf2c"), Type = Utilities.Text.TextBlockType.Text, Text = "You can draw upon strange variations in your spellcasting, whether or not you can cast occult spells. The DCs to Recognize Spells you cast and Identify Magic you use increase by 5." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("eefa8738-3515-4eec-af4f-8ad520eff4a0"), RequiredSkillId = Skills.Instances.Occultism.ID, RequiredProficiencyId = Proficiencies.Instances.Master.ID };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.General.ID;
            yield return Traits.Instances.Skill.ID;
        }
    }
}
