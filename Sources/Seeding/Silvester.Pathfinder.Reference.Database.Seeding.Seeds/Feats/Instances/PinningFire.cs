using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PinningFire : Template
    {
        public static readonly Guid ID = Guid.Parse("e11533e1-9bda-49ca-ac5d-a0423c3ef3f9");

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
            yield return new TextBlock { Id = Guid.Parse("d625c897-75c5-4dad-92c3-354f8b90cd91"), Type = TextBlockType.Text, Text = $"You target your opponent's clothing, equipment, or loose flesh with piercing projectiles to pin them to the ground or a nearby surface. If both your attacks hit, the target must succeed at a Reflex save against your class DC or become immobilized until it or an adjacent creature succeeds at a DC 10 Athletics check to remove the pinning projectiles. The creature doesn't become stuck if it is incorporeal, is liquid (like a water elemental or some oozes), or could otherwise escape without effort." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Monk.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bf4f44fe-cc36-4f40-9b66-00138222058c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
