using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BravosDetermination : Template
    {
        public static readonly Guid ID = Guid.Parse("56757c33-cf55-4b11-a2c6-1ed970001995");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Bravo's Determination",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "A foe's Strike reduces you to 0 Hit Points; you were not at 1 Hit Point and you would not be killed.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fe1a3b69-3d1b-4ac0-9534-6862ec1cbb4d"), Type = TextBlockType.Text, Text = "Your confidence borders on self-delusion, but it keeps you going against overwhelming odds. Attempt a Deception check against the attack DC of the triggering (action: Strike). You take a penalty to this check equal to twice your wounded value, if any. If the triggering attack was a critical hit, use the result one degree of success worse than what you rolled." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("c014ab6d-de10-47fb-a7ad-678bee737a7e"), Proficiencies.Instances.Expert.ID, Skills.Instances.Perception.ID);
            builder.HaveSpecificFeat(Guid.Parse("643303fc-1a6f-41ff-ba0d-bf7b49cbae70"), Feats.Instances.FirebrandBraggartDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("eae5926c-b7a7-45fd-b5dc-ca0869911962"),
                CriticalSuccess = "You avoid being knocked out and remain at 1 Hit Point.",
                Success = "You avoid being knocked out and remain at 1 Hit Point, but you increase your wounded value by 1.",
                
                 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5ff2dff4-4cec-47a1-b488-640d15088ea0"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
