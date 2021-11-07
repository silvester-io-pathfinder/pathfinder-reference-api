using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ReloadingTrick : Template
    {
        public static readonly Guid ID = Guid.Parse("2d4b28ea-a521-4875-9c2e-5a8dbd5ea6b0");

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
            yield return new TextBlock { Id = Guid.Parse("534c91fa-db2b-4f06-a35d-885124a70e6c"), Type = TextBlockType.Text, Text = "You can fire off a single shot even when unprepared. You (action: Interact) to reload your (item: hand crossbow) and (action: Strike) with it." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("ba7f60be-fa34-4ded-9dfd-6d256d0a0208"), Feats.Instances.DrowShootistDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("226f57cf-3f7b-46cd-8f83-04e4809ba97d"),
                SourceId = Sources.Instances.AbominationVaults.ID,
                Page = -1
            };
        }
    }
}
