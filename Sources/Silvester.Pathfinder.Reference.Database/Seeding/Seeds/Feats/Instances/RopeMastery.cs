using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RopeMastery : Template
    {
        public static readonly Guid ID = Guid.Parse("e61ad24d-7d4b-4059-80b9-706adcd204e5");

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
            yield return new TextBlock { Id = Guid.Parse("8a4b1195-689b-4fb4-969f-a518760c61aa"), Type = TextBlockType.Text, Text = "Ropes are your tool of choice, and you deploy them in versatile ways. When (action: Climbing | Climb) a rope, you move 5 more feet on a success and 10 more feet on a critical success, to a maximum of your Speed. This additional movement stacks with the effects of (feat: Quick Climb)." };
            yield return new TextBlock { Id = Guid.Parse("0d4223ff-1abd-4295-955d-681c3130e241"), Type = TextBlockType.Text, Text = "In addition, you can use a rope to hamper your foes. When holding a rope, you can attempt an Athletics check to (action: Disarm), (action: Grapple), or (action: Trip) a creature up to 10 feet away instead of only adjacent creatures. If you critically fail such a check while holding a rope, you can drop the rope to take the effects of a failure instead of a critical failure." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("ce672709-26ec-404e-b20e-b130f5f6952f"), Proficiencies.Instances.Expert.ID, Skills.Instances.Athletics.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5cf7a24d-2b4d-43ca-a5b2-adcc05262232"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
