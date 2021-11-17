using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances
{
    public class BorrowAnArcaneSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("27253089-a4aa-4fbf-b9d9-927bfddd7d7c");

        protected override SkillAction GetSkillAction()
        {
            return new SkillAction
            {
                Id = ID,
                Name = "Borrow an Arcane Spell",
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                RequiredProficiencyId = Proficiencies.Instances.Trained.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("3e83be2c-e571-4178-963a-0d3a0904b86f"), Type = TextBlockType.Text, Text = "If you�re an arcane spellcaster who prepares from a spellbook, you can attempt to prepare a spell from someone else�s spellbook. The GM sets the DC for the check based on the spell�s level and rarity; it�s typically a bit easier than Learning the Spell." };
        }

        protected override IEnumerable<Guid> GetApplicableSkills()
        {
            yield return Skills.Instances.Arcana.ID;
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Concentrate.ID;
            yield return Traits.Instances.Exploration.ID;
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("2af49cc7-db64-49c3-9679-91bbe2878865"),
                Success = "You prepare the borrowed spell as part of your normal spell preparation.",
                Failure = "You fail to prepare the spell, but the spell slot remains available for you to prepare a different spell. You can�t try to prepare this spell until the next time you prepare spells.",
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
                Id = Guid.Parse("8b4f667d-7099-4468-9a30-d72c7916ae14"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 241
            };
        }
    }
}
