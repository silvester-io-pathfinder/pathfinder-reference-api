using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class YoureNext : Template
    {
        public static readonly Guid ID = Guid.Parse("0946943c-9a5c-4734-86cb-c645eaa917de");

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
            yield return new TextBlock { Id = Guid.Parse("9f91e61a-0a98-4258-a030-b85cd275dea0"), Type = TextBlockType.Text, Text = "After downing a foe, you promise another you’re coming after them next. Attempt an Intimidation check with a +2 circumstance bonus to (action: Demoralize) a single creature that you can see and that can see you. If you’re legendary in Intimidation, you can use this as a free action with the same trigger." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("5d7b27f1-3923-4884-bcde-25f8ccbaabc8"), Proficiencies.Instances.Trained.ID, Skills.Instances.Intimidation.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5696adcb-76fb-47d8-91e3-35e251f60c7f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
