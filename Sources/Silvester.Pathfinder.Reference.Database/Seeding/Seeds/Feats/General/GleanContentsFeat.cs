using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.General
{
    public class GleanContentsFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("6005ed95-3c61-46e4-a27c-c56d02231d02");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Glean Contents",
                Level = 1,
                FeatTypeId = FeatTypes.Instances.General.ID,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4a39d533-e1f2-479e-88d3-67e0856e738f"), Type = TextBlockType.Text, Text = "You are adept at quickly scanning loose papers and carefully discerning the contents of sealed letters without damaging the seal. You can attempt Society checks to Decipher Writing on a message that is only partially glimpsed, upside down or reversed from your perspective, or even sealed. However, on a critical failure, the recipient is made aware of your efforts (for instance, you damage the seal or disturb the papers in some way). When using this feat to decipher sealed letters, your attempt to Decipher Writing gains the manipulate trait. This feat doesn't prevent witnesses from noticing your efforts, particularly with sealed letters which you must manipulate directly in order to read; you might need to attempt Deception or Stealth checks to avoid being noticed." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("ddb126f1-00e9-4bbb-b980-1e3248ba8752"), RequiredSkillId = Skills.Instances.Society.ID, RequiredProficiencyId = Proficiencies.Instances.Trained.ID };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.General.ID;
            yield return Traits.Instances.Skill.ID;
        }
    }
}
