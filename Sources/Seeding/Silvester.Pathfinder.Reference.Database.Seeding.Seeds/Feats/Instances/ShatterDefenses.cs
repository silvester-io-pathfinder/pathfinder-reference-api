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
    public class ShatterDefenses : Template
    {
        public static readonly Guid ID = Guid.Parse("37520a26-5826-4d35-8eb1-372f05c0d9a6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shatter Defenses",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f19a96b5-2b41-4af8-bb5d-fb9772ada563"), Type = TextBlockType.Text, Text = $"Your offense exploits your enemy's fear. Make a melee {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} against a frightened creature. If you hit and deal damage, the target becomes flat-footed until its frightened condition ends." };
            yield return new TextBlock { Id = Guid.Parse("6ee8efa3-b30a-417e-a4e5-57a0841891dd"), Type = TextBlockType.Text, Text = $"If the target was already flat-footed to you when you damaged it with this {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}, it can't reduce its frightened value below 1 until the start of your next turn." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Fighter.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Press.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("edb7ef8d-ac9e-4786-a7b9-6bc23e7d3949"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
