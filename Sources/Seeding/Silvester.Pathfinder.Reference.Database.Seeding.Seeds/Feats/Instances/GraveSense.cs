using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GraveSense : Template
    {
        public static readonly Guid ID = Guid.Parse("c64fcbfa-d9d1-4878-9688-47bc25ec2206");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Grave Sense",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("cc2ec4c6-abb2-46ad-bd35-21e3bc9afdbf"), Type = TextBlockType.Text, Text = "Your time spent hunting the undead allows you to sense them. You sense undead as a vague sense (page 465) similar to a human's sense of smell, an uncomfortable sensation akin to smelling something cloying and rotting. When in proximity to the undead, you eventually sense their presence, though you might not do so instantly, and you can't pinpoint their location. An undead using a disguise or otherwise trying to hide its presence must attempt a Deception check against your Perception DC to hide its presence from you. If the creature succeeds at its Deception check, it is then temporarily immune to your Grave Sense for 1 day." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("cdea2ccf-6176-4ed6-b65d-b5ffd58c0817"), Feats.Instances.LastwallSentryDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c24a2520-fe66-4818-be04-f2b63d1109a5"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
