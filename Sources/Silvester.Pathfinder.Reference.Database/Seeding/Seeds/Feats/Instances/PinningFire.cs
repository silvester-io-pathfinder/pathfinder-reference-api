using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PinningFire : Template
    {
        public static readonly Guid ID = Guid.Parse("2450942f-0b69-4336-8fd7-77e90a065e19");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Pinning Fire",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You use Flurry of Blows to make two ranged piercing weapon Strikes against the same target.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9300fbab-64f0-41cd-ac1c-509ff78f9797"), Type = TextBlockType.Text, Text = "You target your opponent’s clothing, equipment, or loose flesh with piercing projectiles to pin them to the ground or a nearby surface. If both your attacks hit, the target must succeed at a Reflex save against your class DC or become immobilized until it or an adjacent creature succeeds at a DC 10 Athletics check to remove the pinning projectiles. The creature doesn’t become stuck if it is incorporeal, is liquid (like a water elemental or some oozes), or could otherwise escape without effort." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d11c99ee-6447-4b20-8e06-76e7c2d1be82"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
