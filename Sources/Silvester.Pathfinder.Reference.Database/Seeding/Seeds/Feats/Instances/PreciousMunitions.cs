using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PreciousMunitions : Template
    {
        public static readonly Guid ID = Guid.Parse("2acf9604-4051-4b21-8d57-d35ba7bb3a16");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Precious Munitions",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("86668d2f-63d6-4076-8e27-4e6e5763d8fc"), Type = TextBlockType.Text, Text = "You mix flecks of precious materials you’ve gathered on your journeys into your custom bullets to bring out those properties in your temporary ammunition. You can use advanced alchemy to create standard-grade adamantine, cold iron, or silver ammunition, spending 1 batch of reagents per piece of ammunition. At 15th level, you can create high-grade adamantine, cold iron, or silver ammunition." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("a2b2607c-6c1f-4542-b961-30acc2fc97f5"), Feats.Instances.MunitionsMachinist.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e38aa363-0248-47eb-9d41-3b4f88317780"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
