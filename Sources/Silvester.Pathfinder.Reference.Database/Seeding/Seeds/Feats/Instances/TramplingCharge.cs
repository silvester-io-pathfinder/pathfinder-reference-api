using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TramplingCharge : Template
    {
        public static readonly Guid ID = Guid.Parse("d1f364be-e5c8-4861-b101-8deb4bea255e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Trampling Charge",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8df740d4-dbd3-4ce9-9870-528573c49e14"), Type = TextBlockType.Text, Text = "You urge your mount forward, trampling enemies in your path. You command your mount to (action: Stride) up to its Speed (or to (action: Burrow), (action: Climb), (action: Fly), or (action: Swim), if it has the corresponding movement type), moving through the spaces of any foes in your path up to one size smaller than your mount. Your mount deals damage equal to the melee (action: Strike) using its legs to each creature whose space you move through, subject to a basic Reflex save against your mount’s Athletics DC. On a critical failure, the creature also becomes flat-footed until the end of your next turn. You can damage a given creature only once during this movement." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("414086d1-42fb-4045-bd8c-9ce94d560ee0"), Feats.Instances.CavalierDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2a28f3ed-a0bd-4a42-ab55-15e6aca0454a"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
