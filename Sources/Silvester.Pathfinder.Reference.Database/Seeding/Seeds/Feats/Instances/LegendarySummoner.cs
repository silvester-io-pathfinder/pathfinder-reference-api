using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LegendarySummoner : Template
    {
        public static readonly Guid ID = Guid.Parse("2976fc5f-a36f-4fa3-a090-dd88d5c30d05");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Legendary Summoner",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f4c15902-6634-419b-96e6-8fc0e78f43f9"), Type = TextBlockType.Text, Text = "Your ability to summon extends past your other spellcasting. When you sacrifice a 9th-level spell slot to gain two summoning slots using (feat: Master Summoner), you can use those slots to cast summoning spells heightened to 10th level. You can’t use these spell slots for any purpose other than casting the summoning spells, and you don’t count as having 10th-level spell slots for other abilities or rules." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("218af288-04ee-440d-b586-24bd93d5f186"), Feats.Instances.MasterSummoner.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("09c62f8a-8fbd-4f24-a99e-1be5fec1a9a2"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
