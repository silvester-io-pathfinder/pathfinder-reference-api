using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class InspiringMarshalStance : Template
    {
        public static readonly Guid ID = Guid.Parse("1c31da78-2398-4d3a-ada7-8fad38e0ec3d");

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
            yield return new TextBlock { Id = Guid.Parse("6ebb62b3-4a58-494a-8905-5d8437b13213"), Type = TextBlockType.Text, Text = "You become a brilliant example of dedication and poise in battle, encouraging your allies to follow suit. When you spend this action, attempt a Diplomacy check. The DC is usually a standard-difficulty DC of your level, but the GM can assign a different DC based on the circumstances. The effect depends on the result of your check." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("209038aa-a741-4fd9-8cb1-7daf8d0da275"), Feats.Instances.MarshalDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("8b9fe352-cc8b-4a1b-b405-63f809006e9e"), Proficiencies.Instances.Trained.ID, Skills.Instances.Diplomacy.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("a4a4a4f2-d797-4355-a0c1-c771e5c1fa7c"),
                CriticalSuccess = "Your marshal’s aura increases to a 20-foot emanation and grants you and allies a +1 status bonus to attack rolls and saves against (trait: mental) effects.",
                Success = "As critical success, but your aura’s size doesn’t increase.",
                Failure = "You fail to enter the stance.",
                CriticalFailure = "You fail to enter the stance and can’t take this action again for 1 minute.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("71a6b701-ab11-4d28-b8d2-45d67c7ccc35"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
