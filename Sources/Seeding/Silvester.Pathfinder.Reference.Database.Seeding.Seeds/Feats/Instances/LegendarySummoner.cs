using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LegendarySummoner : Template
    {
        public static readonly Guid ID = Guid.Parse("f7e3c008-9e44-41d3-918f-68968622a8cf");

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
            yield return new TextBlock { Id = Guid.Parse("8ebc58e7-b11d-48c9-b8df-ab7aaf7708b4"), Type = TextBlockType.Text, Text = "Your ability to summon extends past your other spellcasting. When you sacrifice a 9th-level spell slot to gain two summoning slots using (feat: Master Summoner), you can use those slots to cast summoning spells heightened to 10th level. You can't use these spell slots for any purpose other than casting the summoning spells, and you don't count as having 10th-level spell slots for other abilities or rules." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("7447b0f9-0bdf-43c4-b165-286553760957"), Feats.Instances.MasterSummoner.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("326b2587-5f3c-4e97-a2c4-ec7271cef560"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
