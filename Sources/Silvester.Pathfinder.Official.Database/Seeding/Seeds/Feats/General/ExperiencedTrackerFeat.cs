using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class ExperiencedTrackerFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("a64ac93e-e7c5-46d1-85ec-72d93d5dcf7a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Experienced Tracker",
                Level = 1,
                FeatTypeId = FeatTypes.Instances.General.ID,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1c266490-9c64-4913-a6bf-5b9ff4d37a9c"), Type = Utilities.Text.TextBlockType.Text, Text = "Tracking is second nature to you, and when necessary you can follow a trail without pause. You can Track while moving at full Speed by taking a –5 penalty to your Survival check. If you’re a master in Survival, you don’t take the –5 penalty. If you’re legendary in Survival, you no longer need to roll a new Survival check every hour when tracking, though you still need to roll whenever there are significant changes in the trail." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("fc764cdf-3471-461a-b528-1fdacfc69ddd"), RequiredSkillId = Skills.Instances.Survival.ID, RequiredProficiencyId = Proficiencies.Instances.Trained.ID };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.General.ID;
            yield return Traits.Instances.Skill.ID;
        }
    }
}
