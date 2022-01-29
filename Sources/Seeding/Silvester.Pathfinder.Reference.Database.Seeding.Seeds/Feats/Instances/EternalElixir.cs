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
    public class EternalElixir : Template
    {
        public static readonly Guid ID = Guid.Parse("68ad2761-e3eb-4d9c-a421-bf6a06b24c82");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Eternal Elixir",
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
            yield return new TextBlock { Id = Guid.Parse("42c92d33-4d98-4fc9-bcd1-36980671f9b7"), Type = TextBlockType.Text, Text = $"Your body readily accepts and retains minor changes. When you drink one of your alchemical items that has the {ToMarkdownLink<Models.Entities.Trait>("elixir", Traits.Instances.Elixir.ID)} and {ToMarkdownLink<Models.Entities.Trait>("infused", Traits.Instances.Infused.ID)} traits and a duration of 1 minute or more, you can make the elixir's duration indefinite. You can do so only if the elixir's level is half your level or lower. If you later consume a different elixir and make it indefinite, the effect of the previous indefinite elixir ends." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("2b434e33-a9c8-4caf-a68e-facd8033fc7c"), Feats.Instances.ExtendElixir.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b689c660-9f74-40cc-a422-31b1ebc098ef"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
