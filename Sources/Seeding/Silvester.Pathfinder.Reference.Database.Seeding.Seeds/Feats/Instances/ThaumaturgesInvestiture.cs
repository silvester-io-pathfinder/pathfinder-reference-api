using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ThaumaturgesInvestiture : Template
    {
        public static readonly Guid ID = Guid.Parse("2bea6441-30c3-4b23-b93c-5c35a0544f79");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Thaumaturge's Investiture",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2ea88e44-bf1f-46d9-92ea-f8459a4f341b"), Type = TextBlockType.Text, Text = $"Using your knowledge of esoterica and implements, you can invest far more items than most. You gain the {ToMarkdownLink<Models.Entities.Feat>("Incredible Investiture", Feats.Instances.IncredibleInvestiture.ID)} skill feat, increasing your limit on invested items from 10 to 12. The limit increases to 14 if you have Charisma 18, 16 if you have Charisma 20, 18 if you have Charisma 22, and 20 if you have Charisma 24." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificStat(Guid.Parse("86b6d771-bdc3-483d-9b02-c3f4384a487b"), requiredStatValue: 16, Stats.Instances.Charisma.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ea1c62c0-d7a7-47cf-8b49-656fe1f75cea"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
