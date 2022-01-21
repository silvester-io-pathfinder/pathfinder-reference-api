using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances
{
    public class Impersonate : Template
    {
        public static readonly Guid ID = Guid.Parse("0e820b35-0150-4a37-bca1-df374d15c354");

        protected override SkillAction GetSkillAction()
        {
            return new SkillAction
            {
                Id = ID,
                Name = "Impersonate",
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                RequiredProficiencyId = Proficiencies.Instances.Untrained.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("238f53c0-94e8-4739-832f-fcefcb023773"), Type = TextBlockType.Text, Text = "You create a disguise to pass yourself off as someone or something you are not. Assembling a convincing disguise takes 10 minutes and requires a disguise kit (found on page 290), but a simpler, quicker disguise might do the job if you�re not trying to imitate a specific individual, at the GM�s discretion." };
            yield return new TextBlock { Id = Guid.Parse("4024d77f-84ac-468d-8ff1-cee51ea67e09"), Type = TextBlockType.Text, Text = "In most cases, creatures have a chance to detect your deception only if they use the Seek action to attempt Perception checks against your Deception DC. If you attempt to directly interact with someone while disguised, the GM rolls a secret Deception check for you against that creature�s Perception DC instead. If you�re disguised as a specific individual, the GM might give creatures you interact with a circumstance bonus based on how well they know the person you�re imitating, or the GM might roll a secret Deception check even if you aren�t directly interacting with others." };
        }

        protected override IEnumerable<Guid> GetApplicableSkills()
        {
            yield return Skills.Instances.Deception.ID;
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Concentrate.ID;
            yield return Traits.Instances.Exploration.ID;
            yield return Traits.Instances.Manipulate.ID;
            yield return Traits.Instances.Secret.ID;
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("3f64c1bf-41a9-41f2-a684-f3770970ffd7"),
                Success = "You trick the creature into thinking you�re the person you�re disguised as. You might have to attempt a new check if your behavior changes.",
                Failure = "The creature can tell you�re not who you claim to be.",
                CriticalFailure = "The creature can tell you�re not who you claim to be, and it recognizes you if it would know you without a disguise."
            };
        }

        protected override IEnumerable<Guid> GetRequiredPlayModes()
        {
            yield return PlayModes.Instances.Exploration.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d6526acb-deed-4788-9d73-9926ee92d9db"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 245
            };
        }
    }
}
