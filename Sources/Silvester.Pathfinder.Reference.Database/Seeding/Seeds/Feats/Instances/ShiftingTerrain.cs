using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShiftingTerrain : Template
    {
        public static readonly Guid ID = Guid.Parse("c5a10d1e-7fbf-46ef-b46d-c52268ae4ab7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shifting Terrain",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6fb4891d-7367-4ca6-8c51-a791057e9bb2"), Type = TextBlockType.Text, Text = "You slam your fist into the ground or twirl your arms about to cause the terrain around you to shift and ripple, potentially throwing others off balance. Each creature within your area of difficult terrain from (feat: Rough Terrain Stance) must attempt a Reflex saving throw against your spell DC with the following effects. After you use this action, you can’t use it again for 1d4 rounds." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("b171d388-2217-4814-88f5-10bb3d1ded15"), Feats.Instances.RoughtTerrainStance.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("f19291f5-e262-447e-a8b2-a452e4896567"), Proficiencies.Instances.Master.ID, Skills.Instances.Nature.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("47b8fea1-0af9-4901-ae74-18e80669169d"),
                CriticalSuccess = "The creature is unaffected.",
                Success = "The creature is clumsy 1 for 1 round.",
                Failure = "The creature is clumsy 2 for 1 round.",
                CriticalFailure = "The creature is clumsy 2 for 1 round and falls prone.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8dc6b523-4e33-4554-bc20-4abab870ad19"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
