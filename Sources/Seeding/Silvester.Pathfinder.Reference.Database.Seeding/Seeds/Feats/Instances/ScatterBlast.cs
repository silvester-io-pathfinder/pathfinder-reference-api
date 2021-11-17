using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ScatterBlast : Template
    {
        public static readonly Guid ID = Guid.Parse("e6bda0ca-8a0a-4372-bba9-6a3ff8bda3b5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Scatter Blast",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("917c35b2-4ca3-477a-b8be-d6e6bb1d8cbc"), Type = TextBlockType.Text, Text = "You pack your weapon with additional shot and powder, creating a risky but devastating wave of destruction. Make a ranged (action: Strike) with the firearm. The firearm’s range increment increases by 20 feet and the radius of its (trait: scatter) increases by 20 feet. The (action: Strike) gains the following failure conditions." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("04c86fc0-0166-4029-82dc-16e0b2ed2843"),
                
                
                Failure = "The firearm (trait: misfires|misfire), but it doesn’t cause the other critical failure effects listed below.",
                CriticalFailure = "The firearm (trait: misfires|misfire) and also explodes. It becomes broken, and it deals its normal weapon damage to all creatures in a 20-foot burst centered on the firearm, with a basic Reflex save against your class DC. This damage includes any from the weapon’s fundamental and property runes.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b7d1d87a-b32b-489c-a5f3-90d05136de4e"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
