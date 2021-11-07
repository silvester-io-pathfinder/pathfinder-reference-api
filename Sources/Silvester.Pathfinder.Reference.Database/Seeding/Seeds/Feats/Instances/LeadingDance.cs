using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LeadingDance : Template
    {
        public static readonly Guid ID = Guid.Parse("06ce3fb8-2a98-4b66-8043-c70263bce7ce");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Leading Dance",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e8424840-359a-451b-b2b8-1bfa4d665ffe"), Type = TextBlockType.Text, Text = "You sweep your foe into your dance. Attempt a Performance check against an adjacent enemy’s Will DC. If your swashbuckler’s style is battledancer and you succeed, you gain panache." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("8b664a7b-1cf1-456b-b9e9-cd43cfb5dbc1"), Proficiencies.Instances.Trained.ID, Skills.Instances.Performance.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("7a2a34eb-17a3-4fc0-a304-5394de37431b"),
                CriticalSuccess = "Your foe is swept up in your dance. You both move up to 10 feet in the same direction, remaining adjacent to one another. Your movement doesn’t trigger reactions from the target (and the target’s movement doesn’t trigger reactions because it’s forced movement).",
                Success = "As critical success, but you both move only 5 feet.",
                Failure = "The foe doesn’t follow your steps. You can move 5 feet if you choose, but this movement triggers reactions normally.",
                CriticalFailure = "You stumble, falling prone in your space.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4ebdbb20-c687-47b9-9767-974599c5d624"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
