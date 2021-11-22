using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WildernessSpotter : Template
    {
        public static readonly Guid ID = Guid.Parse("4ed6bf37-7e4f-4dc9-acd5-6b2702f01706");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Wilderness Spotter",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = true,
                Special = "You can select this feat more than once. Each time you select it, the feat applies to a new type of terrain.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2683013f-d1f1-4d65-8b6e-b505e1fff31d"), Type = TextBlockType.Text, Text = "Select one type of terrain from the following list: aquatic, arctic, desert, forest, mountain, plains, sky, swamp, or underground. You can use Survival in place of Perception to roll initiative when in the selected terrain in a natural location (not a structure) even if you weren't tracking or otherwise using Survival before the encounter. You can also use Survival instead of Perception to notice traps in natural locations in the chosen terrain; if you find a snare in this way, you can also use Survival instead of Thievery to (action: Disable the Device | Disable a Device)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("2091da97-a062-48f7-8024-c79128656b01"), Proficiencies.Instances.Expert.ID, Skills.Instances.Survival.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3098d32d-bb56-4966-bb9a-86bf1bbb2851"),
                SourceId = Sources.Instances.FallOfPlaguestone.ID,
                Page = -1
            };
        }
    }
}
