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
    public class EnergyBeam : Template
    {
        public static readonly Guid ID = Guid.Parse("0c2c2c8d-79f3-49f3-80f9-a82ad47da2d9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Energy Beam",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("cb4ed32a-cbba-46ff-bd4e-3293c3685fdc"), Type = TextBlockType.Text, Text = $"You can channel your core's power through the magical gem that serves as your eye. You gain an energy beam ranged unarmed attack that deals 1d4 fire damage. The energy beam has a range increment of 20 feet. On a critical hit, the target takes persistent fire damage equal to the number of weapon damage dice. Your energy beam does not add critical specialization effects." };
            yield return new TextBlock { Id = Guid.Parse("76b87856-c6fe-4b5c-808e-264a2eda78f6"), Type = TextBlockType.Text, Text = $"----" };
            yield return new TextBlock { Id = Guid.Parse("e8ceb729-240a-4674-9bdb-1f981350295c"), Type = TextBlockType.Text, Text = $"~ Enhancement: You channel greater power. Increase the damage die of your energy beam by one step, from 1d4 to 1d6." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3d370e65-2458-46f9-bdae-24e838d0f943"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
