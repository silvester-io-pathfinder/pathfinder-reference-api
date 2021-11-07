using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TerrainExpertise : Template
    {
        public static readonly Guid ID = Guid.Parse("e3d395f4-38a2-4bde-b8ce-0c264eb5185c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Terrain Expertise",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = true,
                Special = "You can select this feat more than once, choosing a different type of terrain each time.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("520bd4ad-4c96-457e-b51e-046e07f155e3"), Type = TextBlockType.Text, Text = "Your experience in navigating a certain type of terrain makes you supremely confident while doing so. You gain a +1 circumstance bonus to Survival checks in one of the following types of terrain, chosen when you select this feat: aquatic, arctic, desert, forest, mountain, plains, sky, swamp, or underground." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("2d68cd10-5d87-41aa-9897-4effe38922fd"), Proficiencies.Instances.Trained.ID, Skills.Instances.Survival.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3f9150a3-8d6d-4ed4-8101-0241f6e808a3"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
