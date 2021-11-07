using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WildernessSpotter : Template
    {
        public static readonly Guid ID = Guid.Parse("f07cbe6e-f825-4bdd-ae20-23af22e5d5f8");

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
            yield return new TextBlock { Id = Guid.Parse("a19122aa-fea9-4785-9e0d-b505e249288a"), Type = TextBlockType.Text, Text = "Select one type of terrain from the following list: aquatic, arctic, desert, forest, mountain, plains, sky, swamp, or underground. You can use Survival in place of Perception to roll initiative when in the selected terrain in a natural location (not a structure) even if you weren’t tracking or otherwise using Survival before the encounter. You can also use Survival instead of Perception to notice traps in natural locations in the chosen terrain; if you find a snare in this way, you can also use Survival instead of Thievery to (action: Disable the Device | Disable a Device)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("00f46bdc-a12d-465f-b066-f161393540b1"), Proficiencies.Instances.Expert.ID, Skills.Instances.Survival.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8cc1d0e3-8b54-4eab-a366-d919c8ff4b85"),
                SourceId = Sources.Instances.FallOfPlaguestone.ID,
                Page = -1
            };
        }
    }
}
