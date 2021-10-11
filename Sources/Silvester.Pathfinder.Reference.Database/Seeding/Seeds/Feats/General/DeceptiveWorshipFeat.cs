using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.General
{
    public class DeceptiveWorshipFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("8fcafbc6-fd4a-48e0-a35b-14eda56ebffe");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Deceptive Worship",
                Level = 1,
                FeatTypeId = FeatTypes.Instances.Skill.ID,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5c4401db-2154-414f-827a-ed50e124cfa7"), Type = Utilities.Text.TextBlockType.Text, Text = "Members of your cult frequently pass themselves off as worshippers of other religions. You can use Occultism instead of Deception to Impersonate a typical worshipper of another faith or to Lie specifically to claim you are a member of the faith you are Impersonating. You still need to use the Deception skill to Impersonate a specific worshipper or to perform other deceptive actions, such as attempting to Lie about any other matter." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("fed22740-e2ce-4863-b5f0-c5124796866b"), RequiredProficiencyId = Proficiencies.Instances.Trained.ID, RequiredSkillId = Skills.Instances.Occultism.ID };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.General.ID;
            yield return Traits.Instances.Skill.ID;
        }
    }
}
