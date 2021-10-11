using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.General
{
    public class ExpressRiderFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("072f2ce2-2061-4325-a995-a8234724d22b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Express Rider",
                Level = 1,
                FeatTypeId = FeatTypes.Instances.General.ID,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("895098d9-c317-456b-83d3-4a32a6c188ec"), Type = TextBlockType.Text, Text = "You know how to encourage your mount to cover ground quickly. When calculating your travel speed for the day while mounted, you can attempt a Nature check to Command an Animal to increase your mount's travel speed. The DC is determined by the GM, but is typically based on the mount's level or the difficulty of the environment, whichever is harder. On a success, increase your mount's travel speed by half. This has no effect on your mount's movement in encounters." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("fd9877f2-5f9b-469e-86b7-7e6bae5d89bf"), RequiredSkillId = Skills.Instances.Nature.ID, RequiredProficiencyId = Proficiencies.Instances.Trained.ID };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Exploration.ID;
            yield return Traits.Instances.General.ID;
            yield return Traits.Instances.Move.ID;
            yield return Traits.Instances.Skill.ID;
        }
    }
}
