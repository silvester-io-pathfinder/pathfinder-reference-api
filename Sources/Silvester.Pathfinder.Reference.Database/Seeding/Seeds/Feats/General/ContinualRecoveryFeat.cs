using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.General
{
    public class ContinualRecoveryFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("059f1e6a-f8cd-4be2-8024-ddc21dd7cd60");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Continual Recovery",
                Level = 2,
                FeatTypeId = FeatTypes.Instances.General.ID,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ffef847d-bf3b-4b80-9e63-3a2d6714deea"), Type = Utilities.Text.TextBlockType.Text, Text = "You zealously monitor a patient’s progress to administer treatment faster. When you Treat Wounds, your patient becomes immune for only 10 minutes instead of 1 hour. This applies only to your Treat Wounds activities, not any other the patient receives." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("a1321519-14ba-4357-bae3-9bdb828a3e63"), RequiredSkillId = Skills.Instances.Medicine.ID, RequiredProficiencyId = Proficiencies.Instances.Expert.ID };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.General.ID;
            yield return Traits.Instances.Skill.ID;
        }
    }
}
