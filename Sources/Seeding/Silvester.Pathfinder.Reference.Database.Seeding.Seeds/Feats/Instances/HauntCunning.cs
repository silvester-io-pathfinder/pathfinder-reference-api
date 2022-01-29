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
    public class HauntCunning : Template
    {
        public static readonly Guid ID = Guid.Parse("287229eb-6812-4c55-80b5-5bc6d71c2887");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Haunt Cunning",
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
            yield return new TextBlock { Id = Guid.Parse("5d75e9f0-c11f-4a62-bcd6-002016f4b7dc"), Type = TextBlockType.Text, Text = $"One of the most useful pieces of cunning knowledge is the ability to notice the emotional echo of a soul that passed on, leaving a haunt in its wake. Even when you aren't {ToMarkdownLink<Models.Entities.Activity>("Searching", Activities.Instances.Search.ID)} while in exploration mode, the GM rolls a secret check for you to notice haunts that usually require you to be {ToMarkdownLink<Models.Entities.Activity>("Searching", Activities.Instances.Search.ID)}." };
            yield return new TextBlock { Id = Guid.Parse("47c6b04b-823b-4299-9d27-dbd9c1988f61"), Type = TextBlockType.Text, Text = $"You can disable haunts that require master proficiency rank in a skill as long as you're at least trained in the skill. If you have master proficiency in the skill, you can disable haunts that require a proficiency rank of legendary instead." };
            yield return new TextBlock { Id = Guid.Parse("4610862e-d7d1-4bd7-b7a4-9c852fef7b8b"), Type = TextBlockType.Text, Text = $"While holding a lantern implement, you also gain a +1 circumstance bonus to Perception checks to find haunts, to AC against attacks made by haunts, and to saves against haunts. If you have the lantern implement's adept benefit, the circumstance bonus is +2." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5fcbc5a3-74cc-42e1-98d1-b1e2278f11f5"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
