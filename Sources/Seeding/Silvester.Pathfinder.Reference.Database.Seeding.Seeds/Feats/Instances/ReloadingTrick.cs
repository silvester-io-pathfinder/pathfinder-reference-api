using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ReloadingTrick : Template
    {
        public static readonly Guid ID = Guid.Parse("56c35b14-b5d6-40e7-bd82-62f3c76fc743");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Reloading Trick",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "If you have the (feat: Repeating Hand Crossbow Training) feat, you can use this feat with a (item: repeating hand crossbow) to load either a bolt or a magazine, but the speed means you can fire only one bolt, then the magazine jams. You must spend a 3-action (action: Interact) activity to remove the jammed magazine and clear it before it can be used again.",
                Trigger = null,
                Frequency = "once per round"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8287692a-1f12-4584-9d7f-cbd924dd8762"), Type = TextBlockType.Text, Text = "You can fire off a single shot even when unprepared. You (action: Interact) to reload your (item: hand crossbow) and (action: Strike) with it." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("cc585a22-76ee-4e71-bd5e-e9d85e65ec07"), Feats.Instances.DrowShootistDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5de50a97-3b1d-4630-9f43-dcdd74aea240"),
                SourceId = Sources.Instances.AbominationVaults.ID,
                Page = -1
            };
        }
    }
}
