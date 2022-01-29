using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SlipWithTheBreeze : Template
    {
        public static readonly Guid ID = Guid.Parse("79b164a4-fbbe-42c6-ba91-257c2111fcd6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Slip with the Breeze",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b3626ace-91b3-4bce-82e6-b2cc3a63019d"), Type = TextBlockType.Text, Text = $"You create gusts of wind when you jump, allowing you to carry yourself across greater distances. You gain the {ToMarkdownLink<Models.Entities.Feat>("Quick Jump", Feats.Instances.QuickJump.ID)} and {ToMarkdownLink<Models.Entities.Feat>("Powerful Leap", Feats.Instances.PowerfulLeap.ID)} skill feats as bonus feats." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("570f7ca6-be36-4c99-863d-66f8444e16da"), Proficiencies.Instances.Expert.ID, Skills.Instances.Athletics.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1995527e-5627-44d3-918c-7a397354c631"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
