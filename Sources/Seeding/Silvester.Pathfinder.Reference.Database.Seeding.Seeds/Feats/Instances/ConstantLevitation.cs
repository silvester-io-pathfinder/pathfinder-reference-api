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
    public class ConstantLevitation : Template
    {
        public static readonly Guid ID = Guid.Parse("6020244b-40a0-45ee-974e-87df85f0ae02");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Constant Levitation",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("37e16b0e-851d-4055-a423-f94204f3aa18"), Type = TextBlockType.Text, Text = $"Your power has unbound you from the earth below, letting you float harmlessly over traps and unstable terrain. You're affected by a constant {ToMarkdownLink<Models.Entities.Spell>("air walk", Spells.Instances.AirWalk.ID)}, except the highest you can walk is 5 feet above the ground. While your psyche is unleashed, you're also affected by a {ToMarkdownLink<Models.Entities.Spell>("fly", Spells.Instances.Fly.ID)} spell." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("796990fb-1cdb-4daf-a8d3-5df80d051aed"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
