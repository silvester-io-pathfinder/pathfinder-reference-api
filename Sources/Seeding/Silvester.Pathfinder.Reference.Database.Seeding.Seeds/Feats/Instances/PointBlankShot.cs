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
    public class PointBlankShot : Template
    {
        public static readonly Guid ID = Guid.Parse("e46d3b92-fde8-4750-ab51-cd19bf2f1d55");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Point-Blank Shot",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("caeefad3-5cd7-40f2-8eb5-ab765cb5203a"), Type = TextBlockType.Text, Text = $"You take aim to pick off nearby enemies quickly. When using a ranged volley weapon while you are in this stance, you don't take the penalty to your attack rolls from the {ToMarkdownLink<Models.Entities.Trait>("volley", Traits.Instances.Volley.ID)} trait. When using a ranged weapon that doesn't have the {ToMarkdownLink<Models.Entities.Trait>("volley", Traits.Instances.Volley.ID)} trait, you gain a +2 circumstance bonus to damage rolls on attacks against targets within the weapon's first range increment." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("763373b9-6402-41ca-b771-440e529977d6"), Feats.Instances.ArcherDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("ee6197cd-bbc0-472e-81c4-d521ce0f4a75"), Traits.Instances.Fighter.ID);
            builder.Add(Guid.Parse("611ac37c-8f94-4091-b37f-a72fb5c6091e"), Traits.Instances.Open.ID);
            builder.Add(Guid.Parse("c4022bca-7f68-469e-956f-6c22ea1d3ba4"), Traits.Instances.Stance.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7a1f8e66-19a7-44c6-9661-f2439ab2d9b2"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
