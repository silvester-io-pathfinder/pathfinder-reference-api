using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LivingFortification : Template
    {
        public static readonly Guid ID = Guid.Parse("37f943d7-352e-403c-adb8-5d125b1ddd05");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Living fortification",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You roll initiative.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b3912278-5970-4d2b-a40b-9c7f629ad2f2"), Type = TextBlockType.Text, Text = "You can posture defensively with firearms or crossbows, acting like a walking tower. (action: Interact) to draw a firearm or crossbow. You then position that weapon defensively, gaining a +1 circumstance bonus to AC until the start of your first turn, or a +2 circumstance bonus if the chosen weapon has the (trait: parry) trait." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8aff4df2-a6d3-4775-9162-8e513e2e8df8"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
