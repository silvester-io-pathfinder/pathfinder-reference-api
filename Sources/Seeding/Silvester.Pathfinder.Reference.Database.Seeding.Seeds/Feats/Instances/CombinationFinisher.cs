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
    public class CombinationFinisher : Template
    {
        public static readonly Guid ID = Guid.Parse("9803007e-955a-42e4-b586-3a602a3e6e0e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Combination Finisher",
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
            yield return new TextBlock { Id = Guid.Parse("f98cf2cf-9e19-43cb-8d54-f7286efe6a40"), Type = TextBlockType.Text, Text = $"You combine a series of attacks with a powerful finishing blow. Your {ToMarkdownLink<Models.Entities.Trait>("finishers'", Traits.Instances.Finisher.ID)} {ToMarkdownLink<Models.Entities.Action>("Strikes", Actions.Instances.Strike.ID)} have a lower multiple attack penalty: -4 (or -3 with an {ToMarkdownLink<Models.Entities.Trait>("agile", Traits.Instances.Agile.ID)} weapon) if it's the second attack on your turn, or -8 (or -6 with an {ToMarkdownLink<Models.Entities.Trait>("agile", Traits.Instances.Agile.ID)} weapon) if it's the third or subsequent attack on your turn, instead of -5 and -10, respectively." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Swashbuckler.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("754e5a03-6661-4205-a2a4-fcc02fee0d55"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
