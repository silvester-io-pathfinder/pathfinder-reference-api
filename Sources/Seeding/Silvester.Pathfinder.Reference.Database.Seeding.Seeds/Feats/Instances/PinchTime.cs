using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PinchTime : Template
    {
        public static readonly Guid ID = Guid.Parse("684693e7-b2dc-4870-a338-b733149e2b54");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Pinch Time",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a9acfb2b-66fd-4c50-9a79-347b89b53e0e"), Type = TextBlockType.Text, Text = "One of your parents has a human life span and another an elven life span, with your own somewhere between. As a result, you have an unusual perspective on time, which you've learned to manifest to aid yourself in moments of stress. You gain (spell: haste) as a 3rd-level arcane innate spell, though you can target only yourself. You can (activity: Cast this Spell | Cast a Spell) once per day." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9a9b5df3-b41a-4398-8c09-5f7aa34ac739"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
