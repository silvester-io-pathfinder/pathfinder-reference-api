using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class QuickJump : Template
    {
        public static readonly Guid ID = Guid.Parse("afd8dc0b-856c-43b5-bf19-12527403f758");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Quick Jump",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0b44ff92-ac43-4da2-b852-ab4f35088d31"), Type = TextBlockType.Text, Text = $"You can use {ToMarkdownLink<Models.Entities.SkillAction>("High Jump", SkillActions.Instances.HighJump.ID)} and {ToMarkdownLink<Models.Entities.SkillAction>("Long Jump", SkillActions.Instances.LongJump.ID)} as a single action instead of 2 actions. If you do, you don't perform the initial {ToMarkdownLink<Models.Entities.Action>("Stride", Actions.Instances.Stride.ID)} (nor do you fail if you don't {ToMarkdownLink<Models.Entities.Action>("Stride", Actions.Instances.Stride.ID)} 10 feet)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("8d706d78-8313-4d43-9c0f-f919d0d3e7ea"), Proficiencies.Instances.Trained.ID, Skills.Instances.Athletics.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("97dad203-2cfc-46e0-8484-8b786c3dd7dd"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
