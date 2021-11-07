using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class StoneCommunion : Template
    {
        public static readonly Guid ID = Guid.Parse("df8df6e4-7805-4ca5-9342-d92742cbb6fc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Stone Communion",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e12a75be-f681-4b50-840e-c042c36648cf"), Type = TextBlockType.Text, Text = "You gain a unique communion with the earth and stones. You learn the Terran language and you can Activate your ka stone with a 10-minute activation (envision) to cast (spell: stone tell)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("714a99e7-3bba-44a8-ae6e-37be86fc4f4e"), Feats.Instances.KaStoneRitual.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1339ce9f-de3c-468a-951e-c40b6a0b2d27"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
