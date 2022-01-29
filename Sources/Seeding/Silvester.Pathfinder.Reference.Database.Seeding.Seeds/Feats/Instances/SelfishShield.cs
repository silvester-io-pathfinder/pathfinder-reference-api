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
    public class SelfishShield : Template
    {
        public static readonly Guid ID = Guid.Parse("3cf157ca-d74e-468d-8ef5-7285f08bb077");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Selfish Shield",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An enemy within 15 feet damages you.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e1255aae-eb40-4a6d-865d-e37a00c59fa3"), Type = TextBlockType.Text, Text = $"Your self-interest keeps you safe. You gain resistance against the triggering damage equal to 2 + half your level, regardless of damage type." };
            yield return new TextBlock { Id = Guid.Parse("6bffcbff-d712-4e08-8695-8a0ad9bd8fea"), Type = TextBlockType.Text, Text = $"In addition, your {ToMarkdownLink<Models.Entities.Action>("Strikes", Actions.Instances.Strike.ID)} against the triggering creature deal 1 extra damage until the end of your next turn. You choose whether this extra damage is evil or negative each time you use this reaction. This extra damage increases to 2 at 9th level and 3 at 16th level." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a710e410-3743-46c1-8fce-29f8783616aa"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
