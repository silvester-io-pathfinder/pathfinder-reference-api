using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SlipperySecrets : Template
    {
        public static readonly Guid ID = Guid.Parse("c06f6d85-9c8b-453f-bd1a-4a8b1a2e7782");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Slippery Secrets",
                Level = 7,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("46838577-9694-41ef-b827-e7f40a7eb21b"), Type = TextBlockType.Text, Text = "You elude and evade attempts to uncover your true nature or intentions. When a spell or magical effect tries to read your mind, detect whether you are lying, or reveal your alignment, you can attempt a Deception check against the spell or effect’s DC. If you succeed, the effect reveals nothing." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("01d9ac65-ffc0-4b1a-9232-8cea537decf3"), Proficiencies.Instances.Master.ID, Skills.Instances.Deception.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("94ed2049-ec70-48fb-8f36-355c7ccbce55"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
