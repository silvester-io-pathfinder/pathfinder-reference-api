using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PrevailingPosition : Template
    {
        public static readonly Guid ID = Guid.Parse("f1c33340-1e86-4f03-8413-d56ca7f5168b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Prevailing Position",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You are targeted by an attack or attempt a Reflex saving throw against a damaging effect, and you are in a stance.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("42413d71-84a3-4fc5-890a-ae621edf10aa"), Type = TextBlockType.Text, Text = "Your willingness to flow from one stance to another lets you sacrifice their benefits to better protect yourself. You leave the stance you were in, gaining a +4 circumstance bonus to the triggering saving throw or to your AC against the triggering attack." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.Manual(Guid.Parse("45469cf4-9f4e-4e99-ad71-5795ba0b56bf"), "At least one stance feat.");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0a50c3ed-e387-40b8-8445-2c08c4902950"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
