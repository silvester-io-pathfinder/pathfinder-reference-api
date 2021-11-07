using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EnforcedOrder : Template
    {
        public static readonly Guid ID = Guid.Parse("455b4297-7d0e-4a54-8930-a4f02c55e62e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Enforced Order",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a7e052ee-aeec-4bd2-9fe8-8f7ce60a2040"), Type = TextBlockType.Text, Text = "You never fail to strike down the ever-expanding reaches of chaos. All your weapon and unarmed (action: Strikes | Strike) deal 1 additional lawful damage and have the (trait: lawful) and (trait: magical) traits." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("5e5ab792-d42d-4ff7-9b26-92b57286ba36"), Feats.Instances.DoubleSlice.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5a545ff1-1338-4bde-a8c4-f4d7f773eba8"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
