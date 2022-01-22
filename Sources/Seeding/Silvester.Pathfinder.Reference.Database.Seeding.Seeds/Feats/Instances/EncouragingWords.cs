using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EncouragingWords : Template
    {
        public static readonly Guid ID = Guid.Parse("c6a97de8-0a19-4edb-93bc-54c43293fbe3");

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
            yield return new TextBlock { Id = Guid.Parse("980b718e-d508-4c2e-8315-520b4dca1511"), Type = TextBlockType.Text, Text = $"You give an ally within 30 feet a quick pep talk, helping them recover. Attempt a Diplomacy check. The DC is usually 15, though the GM might adjust it based on the circumstances. If you have expert proficiency in Diplomacy, you can instead attempt a DC 20 check to increase the Stamina Points recovered by 5; if you have master proficiency, you can attempt a DC 30 check to increase the Stamina Points by 15; if you have legendary proficiency, you can attempt a DC 40 check to increase the Stamina Points by 25. No matter the result, the ally is temporarily immune to Encouraging Words until they either {ToMarkdownLink<Models.Entities.Action>("Take a Breather", Actions.Instances.TakeABreather.ID)} or rest for the day." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("0c678c1d-30ec-49b9-b74f-ddeef0c489f8"), Proficiencies.Instances.Trained.ID, Skills.Instances.Diplomacy.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("fcad7fc7-094e-4dd0-aec1-2693a3d3c0f1"),
                CriticalSuccess = "The ally recovers 2d8 Stamina Points.",
                Success = "The ally recovers 1d8 Stamina Points.",
                
                CriticalFailure = "The ally takes 1d8 mental damage, but this can reduce only Stamina Points, never Hit Points.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9fe8a1d6-6602-41be-8aa6-e4bb55f04c05"),
                SourceId = Sources.Instances.VariantRuleForStamina.ID,
                Page = -1
            };
        }
    }
}
