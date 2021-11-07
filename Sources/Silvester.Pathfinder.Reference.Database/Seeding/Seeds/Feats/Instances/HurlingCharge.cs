using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HurlingCharge : Template
    {
        public static readonly Guid ID = Guid.Parse("78365816-9933-4605-89fe-d992eda89169");

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
            yield return new TextBlock { Id = Guid.Parse("0b28597c-26d5-4099-8bcc-0a0b50dd6001"), Type = TextBlockType.Text, Text = "You make a ranged (action: Strike) with a thrown weapon you already have in your hand, (action: Stride), and then (action: Interact) to draw another weapon. If you are raging, you can add the additional damage with melee weapons you receive from raging to your damage with the thrown weapon." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("b514a273-b058-4ea5-9387-8ea338789094"), Feats.Instances.VikingDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("df88d54e-6231-49a7-95c5-2d4851c0c723"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
