using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class CharmingLiarFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("43ae43aa-11d2-420f-bf17-6978f8a45a0f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Charming Liar",
                Level = 1,
                FeatTypeId = FeatTypes.Instances.General.ID,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d7fb4179-4b97-4759-8a00-3984bdb91602"), Type = Utilities.Text.TextBlockType.Text, Text = "Your charm allows you to win over those you lie to. When you get a critical success using the Lie action, the target’s attitude toward you improves by one step, as though you’d succeeded at using Diplomacy to Make an Impression. This works only once per conversation, and if you critically succeed against multiple targets using the same result, you choose one creature’s attitude to improve. You must be lying to impart seemingly important information, inflate your status, or ingratiate yourself, which trivial or irrelevant lies can’t achieve." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("d248a540-3462-4092-810f-4bec985fc25d"), RequiredSkillId = Skills.Instances.Deception.ID, RequiredProficiencyId = Proficiencies.Instances.Trained.ID };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.General.ID;
            yield return Traits.Instances.Skill.ID;
        }
    }
}
