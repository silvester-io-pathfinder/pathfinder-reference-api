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
    public class ChainReaction : Template
    {
        public static readonly Guid ID = Guid.Parse("eb703798-57c0-44dd-acf5-2cff8e677595");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Chain Reaction",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per 10 minutes"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("41f623b9-e814-4ff4-ba9a-5274a8108696"), Type = TextBlockType.Text, Text = $"You fire your gun once, creating a devastating and unpredictable chain of events; perhaps your bullet strikes exactly the right spot on a water tower, causing it to flood and incite a stampede of horses which knock over a lantern that sets a city on fire. Whatever the exact chain reaction, and no matter how improbable, the indiscriminate catastrophe creates significant challenges for your enemies across a wide area while leaving everyone else alone." };
            yield return new TextBlock { Id = Guid.Parse("9236d697-e609-44d9-8c8d-bab5bc343471"), Type = TextBlockType.Text, Text = $"Make a {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} with a ranged weapon, and if you hit, you can make another {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} at a target within 30 feet of the first target. If you hit the second target, attempt to {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} a third target within 30 feet of the second target, and so on, continuing until you miss a target. You can cease the chain at any point; otherwise, it ends when you first miss an attack. However, you can't target the same creature more than once; each time you move to a new target, it must be a target you haven't made a {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} against yet during this particular use of Chain Reaction." };
            yield return new TextBlock { Id = Guid.Parse("a63d9c2d-e647-4a30-bc09-57d43c80a7a2"), Type = TextBlockType.Text, Text = $"This damage is caused by some improbable set of events that injures one target after another, rather than from actually making several shots. Perhaps you shot at a tree branch that then fell on the targets, or one target's scream caused another to accidentally set off their gun and shoot themselves in the foot. This means that only the first target suffers any special effects tied to the bullet (if it was magical ammunition, for example), but each target you hit still takes the same damage dealt by your {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}. Normally, all damage is of the same damage type as the initial bullet. However, the GM might choose to change the damage type based on their description of the chain reaction. For example, if one target was burned by fire, that target might take fire damage instead of physical damage." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("ff872a69-729a-43c9-a54d-f47a5f70a73a"), Feats.Instances.UnexpectedSharpshooterDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("d467fa7c-a3b5-40f1-91df-3fdd51a26cb0"), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e5bc585c-2913-408e-baea-c2a716350aec"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
