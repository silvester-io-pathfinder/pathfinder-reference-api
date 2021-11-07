using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MasterSummonerSpellcasting : Template
    {
        public static readonly Guid ID = Guid.Parse("74a11f6f-508e-4dff-b793-847e2ec393ea");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Master Summoner Spellcasting",
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
            yield return new TextBlock { Id = Guid.Parse("97c47017-9ee4-48d2-ad9a-ea7430c34e64"), Type = TextBlockType.Text, Text = "Your proficiency ranks for your tradition&#39;s spell attack rolls and spell DCs increase to master. You gain an additional 6th-level spell slot. At 20th level, you replace your two 5th-level spell slots with two 7th-level spell slots." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("8f781cd1-922c-44ae-a4aa-903aa6d723c4"), Feats.Instances.ExpertSummonerSpellcasting.ID);
            builder.Manual(Guid.Parse("6741eda4-aad7-4530-b408-ba1ad014a0e3"), "Legendary in the skill associated with your eidolon's tradition.");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7b79f396-e769-4cf0-b798-ef54ef6ddf28"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
