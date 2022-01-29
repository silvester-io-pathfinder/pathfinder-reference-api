using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances
{
    public class Sneak : Template
    {
        public static readonly Guid ID = Guid.Parse("fe746a84-061a-47aa-ac3b-7e60485d1a7e");

        protected override SkillAction GetSkillAction()
        {
            return new SkillAction
            {
                Id = ID,
                Name = "Sneak",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                RequiredProficiencyId = Proficiencies.Instances.Untrained.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("c82f1b04-9e65-4bc7-adc1-7c2686545d2b"), Type = TextBlockType.Text, Text = "You can attempt to move to another place while becoming or staying undetected. Stride up to half your Speed. (You can use Sneak while Burrowing, Climbing, Flying, or Swimming instead of Striding if you have the corresponding movement type; you must move at half that Speed.)" };
            yield return new TextBlock { Id = Guid.Parse("d214e5c1-40b7-422c-b72c-3958e59dca5e"), Type = TextBlockType.Text, Text = "If you're undetected by a creature and it's impossible for that creature to observe you (for a typical creature, this includes when you're invisible, the observer is blinded, or you're in darkness and the creature can't see in darkness), for any critical failure you roll on a check to Sneak, you get a failure instead. You also continue to be undetected if you lose cover or greater cover against or are no longer concealed from such a creature." };
            yield return new TextBlock { Id = Guid.Parse("752a96b2-ae9b-4449-8c87-48ef9db006c0"), Type = TextBlockType.Text, Text = "At the end of your movement, the GM rolls your Stealth check in secret and compares the result to the Perception DC of each creature you were hidden from or undetected by at the start of your movement. If you have cover or greater cover from the creature throughout your Stride, you gain the +2 circumstance bonus from cover (or +4 from greater cover) to your Stealth check. Because you're moving, the bonus increase from Taking Cover doesn't apply. You don't get to roll against a creature if, at the end of your movement, you neither are concealed from it nor have cover or greater cover against it. You automatically become observed by such a creature." };
        }

        protected override IEnumerable<Guid> GetApplicableSkills()
        {
            yield return Skills.Instances.Stealth.ID;
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Move.ID;
            yield return Traits.Instances.Secret.ID;
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("67f35b18-c20a-4b0f-b5bd-a55bdc86e8c0"),
                CriticalSuccess = "",
                Success = "you're undetected by the creature during your movement and remain undetected by the creature at the end of it. You become observed as soon as you do anything other than Hide, Sneak, or Step. If you attempt to Strike a creature, the creature remains flat-footed against that attack, and you then become observed. If you do anything else, you become observed just before you act unless the GM determines otherwise. The GM might allow you to perform a particularly unobtrusive action without being noticed, possibly requiring another Stealth check. If you speak or make a deliberate loud noise, you become hidden instead of undetected. If a creature uses Seek and you become hidden to it as a result, you must Sneak if you want to become undetected by that creature again.",
                Failure = "A telltale sound or other sign gives your position away, though you still remain unseen. you're hidden from the creature throughout your movement and remain so.",
                CriticalFailure = "you're spotted! you're observed by the creature throughout your movement and remain so. If you're invisible and were hidden from the creature, instead of being observed you're hidden throughout your movement and remain so."
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
                Id = Guid.Parse("d1bd1ca5-a14f-4d5d-9add-942fcd5d0136"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 252
            };
        }
    }
}
