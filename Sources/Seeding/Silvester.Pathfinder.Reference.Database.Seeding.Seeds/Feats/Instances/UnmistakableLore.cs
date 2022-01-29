using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UnmistakableLore : Template
    {
        public static readonly Guid ID = Guid.Parse("73087f38-95f6-4417-9ffd-192c8ac96fe0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Unmistakable Lore",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("dfee3c8c-1b6f-4c15-9487-5dd3e4eb1cef"), Type = TextBlockType.Text, Text = $"You never get information about your areas of expertise wrong." };
            yield return new TextBlock { Id = Guid.Parse("d71e789a-943d-4936-8905-92bb660ec95f"), Type = TextBlockType.Text, Text = $"When you {ToMarkdownLink<Models.Entities.SkillAction>("Recall Knowledge", SkillActions.Instances.RecallKnowledge.ID)} using any Lore subcategory in which you're trained, if you roll a critical failure, you get a failure instead. If you're a master in a Lore subcategory, on a critical success, you gain even more information or context than usual." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveAnyLoreProficiency(Guid.Parse("4de1e8b5-7048-4991-b9cc-1688cfd93585"), Proficiencies.Instances.Expert.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1f5aa8d3-12e7-41bb-a356-3bd460d8d44b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
