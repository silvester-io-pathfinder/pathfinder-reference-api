using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RopeMastery : Template
    {
        public static readonly Guid ID = Guid.Parse("190a2709-914c-41e3-b572-0ba2f8699ac4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Rope Mastery",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6a545ed5-3987-4553-84be-8f53c921dacf"), Type = TextBlockType.Text, Text = "Ropes are your tool of choice, and you deploy them in versatile ways. When (action: Climbing | Climb) a rope, you move 5 more feet on a success and 10 more feet on a critical success, to a maximum of your Speed. This additional movement stacks with the effects of (feat: Quick Climb)." };
            yield return new TextBlock { Id = Guid.Parse("a1d9c151-63bb-4515-b5d6-0ca4b0373043"), Type = TextBlockType.Text, Text = "In addition, you can use a rope to hamper your foes. When holding a rope, you can attempt an Athletics check to (action: Disarm), (action: Grapple), or (action: Trip) a creature up to 10 feet away instead of only adjacent creatures. If you critically fail such a check while holding a rope, you can drop the rope to take the effects of a failure instead of a critical failure." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("32840e82-5c99-48b0-ad7f-d3d04edd5b59"), Proficiencies.Instances.Expert.ID, Skills.Instances.Athletics.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("17eee78c-82ea-46d0-9655-3ebad0840573"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
