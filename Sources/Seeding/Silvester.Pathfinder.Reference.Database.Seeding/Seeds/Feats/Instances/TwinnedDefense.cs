using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TwinnedDefense : Template
    {
        public static readonly Guid ID = Guid.Parse("08d51a6a-1e8c-47dd-a46d-e63ed4449dba");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Twinned Defense",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d3ae46cb-a9e4-46ad-a039-3e2e4eb63a43"), Type = TextBlockType.Text, Text = "You're always ready to use your off-hand weapon to interfere with attacks against you. While you are in this stance, you constantly gain the benefits of the (feat: Twin Parry) action." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("33d9e08f-3d29-46cb-91c3-f8027256342c"), Feats.Instances.TwinParry.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6d398503-5a9b-4531-9917-124a9be200d9"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
