using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class JustTheThing : Template
    {
        public static readonly Guid ID = Guid.Parse("4e1f7745-e3eb-4103-8b6d-ce47ad44d0f3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Just the Thing!",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per hour"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0eea209c-2592-4836-af1c-63897d863be8"), Type = TextBlockType.Text, Text = "Need to balance on a razor's edge, force open an iron door, or persuade a dragon to negotiate? Never fear! No matter the situation, you always have just the thing. You attempt a skill action that takes 1 minute or less to complete, using the same number of actions or amount of time as normal. However, as you take the action, describe a device you pull out and use to accomplish the skill. The specifics of how you accomplish this are up to you, but they should fit the challenge at hand. For instance, you might use gravitic stabilizers to balance on the razor's edge, a force battering ram gizmo to open the iron door, or a device that produces an aroma with the ability to pacify wyrms to persuade the dragon. Using an invention in this way lets you alter how you calculate the skill check used in the action. Instead of the normal skill modifier associated with that skill action, you use your Crafting modifier." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a083f0f0-e615-4e4d-892e-e064642907d1"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
