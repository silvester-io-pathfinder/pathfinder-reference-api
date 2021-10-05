using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.General
{
    public class WaryDisarmamentFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("52456558-ce51-4f42-8ff2-fd4dbb72c25d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Wary Disarmament",
                Level = 2,
                FeatTypeId = FeatTypes.Instances.General.ID,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("73719d8e-db64-463a-99f2-c30bc4c50bab"), Type = Utilities.Text.TextBlockType.Text, Text = "If you trigger a device or set off a trap while disarming it, you gain a +2 circumstance bonus to your AC or saving throw against the device or trap. This applies only to attacks or effects triggered by your failed attempt, not to any later ones, such as additional attacks from a complex trap." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("80ac8e37-d1bd-4a89-857a-fdc581aa0547"), RequiredSkillId = Skills.Instances.Thievery.ID, RequiredProficiencyId = Proficiencies.Instances.Expert.ID };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.General.ID;
            yield return Traits.Instances.Skill.ID;
        }
    }
}
