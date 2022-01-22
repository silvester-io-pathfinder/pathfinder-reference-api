using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class InvokeDisaster : Template
    {
        public static readonly Guid ID = Guid.Parse("5b433af4-0062-449b-96d7-a5c4a0e41b70");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Invoke Disaster",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("554f89f8-b44a-44f0-951f-159321e3c8be"), Type = TextBlockType.Text, Text = $"You can invoke nature's fury upon your foes. You gain the {ToMarkdownLink<Models.Entities.Spell>("storm lord", Spells.Instances.StormLord.ID)} order spell. Increase the number of Focus Points in your focus pool by 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("44dea119-2aae-4283-bb7a-6fde024551d5"), Feats.Instances.WindCaller.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("98f1bdda-7062-4fb6-a1e5-6f9ee73c0716"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
