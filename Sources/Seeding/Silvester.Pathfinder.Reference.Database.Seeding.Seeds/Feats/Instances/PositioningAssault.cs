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
    public class PositioningAssault : Template
    {
        public static readonly Guid ID = Guid.Parse("9ee086ef-5171-4de1-9d46-f47994727364");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Positioning Assault",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b1f3d8ae-78c8-4f8d-92b5-28276be3a621"), Type = TextBlockType.Text, Text = $"With punishing blows, you force your opponent into position." };
            yield return new TextBlock { Id = Guid.Parse("caff77df-d8dd-4ffa-937f-e5942f55c960"), Type = TextBlockType.Text, Text = $"Make a {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} with the required weapon. If you hit, you move the target 5 feet into a space in your reach. This follows the forced movement rules found on page 475." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8eb72999-e795-4b4a-b9ef-32fcc242b9a6"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
