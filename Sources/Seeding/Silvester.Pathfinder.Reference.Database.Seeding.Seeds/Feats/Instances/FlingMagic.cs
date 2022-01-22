using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FlingMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("361abf22-78b3-4f44-afa4-f3f7f7ea8cec");

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
            yield return new TextBlock { Id = Guid.Parse("7e9f53e0-d7c2-4e5c-9428-70a966b6d65a"), Type = TextBlockType.Text, Text = $"You fire a display of energy around a target within 80 feet, dealing damage equal to 1d4 + your Charisma modifier to the target, with a basic Reflex save against your class DC. The damage is of the type you selected when you gained your wand implement. At 3rd level and every 2 levels thereafter, the damage increases by 1d4." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("20b56dd3-12eb-43e7-b9bc-c3093940f411"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
