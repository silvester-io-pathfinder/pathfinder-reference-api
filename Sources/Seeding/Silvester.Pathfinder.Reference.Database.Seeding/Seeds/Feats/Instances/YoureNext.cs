using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class YoureNext : Template
    {
        public static readonly Guid ID = Guid.Parse("b896f9d4-0db5-42d7-9ba5-1eb09765ba0a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "You're Next",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You reduce an enemy to 0 Hit Points.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5c626c7d-0750-4484-9503-0a77d5a3f2ee"), Type = TextBlockType.Text, Text = "After downing a foe, you promise another you’re coming after them next. Attempt an Intimidation check with a +2 circumstance bonus to (action: Demoralize) a single creature that you can see and that can see you. If you’re legendary in Intimidation, you can use this as a free action with the same trigger." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("20bcb5d7-ffed-433c-ae2c-5fc7ef957844"), Proficiencies.Instances.Trained.ID, Skills.Instances.Intimidation.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c8213212-128a-47e7-afb6-e671837cbe7c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
