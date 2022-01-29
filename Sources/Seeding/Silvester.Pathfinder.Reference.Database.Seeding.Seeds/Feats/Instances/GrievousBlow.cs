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
    public class GrievousBlow : Template
    {
        public static readonly Guid ID = Guid.Parse("95e4aab5-a507-4f99-b7ea-c9b922f45c9e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Grievous Blow",
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
            yield return new TextBlock { Id = Guid.Parse("4b3518a5-68e0-4cb4-945e-a7daf7c9ad26"), Type = TextBlockType.Text, Text = $"You know how to deliver focused, powerful blows that bypass your enemies' resistances. Make an unarmed melee {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}. This counts as two attacks when calculating your multiple attack penalty. If this {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} hits, you deal two extra weapon damage dice. If you are at least 18th level, increase this to three extra weapon damage dice." };
            yield return new TextBlock { Id = Guid.Parse("6b2a440d-a692-4bb2-95b6-154c1f5d438d"), Type = TextBlockType.Text, Text = $"This attack also ignores an amount of resistance to physical damage, or to a specific physical damage type, equal to your level." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("76805b85-6e0b-4e54-9345-17a8ee29bbd5"), Feats.Instances.MartialArtistDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Flourish.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("03e1c223-d3bb-4aaa-a98c-9c5fe88a01c6"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
