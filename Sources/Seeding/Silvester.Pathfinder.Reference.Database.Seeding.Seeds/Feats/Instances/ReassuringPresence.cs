using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ReassuringPresence : Template
    {
        public static readonly Guid ID = Guid.Parse("cb11beb2-24fe-4086-97fa-7055d1ad5550");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Reassuring Presence",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An ally within 30 feet gains the frightened condition.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e46b4d8b-8897-46ae-b114-7bff5aa5d114"), Type = TextBlockType.Text, Text = $"You serve as an anchor to your close companions, calming them in times of stress. Decrease the value of the triggering ally's frightened condition by 1. The ally is then temporarily immune to your Reassuring Presence for 1 hour." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("44f6f21c-0d70-42eb-970c-58f8c145d346"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
