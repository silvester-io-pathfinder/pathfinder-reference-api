using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.General
{
    public class ShamelessRequestFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("3bb4c8cd-9368-43dd-92b2-99174568570a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shameless Request",
                Level = 7,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2f35abd2-9e98-470e-a8a4-12ff83325793"), Type = Utilities.Text.TextBlockType.Text, Text = "You can downplay the consequences or outrageousness of your requests using sheer brazenness and charm. When you Request something, you reduce any DC increases for making an outrageous request by 2, and if you roll a critical failure for your Request, you get a failure instead. While this means you can never cause your target to reduce their attitude toward you by making a Request, they eventually tire of requests, even though they still have a positive attitude toward you." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("ca583e97-25e0-48a9-a63e-c2409c37f4f7"), RequiredSkillId = Skills.Instances.Diplomacy.ID, RequiredProficiencyId = Proficiencies.Instances.Master.ID };
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
                Id = Guid.Parse("3d05db42-70ac-4233-8cbe-711a34b5018a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 266
            };
        }
    }
}
