using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FlingMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("ac8d019f-2ba1-4043-877d-acbdcdd690b1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fling Magic",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "This activity has the trait corresponding to the damage type you selected.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("59c6fa3d-19a0-4434-8fe7-794f7a24ce2b"), Type = TextBlockType.Text, Text = "You fire a display of energy around a target within 80 feet, dealing damage equal to 1d4 + your Charisma modifier to the target, with a basic Reflex save against your class DC. The damage is of the type you selected when you gained your wand implement. At 3rd level and every 2 levels thereafter, the damage increases by 1d4." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("49ec8347-02ae-4bfc-abd1-3c5ebc555887"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
