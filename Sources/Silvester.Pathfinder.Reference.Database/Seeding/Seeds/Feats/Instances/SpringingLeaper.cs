using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SpringingLeaper : Template
    {
        public static readonly Guid ID = Guid.Parse("054db908-c830-477d-9906-bf7216d54749");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Springing Leaper",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9b771e26-0593-4e51-8972-3120bf10a079"), Type = TextBlockType.Text, Text = "Your powerful legs allow you to make sudden and dramatic leaps. You can (action: Leap) as a 2-action activity to double the distance you can (action: Leap) vertically, or (action: Leap) as a 3-action activity to triple the distance you can (action: Leap) vertically. You don&#39;t automatically fail (action: Long Jumps | Long Jump) for jumping in a different direction than your (action: Stride)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("0e49919e-b64a-4a5a-aa78-198613f81861"), Proficiencies.Instances.Expert.ID, Skills.Instances.Athletics.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0a62cf60-3e9f-4680-b2c9-ba48bcb2ca01"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
