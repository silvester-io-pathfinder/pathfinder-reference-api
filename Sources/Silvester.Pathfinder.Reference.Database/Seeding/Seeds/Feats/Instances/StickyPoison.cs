using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class StickyPoison : Template
    {
        public static readonly Guid ID = Guid.Parse("2bd8bcac-05fb-4e5b-881a-632a8d73bdd2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sticky Poison",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ffb0f391-2d8b-446c-9060-4cd21d9cb370"), Type = TextBlockType.Text, Text = "A combination of additional viscosity and careful application keeps your weapons poisoned even when suffering significant wear and tear. If your (action: Strike) with a poisoned weapon would expend its poison without your target attempting an initial save (due to resistance or your (action: Strike) being a critical failure, for example), attempt a DC 5 flat check. On a success, your weapon remains poisoned. If your (action: Strike) with a poisoned weapon succeeds, attempt a DC 17 flat check. On a success, your weapon remains poisoned until the end of your next turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("e4904a69-28d4-4010-a9a2-2a59c0c3ec1b"), Feats.Instances.PoisonerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f247a140-8f7e-48d7-a94e-a6efa45fac72"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
