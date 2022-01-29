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
    public class HealersHalo : Template
    {
        public static readonly Guid ID = Guid.Parse("ecd9af3b-25c4-4012-9f5c-e23167b97f70");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Healer's Halo",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You or allies within 30 feet recover Hit Points while your halo is active.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1abcb862-e629-4a6c-baa3-ca1a40fd1bd3"), Type = TextBlockType.Text, Text = $"Your halo can enhance positive energy. Creatures who have recovered Hit Points from a {ToMarkdownLink<Models.Entities.Trait>("positive", Traits.Instances.Positive.ID)} {ToMarkdownLink<Models.Entities.Trait>("healing", Traits.Instances.Healing.ID)} effect recover an additional 1d6 Hit Points. Creatures who benefit from this power become temporarily immune to its effect for the next 10 minutes." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("042c0564-2147-4929-b12f-15b97517aedc"), Feats.Instances.Halo.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Aasimar.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("645d59fc-ea6e-4553-8ec6-09aa88ff159f"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
