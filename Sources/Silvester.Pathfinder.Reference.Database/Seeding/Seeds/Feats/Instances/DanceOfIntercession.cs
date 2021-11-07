using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DanceOfIntercession : Template
    {
        public static readonly Guid ID = Guid.Parse("207678c4-59df-4824-ae82-107965fac803");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dance of Intercession",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "three times a day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("caecf1ab-b66e-4b34-9956-012cb4735461"), Type = TextBlockType.Text, Text = "You either performed in or stood witness to the dance used to invoke the Celestial Dragon and can harness a sliver of their power. You (action: Stride) in a dance up to half your Speed, attempting a DC 35 Performance check. You can perform this dance up to three times per day. The second time you do so in the same day, use the degree of success one worse than your actual roll on the Performance check. The third time in a day, use the degree of success two lower than your actual roll." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("33e274f1-8f8c-4878-a490-b971e2f0e01e"), Proficiencies.Instances.Expert.ID, Skills.Instances.Performance.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("0d6aace7-fd6a-480d-858c-8392d4022007"),
                CriticalSuccess = "You perform the movements of the Dance of Intercession so gracefully that you evoke a glimmer of the memory of the Celestial Dragon&#39;s awesome power. You cast the 3-action version of either 9th-level (spell: harm) or (spell: heal) at any point during your (action: Stride). This does not use any spell slots.",
                Success = "As critical success, but the spell is 7th level instead of 9th as you stumble through the movements.",
                Failure = "As critical success, but the spell is 5th level instead of 9th as you stumble through the movements.",
                CriticalFailure = "You fail to remember the steps of the dance. You gain no additional effect beyond (action: Striding | Stride) half your Speed, and you can&#39;t attempt the Dance of Intercession again until your next daily preparations.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1b2f8975-55c7-4e4a-96e3-ee3879107b81"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
