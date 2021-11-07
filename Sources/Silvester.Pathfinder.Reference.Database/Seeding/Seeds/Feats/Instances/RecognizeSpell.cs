using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RecognizeSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("9274a3ec-9a49-4a6b-bb1e-bd9334ca7f6d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Recognize Spell",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "A creature within line of sight casts a spell that you don't have prepared or in your spell repertoire, or a trap or similar object casts such a spell. You must be aware of the casting.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("68ec9568-ab4c-44eb-b6bf-ee7d57ae3e89"), Type = TextBlockType.Text, Text = "If you are trained in the appropriate skill for the spell’s tradition and it’s a common spell of 2nd level or lower, you automatically identify it (you still roll to attempt to get a critical success, but can’t get a worse result than success). The highest level of spell you automatically identify increases to 4 if you’re an expert, 6 if you’re a master, and 10 if you’re legendary. The GM rolls a secret Arcana, Nature, Occultism, or Religion check, whichever corresponds to the tradition of the spell being cast. If you’re not trained in the skill, you can’t get a result better than failure." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("e30f9294-e999-4fa1-b8f3-6bac7e3db403"), or => 
            {
                or.HaveSpecificSkillProficiency(Guid.Parse("efc3a742-a9d6-474b-b8d3-f6188b50443d"), Proficiencies.Instances.Trained.ID, Skills.Instances.Arcana.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("bb236b55-d2a9-40c1-9b84-1e99d3ed913c"), Proficiencies.Instances.Trained.ID, Skills.Instances.Nature.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("9cce6d0d-4c93-4077-b320-3d4a5da477d9"), Proficiencies.Instances.Trained.ID, Skills.Instances.Occultism.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("fd5feecb-14c7-4665-a196-03f86dd1ea88"), Proficiencies.Instances.Trained.ID, Skills.Instances.Religion.ID);
            });
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("2e4e8958-321c-4d60-a7a4-579b6310fef1"),
                CriticalSuccess = "You correctly recognize the spell and gain a +1 circumstance bonus to your saving throw or your AC against it.",
                Success = "You correctly recognize the spell.",
                Failure = "You fail to recognize the spell.",
                CriticalFailure = "You misidentify the spell as another spell entirely, of the GM’s choice.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d2015b5e-1e34-48d2-b1bc-dc2e2fd7b611"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
