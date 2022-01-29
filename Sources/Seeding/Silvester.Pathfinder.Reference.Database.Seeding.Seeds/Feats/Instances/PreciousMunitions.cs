using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PreciousMunitions : Template
    {
        public static readonly Guid ID = Guid.Parse("4e01786b-9829-4826-a2aa-deb7ec647250");

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
            yield return new TextBlock { Id = Guid.Parse("11ed00bf-2905-47ca-906b-3fa1e22af94b"), Type = TextBlockType.Text, Text = $"You mix flecks of precious materials you've gathered on your journeys into your custom bullets to bring out those properties in your temporary ammunition. You can use advanced alchemy to create standard-grade adamantine, cold iron, or silver ammunition, spending 1 batch of reagents per piece of ammunition. At 15th level, you can create high-grade adamantine, cold iron, or silver ammunition." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("1bc29311-5fec-41ee-b1c5-604eac404e84"), Feats.Instances.MunitionsMachinist.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Gunslinger.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d84ec2e1-647c-418f-908c-f0ece55d1984"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
