using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WallJump : Template
    {
        public static readonly Guid ID = Guid.Parse("ffda31bc-926d-4d7e-96ab-46af20d61fcc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Wall Jump",
                Level = 7,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e8110c50-b277-446f-84c1-6a1e71f107b2"), Type = TextBlockType.Text, Text = "You can use your momentum from a jump to propel yourself off a wall. If you’re adjacent to a wall at the end of a jump (whether performing a (action: High Jump), (action: Long Jump), or (action: Leap)), you don’t fall as long as your next action is another jump. Furthermore, since your previous jump gives you momentum, you can use (action: High Jump) or (action: Long Jump) as a single action, but you don’t get to (action: Stride) as part of the activity." };
            yield return new TextBlock { Id = Guid.Parse("6edec55d-a140-442a-bc89-513dad38b403"), Type = TextBlockType.Text, Text = "You can use Wall Jump only once in a turn, unless you’re legendary in Athletics, in which case you can use Wall Jump as many times as you can use consecutive jump actions in that turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("77060f32-99be-48e5-ab05-6a842faf88b7"), Proficiencies.Instances.Master.ID, Skills.Instances.Athletics.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9135c75a-1235-488f-bc18-1dca4c164d9e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
