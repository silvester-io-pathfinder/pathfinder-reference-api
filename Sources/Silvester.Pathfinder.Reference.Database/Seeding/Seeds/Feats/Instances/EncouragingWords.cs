using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EncouragingWords : Template
    {
        public static readonly Guid ID = Guid.Parse("4ce81696-9ae2-4d4d-8cfa-b46d211db016");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Encouraging Words",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b5df94d2-ca3e-4e54-9abb-4f0cc8048438"), Type = TextBlockType.Text, Text = "You give an ally within 30 feet a quick pep talk, helping them recover. Attempt a Diplomacy check. The DC is usually 15, though the GM might adjust it based on the circumstances. If you have expert proficiency in Diplomacy, you can instead attempt a DC 20 check to increase the Stamina Points recovered by 5; if you have master proficiency, you can attempt a DC 30 check to increase the Stamina Points by 15; if you have legendary proficiency, you can attempt a DC 40 check to increase the Stamina Points by 25. No matter the result, the ally is temporarily immune to Encouraging Words until they either (action: Take a Breather) or rest for the day." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("10d11898-7a1c-4f7c-b1df-6e48df8af47f"), Proficiencies.Instances.Trained.ID, Skills.Instances.Diplomacy.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("e3576caf-6226-40fb-a9bb-5b144f575874"),
                CriticalSuccess = "The ally recovers 2d8 Stamina Points.",
                Success = "The ally recovers 1d8 Stamina Points.",
                
                CriticalFailure = "The ally takes 1d8 mental damage, but this can reduce only Stamina Points, never Hit Points.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cc4a4798-57e3-4974-b636-e469be58267c"),
                SourceId = Sources.Instances.VariantRuleForStamina.ID,
                Page = -1
            };
        }
    }
}
