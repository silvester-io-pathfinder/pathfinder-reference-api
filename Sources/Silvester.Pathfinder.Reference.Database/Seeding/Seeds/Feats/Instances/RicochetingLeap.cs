using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RicochetingLeap : Template
    {
        public static readonly Guid ID = Guid.Parse("3ce22bc4-4eb9-418d-9998-186e2cdae39f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ricocheting Leap",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6e4f7649-0ae3-467c-99d8-f4f87e143b1c"), Type = TextBlockType.Text, Text = "You quickly use your momentum to topple and spring off of foes. You can use (feat: Wall Jump) to make additional jumps off of creatures larger than you as if they were walls. Once per turn when you make an additional jump off of a creature in this way, you can also attempt to (action: Shove) or (action: Trip) that creature as a free action." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("59626f6d-37a8-4043-b769-c18b7b0af17a"), Proficiencies.Instances.Master.ID, Skills.Instances.Athletics.ID);
            builder.HaveSpecificFeat(Guid.Parse("42ae4998-cada-476e-8316-2472ab808e11"), Feats.Instances.WallJump.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bd4c298f-b7f3-4e3a-8012-f56901f57f6c"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
