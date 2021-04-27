using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class RecognizeSpellFeat : AbstractFeatTemplate
    {
        public static readonly Guid ID = Guid.Parse("30763d23-d261-4295-b636-f94bca378bec");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Recognize Spell",
                Level = 1,
                Trigger = "A creature within line of sight casts a spell that you don’t have prepared or in your spell repertoire, or a trap or similar object casts such a spell. You must be aware of the casting.",
                FeatTypeId = FeatTypes.Instances.General.ID,
                ActionTypeId = ActionTypes.Instances.Reaction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("aa2b2d06-a965-4e6a-ba72-099e3d2b4def"), Type = Utilities.Text.TextBlockType.Text, Text = "If you are trained in the appropriate skill for the spell’s tradition and it’s a common spell of 2nd level or lower, you automatically identify it (you still roll to attempt to get a critical success, but can’t get a worse result than success). The highest level of spell you automatically identify increases to 4 if you’re an expert, 6 if you’re a master, and 10 if you’re legendary. The GM rolls a secret Arcana, Nature, Occultism, or Religion check, whichever corresponds to the tradition of the spell being cast. If you’re not trained in the skill, you can’t get a result better than failure." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new OrPrerequisite
            {
                Id = Guid.Parse("60e48bf0-f1a9-4020-be4d-3bff9e62499b"),
                Choices =
                {
                    new SkillPrerequisite { Id = Guid.Parse("0d21ea88-7d57-4b4a-ae2f-137fc9a3cdb9"), RequiredSkillId = Skills.Instances.Arcana.ID, RequiredProficiencyId = Proficiencies.Instances.Trained.ID },
                    new SkillPrerequisite { Id = Guid.Parse("745a3458-4af6-40fd-8473-85b931080f08"), RequiredSkillId = Skills.Instances.Nature.ID, RequiredProficiencyId = Proficiencies.Instances.Trained.ID },
                    new SkillPrerequisite { Id = Guid.Parse("534558b4-37f0-4b30-bf0e-525eb52ee973"), RequiredSkillId = Skills.Instances.Occultism.ID, RequiredProficiencyId = Proficiencies.Instances.Trained.ID },
                    new SkillPrerequisite { Id = Guid.Parse("525699e1-c5e4-4677-8c3a-24d6be5f880e"), RequiredSkillId = Skills.Instances.Religion.ID, RequiredProficiencyId = Proficiencies.Instances.Trained.ID },
                }
            };
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("ab1082ab-df6b-4a9d-880f-7ab186891b2f"),
                CriticalSuccess = "You correctly recognize the spell and gain a +1 circumstance bonus to your saving throw or your AC against it.",
                Success = "You correctly recognize the spell.",
                Failure = "You fail to recognize the spell.",
                CriticalFailure = "You misidentify the spell as another spell entirely, of the GM’s choice."
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.General.ID;
            yield return Traits.Instances.Skill.ID;
        }
    }
}
