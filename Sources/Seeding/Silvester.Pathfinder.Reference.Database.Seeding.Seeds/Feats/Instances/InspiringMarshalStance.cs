using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class InspiringMarshalStance : Template
    {
        public static readonly Guid ID = Guid.Parse("6f881d3f-6810-4ad5-863d-0f158013b92a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Inspiring Marshal Stance",
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
            yield return new TextBlock { Id = Guid.Parse("f97b16ae-08ca-4ac6-ad3b-24652ec003ff"), Type = TextBlockType.Text, Text = $"You become a brilliant example of dedication and poise in battle, encouraging your allies to follow suit. When you spend this action, attempt a Diplomacy check. The DC is usually a standard-difficulty DC of your level, but the GM can assign a different DC based on the circumstances. The effect depends on the result of your check." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("053c740e-a1b1-49b6-babb-684d813255ce"), Feats.Instances.MarshalDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("4f5962db-8f38-47fc-a525-9fdc17f260f2"), Proficiencies.Instances.Trained.ID, Skills.Instances.Diplomacy.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Open.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Stance.ID);

        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("c796c916-9efa-4b29-8d2f-bf116d309ce0"),
                CriticalSuccess = "Your marshal's aura increases to a 20-foot emanation and grants you and allies a +1 status bonus to attack rolls and saves against (trait: mental) effects.",
                Success = "As critical success, but your aura's size doesn't increase.",
                Failure = "You fail to enter the stance.",
                CriticalFailure = "You fail to enter the stance and can't take this action again for 1 minute.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c668ae60-4fd7-411d-a8fa-78c578333ef0"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
