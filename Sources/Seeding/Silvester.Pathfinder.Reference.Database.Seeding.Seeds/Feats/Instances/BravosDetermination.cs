using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BravosDetermination : Template
    {
        public static readonly Guid ID = Guid.Parse("0a0a471e-7a2e-405e-8dd1-7661663f1d24");

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
            yield return new TextBlock { Id = Guid.Parse("cfff0f44-29e4-4dbf-900c-2866eb47428d"), Type = TextBlockType.Text, Text = $"Your confidence borders on self-delusion, but it keeps you going against overwhelming odds. Attempt a Deception check against the attack DC of the triggering {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}. You take a penalty to this check equal to twice your wounded value, if any. If the triggering attack was a critical hit, use the result one degree of success worse than what you rolled." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("d02f3299-cbb2-4361-87a8-57ba1cba2c84"), Proficiencies.Instances.Expert.ID, Skills.Instances.Perception.ID);
            builder.HaveSpecificFeat(Guid.Parse("730eb5b6-2fee-4ba4-95b1-e82661b469e3"), Feats.Instances.FirebrandBraggartDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("a4cb7fce-6dd8-4992-bbd6-8b4c00172a2f"),
                CriticalSuccess = "You avoid being knocked out and remain at 1 Hit Point.",
                Success = "You avoid being knocked out and remain at 1 Hit Point, but you increase your wounded value by 1.",
                
                 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0a942f99-36ef-4497-a326-1fde3ee24406"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
