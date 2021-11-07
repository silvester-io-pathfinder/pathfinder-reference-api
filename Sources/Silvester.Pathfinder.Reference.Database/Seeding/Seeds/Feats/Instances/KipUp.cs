using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class KipUp : Template
    {
        public static readonly Guid ID = Guid.Parse("acee25d9-79a2-4e06-9f91-a0b57360e396");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Kip Up",
                Level = 7,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4924618f-3e4e-4ae4-8a19-8ad0e6c82434"), Type = TextBlockType.Text, Text = "You stand up. This movement doesn’t trigger reactions." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("ae0c5aab-55e7-4a90-bdaf-824ad22752c1"), Proficiencies.Instances.Master.ID, Skills.Instances.Acrobatics.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bfc1f7df-38bd-4e71-a66d-6c2e73a285cf"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
