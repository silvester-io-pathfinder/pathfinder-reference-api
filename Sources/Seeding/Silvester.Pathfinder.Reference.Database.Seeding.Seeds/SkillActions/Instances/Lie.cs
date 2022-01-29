using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances
{
    public class Lie : Template
    {
        public static readonly Guid ID = Guid.Parse("bae75a16-06a0-486e-9b35-2f5ce8bc6edb");

        protected override SkillAction GetSkillAction()
        {
            return new SkillAction
            {
                Id = ID,
                Name = "Lie",
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                RequiredProficiencyId = Proficiencies.Instances.Untrained.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("b8dd4246-eb7c-4df1-ab5c-e763a4da23e0"), Type = TextBlockType.Text, Text = "You try to fool someone with an untruth. Doing so takes at least 1 round, or longer if the lie is elaborate. You roll a single Deception check and compare it against the Perception DC of every creature you are trying to fool. The GM might give them a circumstance bonus based on the situation and the nature of the lie you are trying to tell. Elaborate or highly unbelievable lies are much harder to get a creature to believe than simpler and more believable lies, and some lies are so big that it's impossible to get anyone to believe them." };
            yield return new TextBlock { Id = Guid.Parse("5d894bc7-f119-47fd-b2c3-d833b11d0ab1"), Type = TextBlockType.Text, Text = "At the GM's discretion, if a creature initially believes your lie, it might attempt a Perception check later to Sense Motive against your Deception DC to realize it's a lie. This usually happens if the creature discovers enough evidence to counter your statements." };
        }

        protected override IEnumerable<Guid> GetApplicableSkills()
        {
            yield return Skills.Instances.Deception.ID;
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Auditory.ID;
            yield return Traits.Instances.Concentrate.ID;
            yield return Traits.Instances.Linguistic.ID;
            yield return Traits.Instances.Mental.ID;
            yield return Traits.Instances.Secret.ID;
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("54f4209d-0bfd-430b-b216-9fd5d57f46b5"),
                Success = "The target believes your lie.",
                Failure = "The target doesn't believe your lie and gains a +4 circumstance bonus against your attempts to Lie for the duration of your conversation. The target is also more likely to be suspicious of you in the future.",
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
                Id = Guid.Parse("f2123bdf-b404-42d2-99c7-554d13917914"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 246
            };
        }
    }
}
