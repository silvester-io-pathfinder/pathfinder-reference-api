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
    public class OneInchPunch : Template
    {
        public static readonly Guid ID = Guid.Parse("93cd28a1-3409-43f4-bbf5-909fee8d3e2a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "One-Inch Punch",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9bae490c-0042-48dd-83e4-85686aabcd9b"), Type = TextBlockType.Text, Text = $"You put all your force into a single mighty, carefully controlled blow. Make an unarmed {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}. If you spend two actions and this {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} hits, you deal an extra die of weapon damage. You can instead spend 3 actions to perform an even more powerful attack, dealing a second additional die of weapon damage on a hit." };
            yield return new TextBlock { Id = Guid.Parse("7a289189-6b0a-4f13-a8d5-e1aab7855003"), Type = TextBlockType.Text, Text = $"If you're at least 10th level, the number of additional dice you add from this feat doubles, for a total of 2 additional dice if you spend 2 actions or 4 additional dice if you spend 3 actions. If you're at least 18th level, the number of additional dice you add from this feat triples, for a total of 3 additional dice if you spend 2 actions or 6 additional dice if you spend 3 actions." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificClassFeature(Guid.Parse("1bcee3cb-5a09-4883-bc5e-dbf334301c98"), ClassFeatures.Monks.ExpertStrikes.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Monk.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("56bb2705-bcab-4a47-ab50-c0502a9f9813"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
