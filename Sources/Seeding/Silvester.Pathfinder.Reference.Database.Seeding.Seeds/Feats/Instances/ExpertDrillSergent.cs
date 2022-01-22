using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ExpertDrillSergent : Template
    {
        public static readonly Guid ID = Guid.Parse("a5a3eaa5-f718-4da9-91dc-0c7d6a4d9050");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Expert Drill Sergent",
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
            yield return new TextBlock { Id = Guid.Parse("a985845a-0dda-4fa8-8038-7b4e0673ed5c"), Type = TextBlockType.Text, Text = $"You know how to get the most out of your allies. While exploring, when you are leading and allies are {ToMarkdownLink<Models.Entities.Activity>("Following the Expert", Activities.Instances.FollowTheExpert.ID)}, you grant a +3 circumstance bonus instead of +2 if you're an expert in the applicable skill, and a +4 circumstance bonus if you're a master." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1592ca46-9c3a-429b-8a0a-4a0fd422acc5"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
