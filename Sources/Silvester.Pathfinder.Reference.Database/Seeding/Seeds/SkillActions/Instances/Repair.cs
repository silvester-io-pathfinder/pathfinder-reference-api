using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances
{
    public class Repair : Template
    {
        public static readonly Guid ID = Guid.Parse("0d44dfc4-e7ce-4a41-b1e2-cf5550e8adb3");

        protected override SkillAction GetSkillAction()
        {
            return new SkillAction
            {
                Id = ID,
                Name = "Repair",
                Requirements = "You are holding or wearing a repair kit (page 291).",
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                RequiredProficiencyId = Proficiencies.Instances.Untrained.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("b3cf6344-dc2e-43d3-b816-e9e52b60421b"), Type = TextBlockType.Text, Text = "You spend 10 minutes attempting to fix a damaged item, placing the item on a stable surface and using the repair kit with both hands. The GM sets the DC, but it�s usually about the same DC to Repair a given item as it is to Craft it in the first place. You can�t Repair a destroyed item." };
        }

        protected override IEnumerable<Guid> GetApplicableSkills()
        {
            yield return Skills.Instances.Crafting.ID;
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Exploration.ID;
            yield return Traits.Instances.Manipulate.ID;
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("e3c4a866-7cf5-49af-be94-64981d21f7a9"),
                CriticalSuccess = "You restore 10 Hit Points to the item, plus an additional 10 Hit Points per proficiency rank you have in Crafting (a total of 20 HP if you�re trained, 30 HP if you�re an expert, 40 HP if you�re a master, or 50 HP if you�re legendary).",
                Success = "You restore 5 Hit Points to the item, plus an additional 5 per proficiency rank you have in Crafting (for a total of 10 HP if you are trained, 15 HP if you�re an expert, 20 HP if you�re a master, or 25 HP if you�re legendary).",
                CriticalFailure = "You deal 2d6 damage to the item. Apply the item�s Hardness to this damage."
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
                Id = Guid.Parse("ef417bbe-ba83-4d07-8804-8b611a5c8128"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 243
            };
        }
    }
}
