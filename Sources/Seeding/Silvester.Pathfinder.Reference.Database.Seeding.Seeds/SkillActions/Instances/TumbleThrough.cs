using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances
{
    public class TumbleThrough : Template
    {
        public static readonly Guid ID = Guid.Parse("097462b2-63b6-4f1f-9510-cdac6e232e13");

        protected override SkillAction GetSkillAction()
        {
            return new SkillAction
            {
                Id = ID,
                Name = "Tumble Through",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                RequiredProficiencyId = Proficiencies.Instances.Untrained.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("7612e054-7c5b-4915-b477-cb76db132e18"), Type = TextBlockType.Text, Text = "You Stride up to your Speed. During this movement, you can try to move through the space of one enemy. Attempt an Acrobatics check against the enemy�s Reflex DC as soon as you try to enter its space. You can Tumble Through using Climb, Fly, Swim, or another action instead of Stride in the appropriate environment." };
        }

        protected override IEnumerable<Guid> GetApplicableSkills()
        {
            yield return Skills.Instances.Acrobatics.ID;
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Move.ID;
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("89f7b0e5-79c3-4f78-889d-a5c64f289e9d"),
                Success = "You move through the enemy�s space, treating the squares in its space as difficult terrain (every 5 feet costs 10 feet of movement). If you don�t have enough Speed to move all the way through its space, you get the same effect as a failure.",
                Failure = "Your movement ends, and you trigger reactions as if you had moved out of the square you started in.",
            };
        }

        protected override IEnumerable<Guid> GetRequiredPlayModes()
        {
            yield return PlayModes.Instances.Encounter.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("77286916-2de7-48ab-8675-1e2dbeac4dc5"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 240
            };
        }
    }
}
