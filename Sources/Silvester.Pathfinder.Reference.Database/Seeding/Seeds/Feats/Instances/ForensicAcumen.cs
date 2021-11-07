using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ForensicAcumen : Template
    {
        public static readonly Guid ID = Guid.Parse("bfef59d3-c271-4691-878a-619c9d0d600c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Forensic Acumen",
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
            yield return new TextBlock { Id = Guid.Parse("3a0efde8-6769-41ff-a1c7-5fd0eab41e70"), Type = TextBlockType.Text, Text = "You understand the principles of forensic medicine, making you better at examining a body to determine the cause of death or injury. You can perform a forensic examination on a body, as described under (action: Recall Knowledge | Recall Knowledge - Medicine) in the Medicine skill, in half the normal amount of time it would take (to a minimum of 5 minutes). If you succeed at your check, you can attempt an immediate check to (action: Recall Knowledge) to follow up on something you found, with a +2 circumstance bonus. This check is usually related to the cause of injury or death, such as a Crafting check to identify a poison or weapon that was used or an additional Medicine check to identify a specific disease. If you prefer, you can instead attempt to (action: Recall Knowledge) about the type of creature whose body you were examining, using the appropriate skill and gaining the same circumstance bonus." };
            yield return new TextBlock { Id = Guid.Parse("fba6b2bf-8771-4d8f-bf02-babc4185c136"), Type = TextBlockType.Text, Text = "The circumstance bonus increases to +3 if you have master proficiency in Medicine and +4 if you have legendary proficiency." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("6e20a84d-da7d-4158-813f-b15f662bf22a"), Proficiencies.Instances.Trained.ID, Skills.Instances.Medicine.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8078939d-d14e-4327-9b4b-f11d2b2cb79f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
