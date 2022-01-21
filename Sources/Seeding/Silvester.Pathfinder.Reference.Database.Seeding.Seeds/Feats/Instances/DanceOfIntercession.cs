using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DanceOfIntercession : Template
    {
        public static readonly Guid ID = Guid.Parse("61ef2bb9-c1c9-4012-9d3c-dce86e0043ab");

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
            yield return new TextBlock { Id = Guid.Parse("db56cb2d-bd36-4b46-9bf6-455a43e70f30"), Type = TextBlockType.Text, Text = $"You either performed in or stood witness to the dance used to invoke the Celestial Dragon and can harness a sliver of their power. You {ToMarkdownLink<Models.Entities.Action>("Stride", Actions.Instances.Stride.ID)} in a dance up to half your Speed, attempting a DC 35 Performance check. You can perform this dance up to three times per day. The second time you do so in the same day, use the degree of success one worse than your actual roll on the Performance check. The third time in a day, use the degree of success two lower than your actual roll." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("eb248829-d750-4c58-b819-d5e9c1ba0a7b"), Proficiencies.Instances.Expert.ID, Skills.Instances.Performance.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("555e24b4-ee28-4b18-a369-68ee9ca66eac"),
                CriticalSuccess = "You perform the movements of the Dance of Intercession so gracefully that you evoke a glimmer of the memory of the Celestial Dragon's awesome power. You cast the 3-action version of either 9th-level (spell: harm) or (spell: heal) at any point during your (action: Stride). This does not use any spell slots.",
                Success = "As critical success, but the spell is 7th level instead of 9th as you stumble through the movements.",
                Failure = "As critical success, but the spell is 5th level instead of 9th as you stumble through the movements.",
                CriticalFailure = "You fail to remember the steps of the dance. You gain no additional effect beyond (action: Striding | Stride) half your Speed, and you can't attempt the Dance of Intercession again until your next daily preparations.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("701de9db-bc81-476d-bd78-0c79238a7f99"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
