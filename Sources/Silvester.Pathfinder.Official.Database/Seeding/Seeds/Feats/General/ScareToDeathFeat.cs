using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class ScareToDeathFeat : AbstractFeatTemplate
    {
        protected override string FeatType => "General";
        protected override string ActionType => "One Action";

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = Guid.Parse("045ae2b1-ef9d-44a3-898d-8feb0832b94c"),
                Name = "Scare to Death",
                Level = 15
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8a8dd86f-24fc-469c-b760-011217f25d3c"), Type = Utilities.Text.TextBlockType.Text, Text = "You can frighten foes so much, they might die. Attempt an Intimidation check against the Will DC of a living creature within 30 feet of you that you sense or observe and who can sense or observe you. If the target can’t hear you or doesn’t understand the language you are speaking, you take a –4 circumstance penalty. The creature is temporarily immune for 1 minute." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites(FeatSeeder seeder)
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("53cb716d-9671-4fe1-9c80-96d7dad779ca"), RequiredSkillId = seeder.GetSkill("Intimidation"), RequiredProficiencyId = seeder.GetProficiency("Legendary") };
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("a2a1dedd-eaa8-49bd-9189-7ce92039987e"),
                CriticalSuccess = "The target must succeed at a Fortitude save against your Intimidation DC or die. If the target succeeds at its save, it becomes frightened 2 and is fleeing for 1 round; it suffers no effect on a critical success.",
                Success = "The target becomes frightened 2.",
                Failure = "The target becomes frightened 1.",
                CriticalFailure = "The target is unaffected."
            };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "Death";
            yield return "Emotion";
            yield return "Fear";
            yield return "General";
            yield return "Incapacitation";
            yield return "Skill";
        }
    }
}
