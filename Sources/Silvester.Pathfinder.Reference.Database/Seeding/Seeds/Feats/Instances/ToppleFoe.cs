using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ToppleFoe : Template
    {
        public static readonly Guid ID = Guid.Parse("f1d3a239-608e-4bb9-84a8-2ee95e5c3a05");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Topple Foe",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An ally succeeds at a melee Strike against an opponent you are both adjacent to.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d7f42dc7-6382-4438-9f44-0cd684c7f661"), Type = TextBlockType.Text, Text = "You take advantage of the opening created by your ally to tip your foe off their feet. Attempt an Athletics check to (action: Trip) the target of the triggering attack." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("839144e2-ae6f-4795-b4d5-295a2934eb41"), Proficiencies.Instances.Trained.ID, Skills.Instances.Athletics.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c294c308-b326-4564-b703-5d4feca287ca"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
