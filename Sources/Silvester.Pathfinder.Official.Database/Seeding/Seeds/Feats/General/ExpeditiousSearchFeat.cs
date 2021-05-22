using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
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
                FeatTypeId = FeatTypes.Instances.General.ID,
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
    }
}
