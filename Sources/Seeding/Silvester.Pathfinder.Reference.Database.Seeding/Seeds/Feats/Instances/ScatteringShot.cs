using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ScatteringShot : Template
    {
        public static readonly Guid ID = Guid.Parse("5cce5186-0150-4129-801f-93d6d1c1c73a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Scattering Shot",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c7bb9934-1cba-44b8-be35-ffaa681b815c"), Type = TextBlockType.Text, Text = "You fling a bomb into the air and then shoot it with your gun before it falls, raining destruction down over a wide area. If necessary, you (action: Interact) to draw the bomb and regrip your weapon. You throw your bomb to the corner of a square within your firearm’s first range increment and shoot it with your firearm. All creatures in a 15-foot burst of the bomb take the bomb’s normal damage with a basic Reflex save against your class DC. They don’t take any splash or persistent damage the bomb would deal normally." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9d2360d7-7515-45e6-8631-4db87c91411b"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
