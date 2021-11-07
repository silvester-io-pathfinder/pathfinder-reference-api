using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SpellbookProdigy : Template
    {
        public static readonly Guid ID = Guid.Parse("d942fe08-5bff-4bf7-a413-7c12f3f18a7c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Spellbook Prodigy",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d3e6a8cb-b668-49cc-97ff-6698676e2b33"), Type = TextBlockType.Text, Text = "You are particularly adept at learning spells to add to your spellbook. You can (action: Learn a Spell) in half the time it normally takes. Further, when you roll a critical failure on your check to (action: Learn a Spell), you get a failure instead. When you roll a failure, you can try again after 1 week." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("13df33d8-2df0-4474-9f72-278927b3a113"), Proficiencies.Instances.Trained.ID, Skills.Instances.Arcana.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("41935d75-c79e-4f11-98d7-e1a9e8028175"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
