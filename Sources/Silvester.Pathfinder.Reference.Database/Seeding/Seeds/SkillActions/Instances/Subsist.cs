using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances
{
    public class Subsist : Template
    {
        public static readonly Guid ID = Guid.Parse("464200fa-390e-4298-a325-70f80c37da99");

        protected override SkillAction GetSkillAction()
        {
            return new SkillAction
            {
                Id = ID,
                Name = "Subsist",
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                RequiredProficiencyId = Proficiencies.Instances.Untrained.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("2af292ba-0a51-462e-9043-617e7ecf5861"), Type = TextBlockType.Text, Text = "If you need to provide food and shelter, you can use the Subsist downtime activity. This typically uses Society if you�re in a settlement or Survival if you�re in the wild." };
            yield return new TextBlock { Id = Guid.Parse("efa89d10-9daa-46aa-90e2-dace93eb78ef"), Type = TextBlockType.Text, Text = "You try to provide food and shelter for yourself, and possibly others as well, with a standard of living described on page 294. The GM determines the DC based on the nature of the place where you�re trying to Subsist. You might need a minimum proficiency rank to Subsist in particularly strange environments. Unlike most downtime activities, you can Subsist after 8 hours or less of exploration, but if you do, you take a �5 penalty." };
        }

        protected override IEnumerable<Guid> GetApplicableSkills()
        {
            yield return Skills.Instances.Society.ID;
            yield return Skills.Instances.Survival.ID;
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Downtime.ID;
        }

        protected override IEnumerable<Guid> GetRequiredPlayModes()
        {
            yield return PlayModes.Instances.Downtime.ID;
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("31440f52-b312-4677-8159-c5eb033c88b2"),
                CriticalSuccess = "You either provide a subsistence living for yourself and one additional creature, or you improve your own food and shelter, granting yourself a comfortable living.",
                Success = "You find enough food and shelter with basic protection from the elements to provide you a subsistence living.",
                Failure = "You�re exposed to the elements and don�t get enough food, becoming fatigued until you attain sufficient food and shelter.",
                CriticalFailure = "You attract trouble, eat something you shouldn�t, or otherwise worsen your situation. You take a �2 circumstance penalty to checks to Subsist for 1 week. You don�t find any food at all; if you don�t have any stored up, you�re in danger of starving or dying of thirst if you continue failing."
            };
        }

        protected override IEnumerable<SkillActionExample> GetExamples()
        {
            yield return new SkillActionExample { Id = Guid.Parse("8974fa31-495c-46d2-806b-d8872fda02a6"), ProficiencyId = Proficiencies.Instances.Untrained.ID, Description = "Lush forest with calm weather or large city with plentiful resources." };
            yield return new SkillActionExample { Id = Guid.Parse("ec9c5bf1-7f96-44f4-bb9e-6bdc2887d4b1"), ProficiencyId = Proficiencies.Instances.Trained.ID, Description = "Typical hillside or village." };
            yield return new SkillActionExample { Id = Guid.Parse("c858581e-3f1c-462f-98dd-01a4e8d00f24"), ProficiencyId = Proficiencies.Instances.Expert.ID, Description = "Typical mountains or insular hamlet." };
            yield return new SkillActionExample { Id = Guid.Parse("2702d043-1bb8-4268-9c2c-a851276e296c"), ProficiencyId = Proficiencies.Instances.Master.ID, Description = "Typical desert or city under siege." };
            yield return new SkillActionExample { Id = Guid.Parse("71cd3e48-98b2-48d0-8aa2-8391b8ca2c9d"), ProficiencyId = Proficiencies.Instances.Legendary.ID, Description = "Barren wasteland or city of undead." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6c88fc92-0e47-4b02-948a-aebfd4dbe112"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 240
            };
        }
    }
}
