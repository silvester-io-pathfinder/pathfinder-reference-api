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
    public class ElasticMutagen : Template
    {
        public static readonly Guid ID = Guid.Parse("074fd147-419c-4395-a911-afeb75083fff");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Elastic Mutagen",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("85c8f6a6-c068-44f4-8988-daf07add3f1f"), Type = TextBlockType.Text, Text = $"You can cause your body to twist and flow like the quicksilver within your mutagens. Whenever you are under the effects of a quicksilver mutagen, you can stretch your legs and {ToMarkdownLink<Models.Entities.Action>("Step", Actions.Instances.Step.ID)} up to 10 feet, and you can squish and compress your body, allowing you to make it through tight spaces as if you were one size smaller, in addition to any effect from {ToMarkdownLink<Models.Entities.SkillAction>("Squeezing", SkillActions.Instances.Squeeze.ID)}." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("ac0d2bd7-2d19-46dd-a0ee-379c9af0eb38"), Traits.Instances.Alchemist.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ce7b4b93-46ba-452c-b414-93d67e7f33a5"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
