using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.General
{
    public class FoilSensesFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("fccdaf8a-46b0-4a18-9a90-dbb228317b58");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Foil Senses",
                Level = 7,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a36d8e49-5dd2-44c2-acb0-89d69ed09e80"), Type = Utilities.Text.TextBlockType.Text, Text = "You are adept at foiling creatures’ special senses and cautious enough to safeguard against them at all times. Whenever you use the Avoid Notice, Hide, or Sneak actions, you are always considered to be taking precautions against special senses (see the Detecting with Other Senses sidebar on page 465)." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("c8867d56-91ed-416e-9bc3-d2ef213bb3aa"), RequiredSkillId = Skills.Instances.Stealth.ID, RequiredProficiencyId = Proficiencies.Instances.Master.ID };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.General.ID;
            yield return Traits.Instances.Skill.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("de01f7f6-d940-4409-9950-27e351fdd93f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 261
            };
        }
    }
}
