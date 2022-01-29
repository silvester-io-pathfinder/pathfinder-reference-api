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
    public class BetweenTheScales : Template
    {
        public static readonly Guid ID = Guid.Parse("ce8b9143-1638-438b-8a0f-ef86780c7fe3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Between the Scales",
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
            yield return new TextBlock { Id = Guid.Parse("799a6970-9f89-4dd0-a33a-3eef1732b8b1"), Type = TextBlockType.Text, Text = $"Underestimating you is a grave mistake, but it's one others keep making. You've learned to take advantage of slips in your foes' defenses. When you {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} a flat-footed creature using a melee weapon or unarmed attack that has the {ToMarkdownLink<Models.Entities.Trait>("agile", Traits.Instances.Agile.ID)} and {ToMarkdownLink<Models.Entities.Trait>("finesse", Traits.Instances.Finesse.ID)} traits, it gains the {ToMarkdownLink<Models.Entities.Trait>("backstabber", Traits.Instances.Backstabber.ID)} trait." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3a6032ec-acf6-49fd-a11c-edea57090b92"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
