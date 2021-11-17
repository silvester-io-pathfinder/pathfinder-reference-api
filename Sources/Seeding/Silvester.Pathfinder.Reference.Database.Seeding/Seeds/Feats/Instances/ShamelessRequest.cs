using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShamelessRequest : Template
    {
        public static readonly Guid ID = Guid.Parse("2ddeae87-1735-443e-85f6-283971622503");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shameless Request",
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
            yield return new TextBlock { Id = Guid.Parse("a7806f31-09f4-474a-969a-17fa05e96a23"), Type = TextBlockType.Text, Text = "You can downplay the consequences or outrageousness of your requests using sheer brazenness and charm. When you (action: Request) something, you reduce any DC increases for making an outrageous request by 2, and if you roll a critical failure for your (action: Request), you get a failure instead. While this means you can never cause your target to reduce their attitude toward you by making a (action: Request), they eventually tire of requests, even though they still have a positive attitude toward you." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("1cf8ee14-ad9e-46de-a170-1c74dce2eb62"), Proficiencies.Instances.Master.ID, Skills.Instances.Diplomacy.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0b2c5d6f-6415-4483-b3ce-4524eedd2349"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}