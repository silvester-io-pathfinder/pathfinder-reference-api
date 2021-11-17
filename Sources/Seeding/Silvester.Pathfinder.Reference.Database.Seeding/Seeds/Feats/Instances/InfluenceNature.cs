using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class InfluenceNature : Template
    {
        public static readonly Guid ID = Guid.Parse("0ec9763b-e04c-4ffd-be1e-e2cea169862b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Influence Nature",
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
            yield return new TextBlock { Id = Guid.Parse("c45b70fa-e1a1-4292-a05c-110ba7e56feb"), Type = TextBlockType.Text, Text = "With patience and time, you can make bird calls, leave game trails, and ultimately influence the behavior of a certain type of animals in the region to favor and even aid you in the days to come. The GM determines the DC of any check required and the amount of time your work requires (usually at least a day or two of downtime). While you can’t directly control how you’ve influenced nature, you can hope for certain effects, such as easier hunts or birds falling silent whenever danger is approaching. If you’re legendary in Nature, you can elicit these same adjustments to animal behavior in the area by spending only 10 minutes." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("0b5ff243-48de-4620-b004-84cea4af818b"), Proficiencies.Instances.Master.ID, Skills.Instances.Nature.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f6161859-8c98-44eb-8182-951a57d11aad"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
