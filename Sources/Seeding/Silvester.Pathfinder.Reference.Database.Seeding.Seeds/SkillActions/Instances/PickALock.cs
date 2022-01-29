using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances
{
    public class PickALock : Template
    {
        public static readonly Guid ID = Guid.Parse("94ae2e5b-5f8c-4d2e-b8ce-0ca4bce05eae");

        protected override SkillAction GetSkillAction()
        {
            return new SkillAction
            {
                Id = ID,
                Name = "Pick a Lock",
                Requirements = "you're holding or wearing thieves' tools (page 291).",
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                RequiredProficiencyId = Proficiencies.Instances.Trained.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("c62762e7-1258-4186-8d43-36bc13a15e40"), Type = TextBlockType.Text, Text = "Opening a lock without a key is very similar to Disabling a Device, but the DC of the check is determined by the complexity and construction of the lock you are attempting to pick (locks and their DCs are found on page 290). Locks of higher qualities might require multiple successes to unlock, since otherwise even an unskilled burglar could easily crack the lock by attempting the check until they rolled a natural 20. If you lack the proper tools, the GM might let you used improvised picks, which are treated as shoddy tools, depending on the specifics of the lock." };
        }

        protected override IEnumerable<Guid> GetApplicableSkills()
        {
            yield return Skills.Instances.Thievery.ID;
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Manipulate.ID;
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("0d015328-1503-4342-98b8-dc8b5537f44c"),
                CriticalSuccess = "You unlock the lock, or you achieve two successes toward opening a complex lock. You leave no trace of your tampering.",
                Success = "You open the lock, or you achieve one success toward opening a complex lock.",
                CriticalFailure = "You break your tools. Fixing them requires using Crafting to Repair them or else swapping in replacement picks (costing 3 sp, or 3 gp for infiltrator thieves' tools)."
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
                Id = Guid.Parse("8153b950-0076-498a-974e-68e19b2aaa36"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 253
            };
        }
    }
}
