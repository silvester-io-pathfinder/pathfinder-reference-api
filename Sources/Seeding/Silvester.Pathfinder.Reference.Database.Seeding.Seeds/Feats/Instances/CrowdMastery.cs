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
    public class CrowdMastery : Template
    {
        public static readonly Guid ID = Guid.Parse("2afe9e65-ce5a-4010-8e6c-6a437ed01e76");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Crowd Mastery",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4d4fe012-3bba-41f6-a6df-fe8c01ce4385"), Type = TextBlockType.Text, Text = $"You use the crowd to your advantage, diverting your foes' attention to potential hidden dangers in the crowd. When determining if your foe is flanked, treat all squares occupied by a crowd as if they were occupied by an ally with a melee reach of 5 feet." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("abe2d79e-e47f-4d4a-913b-152a25d166cb"), Feats.Instances.LostInTheCrowd.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ac345fb3-f30a-4b7e-988a-476998831c47"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
