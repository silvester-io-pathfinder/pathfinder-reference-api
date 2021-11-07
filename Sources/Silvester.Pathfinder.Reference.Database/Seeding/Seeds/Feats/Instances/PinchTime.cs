using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PinchTime : Template
    {
        public static readonly Guid ID = Guid.Parse("cb0f1731-243f-46f7-bf05-5533deee5fb6");

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
            yield return new TextBlock { Id = Guid.Parse("c7eff866-80b5-426c-bec8-635d78da7b25"), Type = TextBlockType.Text, Text = "One of your parents has a human life span and another an elven life span, with your own somewhere between. As a result, you have an unusual perspective on time, which you’ve learned to manifest to aid yourself in moments of stress. You gain (spell: haste) as a 3rd-level arcane innate spell, though you can target only yourself. You can (activity: Cast this Spell | Cast a Spell) once per day." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("15cc472f-3315-4980-ad7b-a063975f73ed"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
