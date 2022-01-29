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
    public class ArcaneEye : Template
    {
        public static readonly Guid ID = Guid.Parse("75448ad2-1e87-4ca0-b2a8-78079e2e55be");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Arcane Eye",
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
            yield return new TextBlock { Id = Guid.Parse("f6883541-cd2c-44d4-8a52-ac7009918269"), Type = TextBlockType.Text, Text = $"Your eye has been magically enhanced to pierce darkness. You gain darkvision." };
            yield return new TextBlock { Id = Guid.Parse("aab446d9-7e81-42ef-afd4-0e9c019c31ac"), Type = TextBlockType.Text, Text = $"----" };
            yield return new TextBlock { Id = Guid.Parse("1c5fb12c-b507-4aa9-b129-d5af0179c773"), Type = TextBlockType.Text, Text = $"~ Enhancement: Your eye can see invisible creatures in brief spurts. You can cast {ToMarkdownLink<Models.Entities.Spell>("see invisibility", Spells.Instances.SeeInvisibility.ID)} as an arcane innate spell once per hour." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSense(Guid.Parse("1524695a-b3df-4c04-ae8a-1ff38580717d"), Senses.Instances.LowLightVision.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Automaton.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("762ecd36-04fb-4cc1-b53c-42e3908395b1"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
