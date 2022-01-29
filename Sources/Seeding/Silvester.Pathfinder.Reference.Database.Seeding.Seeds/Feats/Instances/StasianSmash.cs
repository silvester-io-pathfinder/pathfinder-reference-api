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
    public class StasianSmash : Template
    {
        public static readonly Guid ID = Guid.Parse("6388709e-4a4e-42b8-a2c2-28c353dcf062");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Stasian Smash",
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
            yield return new TextBlock { Id = Guid.Parse("a7f19dbe-acb2-4082-9905-4ab96cfe37d0"), Type = TextBlockType.Text, Text = $"~ Access: You are from Ustalav." };
            yield return new TextBlock { Id = Guid.Parse("22e274b7-20f5-44fa-8162-76062d2030a4"), Type = TextBlockType.Text, Text = $"You've modified your dynamo with Stasian coils, allowing you to make a powerful attack that crackles with electricity. Make a dynamo {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}. On a success, the {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} deals an additional 1d12 electricity damage to the target, as well as 1d4 electricity damage to up to two other foes within 10 feet as sparks leap across the gaps. If you critically fail your dynamo {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}, you take 1d12 electricity damage. This counts as two attacks when calculating your multiple attack penalty. At 18th level, the additional electricity damage to the target increases to 2d12, and the additional electricity damage to the other foes increases to 2d4. Reduce the operational time of your sterling dynamo by 1 hour." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("b6cbe493-160f-4248-acce-09c11089a815"), Feats.Instances.SterlingDynamoDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c48df380-0533-4c9d-8ca3-7a69132c323e"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
