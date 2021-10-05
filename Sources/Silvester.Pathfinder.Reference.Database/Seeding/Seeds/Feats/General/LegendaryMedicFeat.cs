using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.General
{
    public class LegendaryMedicFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("c041f814-94c4-43a1-be45-3bcd2621f2bb");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Legendary Medic",
                Level = 15,
                FeatTypeId = FeatTypes.Instances.General.ID,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("af297ffe-fd7d-42b4-93b4-05f79cc46251"), Type = Utilities.Text.TextBlockType.Text, Text = "You’ve discovered medical breakthroughs or techniques that achieve miraculous results. Once per day for each target, you can spend 1 hour treating that target and attempt a Medicine check to remove a disease or the blinded, deafened, doomed, or drained condition. Use the DC of the disease or of the spell or effect that created the condition. If the effect’s source is an artifact, above 20th level, or similarly powerful, increase the DC by 10." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("bd212e0a-63fd-42fc-a012-3d56ceb4d822"), RequiredSkillId = Skills.Instances.Medicine.ID, RequiredProficiencyId = Proficiencies.Instances.Legendary.ID };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.General.ID;
            yield return Traits.Instances.Skill.ID;
        }
    }
}
