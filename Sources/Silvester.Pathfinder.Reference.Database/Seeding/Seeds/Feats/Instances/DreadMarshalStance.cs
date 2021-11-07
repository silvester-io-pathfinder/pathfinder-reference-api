using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DreadMarshalStance : Template
    {
        public static readonly Guid ID = Guid.Parse("7a4a944e-af23-4105-9892-f6617c32d501");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dread Marshal Stance",
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
            yield return new TextBlock { Id = Guid.Parse("492ea09f-9b73-42a8-967b-39499c065f27"), Type = TextBlockType.Text, Text = "Putting on a grim face for the battle ahead, you encourage your allies to strike fear into their foes with vicious attacks. When you use this action, attempt an Intimidation check. The DC is usually a standard-difficulty DC of your level, but the GM can assign a different DC based on the circumstances. The effect depends on the result of your check." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("fc16ccba-6b09-4624-99c5-f382f582a2c5"), Feats.Instances.MarshalDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("9042d0be-b27d-4877-aa38-420fda162a82"), Proficiencies.Instances.Trained.ID, Skills.Instances.Intimidation.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("b4582d44-5c54-4b52-91db-4ebbfa527b9a"),
                CriticalSuccess = "Your marshal’s aura increases to a 20-foot emanation, and it grants you and allies a status bonus to damage rolls equal to the number of weapon damage dice of the unarmed attack or weapon you are wielding that has the most weapon damage dice. When you or an ally in the aura critically hits an enemy with a (action: Strike), that enemy is frightened 1.",
                Success = "As critical success, but your aura’s size doesn’t increase.",
                Failure = "You fail to enter the stance.",
                CriticalFailure = "You fail to enter the stance and can’t take this action again for 1 minute.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4d19a0c2-15b1-4b60-88d5-30a66ebe5034"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
