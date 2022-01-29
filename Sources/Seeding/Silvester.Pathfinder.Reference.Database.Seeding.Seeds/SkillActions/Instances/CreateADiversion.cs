using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances
{
    public class CreateADiversion : Template
    {
        public static readonly Guid ID = Guid.Parse("dc166b4c-21e4-4f0a-93f6-d8f9f37b9b34");

        protected override SkillAction GetSkillAction()
        {
            return new SkillAction
            {
                Id = ID,
                Name = "Create a Diversion",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                RequiredProficiencyId = Proficiencies.Instances.Untrained.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("234862e0-5de5-47f7-882d-2a882925797e"), Type = TextBlockType.Text, Text = "With a gesture, a trick, or some distracting words, you can create a diversion that draws creatures' attention elsewhere. If you use a gesture or trick, this action gains the manipulate trait. If you use distracting words, it gains the auditory and linguistic traits." };
            yield return new TextBlock { Id = Guid.Parse("e1f9661b-386e-46cf-a0aa-b8c397f7ee5a"), Type = TextBlockType.Text, Text = "Attempt a single Deception check and compare it to the Perception DCs of the creatures whose attention you're trying to divert. Whether or not you succeed, creatures you attempt to divert gain a +4 circumstance bonus to their Perception DCs against your attempts to Create a Diversion for 1 minute." };
        }

        protected override IEnumerable<Guid> GetApplicableSkills()
        {
            yield return Skills.Instances.Deception.ID;
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Mental.ID;
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("15ffc537-10d8-48c4-a2c0-588b97eec2e0"),
                Success = "You become hidden to each creature whose Perception DC is less than or equal to your result. (The hidden condition allows you to Sneak away, as described on page 252.) This lasts until the end of your turn or until you do anything except Step or use the Hide or the Sneak action of the Stealth skill (pages 251 and 252). If you Strike a creature, the creature remains flat-footed against that attack, and you then become observed. If you do anything else, you become observed just before you act unless the GM determines otherwise.",
                Failure = "You don't divert the attention of any creatures whose Perception DC exceeds your result, and those creatures are aware you were trying to trick them.",
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
                Id = Guid.Parse("b7a7b399-e597-4171-91c1-ab8b569d5543"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 245
            };
        }
    }
}
