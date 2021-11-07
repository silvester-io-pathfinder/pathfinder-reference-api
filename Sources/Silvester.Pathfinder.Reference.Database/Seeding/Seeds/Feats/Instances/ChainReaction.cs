using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ChainReaction : Template
    {
        public static readonly Guid ID = Guid.Parse("eb006c4a-073a-4517-89f9-db4f5d080633");

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
            yield return new TextBlock { Id = Guid.Parse("a273769b-8533-4259-a55e-93c876ca58ce"), Type = TextBlockType.Text, Text = "You fire your gun once, creating a devastating and unpredictable chain of events; perhaps your bullet strikes exactly the right spot on a water tower, causing it to flood and incite a stampede of horses which knock over a lantern that sets a city on fire. Whatever the exact chain reaction, and no matter how improbable, the indiscriminate catastrophe creates significant challenges for your enemies across a wide area while leaving everyone else alone." };
            yield return new TextBlock { Id = Guid.Parse("08a5a33a-186b-4409-95c8-b9f1b5d3f619"), Type = TextBlockType.Text, Text = "Make a (action: Strike) with a ranged weapon, and if you hit, you can make another (action: Strike) at a target within 30 feet of the first target. If you hit the second target, attempt to (action: Strike) a third target within 30 feet of the second target, and so on, continuing until you miss a target. You can cease the chain at any point; otherwise, it ends when you first miss an attack. However, you can’t target the same creature more than once; each time you move to a new target, it must be a target you haven’t made a (action: Strike) against yet during this particular use of Chain Reaction." };
            yield return new TextBlock { Id = Guid.Parse("1fd3cd1f-a9b4-4eed-bf8a-3992e291d6f7"), Type = TextBlockType.Text, Text = "This damage is caused by some improbable set of events that injures one target after another, rather than from actually making several shots. Perhaps you shot at a tree branch that then fell on the targets, or one target’s scream caused another to accidentally set off their gun and shoot themselves in the foot. This means that only the first target suffers any special effects tied to the bullet (if it was magical ammunition, for example), but each target you hit still takes the same damage dealt by your (action: Strike). Normally, all damage is of the same damage type as the initial bullet. However, the GM might choose to change the damage type based on their description of the chain reaction. For example, if one target was burned by fire, that target might take fire damage instead of physical damage." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("becf2ab5-42d9-44eb-8f71-063855c7719f"), Feats.Instances.UnexpectedSharpshooterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5764e748-f694-4203-b406-633ef577d71a"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
