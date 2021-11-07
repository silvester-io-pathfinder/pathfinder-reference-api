using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class IruxiUnarmedCunning : Template
    {
        public static readonly Guid ID = Guid.Parse("c9c47e69-eea4-426b-8945-1c1c7fe05768");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Iruxi Unarmed Cunning",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("29dc78ff-df98-4af0-b0e9-711a366e9105"), Type = TextBlockType.Text, Text = "You make the most of your iruxi unarmed attacks. Whenever you score a critical hit with a claw or an unarmed attack you gained from a lizardfolk ancestry feat, you apply the unarmed attack’s critical specialization effect." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("96bd6869-5275-4fe6-bfb9-59cd8324d622"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
