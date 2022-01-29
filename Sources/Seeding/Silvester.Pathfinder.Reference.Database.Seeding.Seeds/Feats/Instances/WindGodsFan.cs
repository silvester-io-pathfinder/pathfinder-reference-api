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
    public class WindGodsFan : Template
    {
        public static readonly Guid ID = Guid.Parse("9395d021-4cb6-4db5-a008-2d8b4c8d95ff");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Wind God's Fan",
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
            yield return new TextBlock { Id = Guid.Parse("dbacf1a3-d0d1-49b9-8a3f-429c9160df61"), Type = TextBlockType.Text, Text = $"Your fan can stir up even more powerful winds. You can activate an item your {ToMarkdownLink<Models.Entities.Feat>("tengu feather fan", Feats.Instances.TenguFeatherFan.ID)} one additional time per day. Add the 3rd-level {ToMarkdownLink<Models.Entities.Spell>("wall of wind", Spells.Instances.WallOfWind.ID)} spell to the spells contained within your fan." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("ae75df2d-b5a6-446f-98b7-b86e8457199f"), Feats.Instances.TenguFeatherFan.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("93bf09f2-8e53-4a37-9fc1-eed22081e6e8"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
