using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.General
{
    public class ExpeditiousSearchFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("dbd06473-8700-438f-b4e1-35474b87171c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Expeditious Search",
                Level = 7,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fd638442-dba6-4c64-a978-6076c474ffa1"), Type = Utilities.Text.TextBlockType.Text, Text = "You have a system that lets you search at great speed, finding details and secrets twice as quickly as others can. When Searching, you take half as long as usual to Search a given area. This means that while exploring, you double the Speed you can move while ensuring you’ve Searched an area before walking into it (up to half your Speed). If you’re legendary in Perception, you instead Search areas four times as quickly." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("3e5994d8-c6c5-43fb-acb3-1654a1850197"), RequiredSkillId = Skills.Instances.Perception.ID, RequiredProficiencyId = Proficiencies.Instances.Master.ID };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.General.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e71b1777-17a9-4919-bfab-da5817253ce8"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 260
            };
        }
    }
}
