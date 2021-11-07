using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HurlingCharge : Template
    {
        public static readonly Guid ID = Guid.Parse("560f40ef-05e1-4c44-b5d2-61a45d975daa");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Hurling Charge",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b4eb4ad6-391d-4f01-8d9f-bfd3b6c253f6"), Type = TextBlockType.Text, Text = "You make a ranged (action: Strike) with a thrown weapon you already have in your hand, (action: Stride), and then (action: Interact) to draw another weapon. If you are raging, you can add the additional damage with melee weapons you receive from raging to your damage with the thrown weapon." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("c765a9aa-a1dc-46ad-b3b9-ea0436b2e4a4"), Feats.Instances.VikingDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7b390766-d26d-4257-b661-cb7362c2dc8a"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
