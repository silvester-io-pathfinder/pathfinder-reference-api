using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class JellyfishStance : Template
    {
        public static readonly Guid ID = Guid.Parse("4e210938-a243-44e6-8c43-3b8205d7ad0f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Jellyfish Stance",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b82c251b-cf41-42e3-aa7a-29428a69e5e1"), Type = TextBlockType.Text, Text = $"You relax your posture and loosen your joints, allowing yourself to move with incredible fluidity. You can make stinging lash attacks that deal 1d8 slashing damage. These attacks are in the brawling group, and have the {ToMarkdownLink<Models.Entities.Trait>("finesse", Traits.Instances.Finesse.ID)}, {ToMarkdownLink<Models.Entities.Trait>("nonlethal", Traits.Instances.Nonlethal.ID)}, {ToMarkdownLink<Models.Entities.Trait>("reach", Traits.Instances.Reach.ID)}, and {ToMarkdownLink<Models.Entities.Trait>("unarmed", Traits.Instances.Unarmed.ID)} traits." };
            yield return new TextBlock { Id = Guid.Parse("3bbbcf12-8a45-44bf-92e1-e764e446c465"), Type = TextBlockType.Text, Text = $"While in Jellyfish Stance, you gain a +2 circumstance bonus to Reflex saves and on checks to {ToMarkdownLink<Models.Entities.Action>("Escape", Actions.Instances.Escape.ID)} and {ToMarkdownLink<Models.Entities.SkillAction>("Squeeze", SkillActions.Instances.Squeeze.ID)}." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("aaf6664a-24e1-414e-83ed-9a2b79e3feb3"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
