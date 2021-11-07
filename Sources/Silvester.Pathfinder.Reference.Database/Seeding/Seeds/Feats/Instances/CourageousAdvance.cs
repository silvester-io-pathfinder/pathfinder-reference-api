using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CourageousAdvance : Template
    {
        public static readonly Guid ID = Guid.Parse("01d01551-f4ca-4708-b5c1-42366ac69538");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Courageous Advance",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8e178b56-2c0e-4496-8f01-37d09cdc2328"), Type = TextBlockType.Text, Text = "With a rousing call, you exhort an ally to advance. If your next action is to cast the (spell: inspire courage) composition cantrip, one ally who gains a status bonus from the spell can immediately use a reaction to (action: Stride)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificMuse(Guid.Parse("a8f43c44-8492-4952-b47c-23c730a6895f"), Muses.Instances.Warrior.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7daf169d-d6be-4833-9bb1-84eeadaf07d8"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
