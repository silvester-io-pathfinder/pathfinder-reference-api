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
    public class BigMouth : Template
    {
        public static readonly Guid ID = Guid.Parse("a2093f09-4a3d-48e7-b952-d73d8ba61d93");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Big Mouth",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("50854009-4601-48da-a24a-4501f9f72178"), Type = TextBlockType.Text, Text = $"Your cheek pouches are especially stretchy. Instead of storing up to four items of Light Bulk in your cheek pouches, you can store up to 1 Bulk worth of items. The maximum size of a given item is unchanged." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("36908dbb-d0c5-43bb-9ca6-ce5c95bfdd36"), Feats.Instances.CheekPouches.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3873e5ca-bc18-4611-b8e0-96ad2236d4fd"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
