using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LeadingDance : Template
    {
        public static readonly Guid ID = Guid.Parse("7b9df82f-74e3-48b4-8b7a-85f8a3a0e7f9");

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
            yield return new TextBlock { Id = Guid.Parse("0ab6f746-362c-433a-a60b-97eeae760480"), Type = TextBlockType.Text, Text = "You sweep your foe into your dance. Attempt a Performance check against an adjacent enemy’s Will DC. If your swashbuckler’s style is battledancer and you succeed, you gain panache." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("9356b357-7c5e-4cd3-940e-de6f2c7259d4"), Proficiencies.Instances.Trained.ID, Skills.Instances.Performance.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("7223b45d-fe9d-47e2-8fc7-3c3c5154c1a4"),
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
                Id = Guid.Parse("82d362a6-10a4-4627-a490-d24072458c59"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
