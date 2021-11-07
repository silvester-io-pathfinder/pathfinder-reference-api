using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ControlledBlast : Template
    {
        public static readonly Guid ID = Guid.Parse("23f42e4d-f02d-430d-b595-3ffa15e94584");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Controlled Blast",
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
            yield return new TextBlock { Id = Guid.Parse("4d54226a-7214-4326-aab8-d21f4fa89a24"), Type = TextBlockType.Text, Text = "You maximize the effectiveness of your explosives by controlling every possible parameter of the blast meticulously. If you have the (feat: Directional Bombs) feats, you can use it with (feat: Set Explosives) or (feat: Demolition Charge), even though you didn’t throw the bombs. If you have the (feat: Calculated Splash) or (feat: Expanded Splash) feats, you can apply the additional splash damage to one of the bombs when you (feat: Set Explosives) or use (feat: Demolition Charge), and you can apply the increased splash area from (feat: Expanded Splash) to all the bombs." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("8d9841d8-2755-4ad2-a05b-d2769ce87924"), Feats.Instances.DemolitionistDedication.ID);
            builder.AddOr(Guid.Parse("58df6302-d56c-484d-a16b-f6ec764fdea5"), or => 
            {
                or.HaveSpecificFeat(Guid.Parse("156ece75-a7b3-4367-b8cd-b0e1956acaa2"), Feats.Instances.CalculatedSplash.ID);
                or.HaveSpecificFeat(Guid.Parse("89f189aa-0778-4170-9abe-6bd8ff3aab5f"), Feats.Instances.DirectionalBombs.ID);
                or.HaveSpecificFeat(Guid.Parse("d763c0bf-8672-4e7b-923e-592acadef168"), Feats.Instances.ExpandedSplash.ID);
            });
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("539d4ede-4079-48e8-a181-ec056d94a93d"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
