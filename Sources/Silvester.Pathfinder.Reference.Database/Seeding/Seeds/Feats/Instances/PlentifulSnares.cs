using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PlentifulSnares : Template
    {
        public static readonly Guid ID = Guid.Parse("5a9bba67-1c68-45c1-946b-44e6525e2645");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Plentiful Snares",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4e76db5e-b489-4405-86d6-6a0af1c0f387"), Type = TextBlockType.Text, Text = "You can prepare incredible numbers of snares each day out of simple ingredients. Double the number of prepared snares granted by (feat: Snarecrafter Dedication)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("a173d49e-9b23-433e-95d2-e97ef8a6e1ce"), Feats.Instances.SnarecrafterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bc1607b3-9acb-4456-95df-24b94b44150c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
