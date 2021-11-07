using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RecognizeSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("33686b67-1a93-452d-9d68-1706b8b4ddc7");

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
            yield return new TextBlock { Id = Guid.Parse("77d6dd56-f9b8-4cfc-99d6-ecf7850f567d"), Type = TextBlockType.Text, Text = "If you are trained in the appropriate skill for the spell’s tradition and it’s a common spell of 2nd level or lower, you automatically identify it (you still roll to attempt to get a critical success, but can’t get a worse result than success). The highest level of spell you automatically identify increases to 4 if you’re an expert, 6 if you’re a master, and 10 if you’re legendary. The GM rolls a secret Arcana, Nature, Occultism, or Religion check, whichever corresponds to the tradition of the spell being cast. If you’re not trained in the skill, you can’t get a result better than failure." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("b275fe2f-3f22-4860-897b-8673cb7ce7d6"), or => 
            {
                or.HaveSpecificSkillProficiency(Guid.Parse("d3c69fbc-e096-4995-ae5d-eb0d95e48406"), Proficiencies.Instances.Trained.ID, Skills.Instances.Arcana.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("87b0f41b-c3ed-4124-adb2-3ef7e86b104c"), Proficiencies.Instances.Trained.ID, Skills.Instances.Nature.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("f4b87276-612e-4edf-bee3-7fc3c342754e"), Proficiencies.Instances.Trained.ID, Skills.Instances.Occultism.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("868b05f6-c8c6-40f8-af61-d98edf36146f"), Proficiencies.Instances.Trained.ID, Skills.Instances.Religion.ID);
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
                Id = Guid.Parse("3598debe-9bf7-4691-922a-76acb67aecec"),
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
                Id = Guid.Parse("f248f9a2-aa06-4706-bce2-dee1d2ab1837"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
