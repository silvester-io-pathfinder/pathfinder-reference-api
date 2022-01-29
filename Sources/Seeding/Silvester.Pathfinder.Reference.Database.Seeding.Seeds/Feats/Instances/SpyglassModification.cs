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
    public class SpyglassModification : Template
    {
        public static readonly Guid ID = Guid.Parse("9f9b465f-3b02-4073-b327-ed895b87bc3c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Spyglass Modification",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9585422e-9d88-442a-9faf-1ab8907925b1"), Type = TextBlockType.Text, Text = $"Your enhanced visual gear includes a regulating scope and reflectors, combined in an ingenuous setup that allows you to see around corners within the area of your overwatch field. This permits your overwatch field to extend around a single corner or turn and allows you to see around that corner as well. This ability doesn't let you see through walls or other barriers. You can't use it to see around a second or further corner, and it doesn't allow you to make ranged attacks or perform other actions that require line of effect with your target." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("d15eabca-0f79-4519-bc79-9c7d64a73528"), Feats.Instances.OverwatchDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("c85d08f9-310a-4f36-baed-5e96f60a8f71"), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d25993fc-e2dd-4bf7-b5e0-ecfc6b779a4b"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
