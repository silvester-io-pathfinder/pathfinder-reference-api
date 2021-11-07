using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Grovel : Template
    {
        public static readonly Guid ID = Guid.Parse("b7be0dfe-427b-4bf7-9d59-5e7306abafe5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Grovel",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("722491ee-94f5-43df-b24b-1b64e31baaa4"), Type = TextBlockType.Text, Text = "With obsequious words and begging gestures, you convince your foe you&#39;re less of a threat. You attempt to (action: Feint) against a creature. Unlike a normal (action: Feint), the creature can be within 30 feet instead of in your melee reach, and you make your check against its Will DC instead of its Perception DC." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("68dfef86-ec54-44e3-8f83-e21a9087958f"), Proficiencies.Instances.Trained.ID, Skills.Instances.Crafting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("563bf5eb-9d77-4832-8ba6-417585f403dd"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
