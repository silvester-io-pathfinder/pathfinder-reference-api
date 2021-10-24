using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances
{
    public class Balance : Template
    {
        public static readonly Guid ID = Guid.Parse("26347616-69cf-4314-9218-3b1103a6749f");

        protected override SkillAction GetSkillAction()
        {
            return new SkillAction
            {
                Id = ID,
                Name = "Balance",
                Requirements = "You are in a square that contains a narrow surface, uneven ground, or another similar feature.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                RequiredProficiencyId = Proficiencies.Instances.Untrained.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("0f2aec52-3806-4a72-a8e7-15c16d8c921d"), Type = TextBlockType.Text, Text = "You move across a narrow surface or uneven ground, attempting an Acrobatics check against its Balance DC. You are flat-footed while on a narrow surface or uneven ground." };
        }

        protected override IEnumerable<Guid> GetApplicableSkills()
        {
            yield return Skills.Instances.Acrobatics.ID;
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Move.ID;
        }

        protected override IEnumerable<Guid> GetRequiredPlayModes()
        {
            yield return PlayModes.Instances.Encounter.ID;
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("bf55b340-8cbe-44a6-a353-f24a5f08d9b8"),
                CriticalSuccess = "You move up to your Speed.",
                Success = "You move up to your Speed, treating it as difficult terrain (every 5 feet costs 10 feet of movement).",
                Failure = "You must remain stationary to keep your balance (wasting the action) or you fall. If you fall, your turn ends.",
                CriticalFailure = "You fall and your turn ends."
            };
        }

        protected override IEnumerable<SkillActionExample> GetExamples()
        {
            yield return new SkillActionExample { Id = Guid.Parse("398131fd-628c-44e3-91a2-3ade7806c20d"), ProficiencyId = Proficiencies.Instances.Untrained.ID, Description = "Tangled roots, uneven cobblestones." };
            yield return new SkillActionExample { Id = Guid.Parse("30ad8468-cbd0-425f-b9aa-2abd3629ce0f"), ProficiencyId = Proficiencies.Instances.Trained.ID, Description = "Wooden beam." };
            yield return new SkillActionExample { Id = Guid.Parse("bc0226a0-09d5-4f60-9531-4d42d10f488c"), ProficiencyId = Proficiencies.Instances.Expert.ID, Description = "Deep, loose gravel." };
            yield return new SkillActionExample { Id = Guid.Parse("bf231bb0-7d81-4ce4-a343-c937cd620061"), ProficiencyId = Proficiencies.Instances.Master.ID, Description = "Tightrope, smooth sheet of ice." };
            yield return new SkillActionExample { Id = Guid.Parse("80964419-c69f-4491-adf6-c4364fa547d4"), ProficiencyId = Proficiencies.Instances.Legendary.ID, Description = "Razor�s edge, chunks of floor falling in midair." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e06fdd07-e530-4c03-b462-cd67240ef537"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 240
            };
        }
    }
}
