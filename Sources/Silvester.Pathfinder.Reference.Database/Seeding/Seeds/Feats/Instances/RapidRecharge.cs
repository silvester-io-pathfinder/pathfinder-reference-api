using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RapidRecharge : Template
    {
        public static readonly Guid ID = Guid.Parse("97254a94-0b62-4e4b-90a3-0341ad3cfa45");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Rapid Recharge",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0ab8b937-3dd6-4a0b-97a6-6bd35a00c0a4"), Type = TextBlockType.Text, Text = "You tap into an arcane trick to recover your ability to meld spells and attacks. You recharge your (feat: Spellstrike)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("25ed356a-973b-423c-ac7b-3ec88a8fc293"), Feats.Instances.Spellstrike.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("aa405077-aa5f-4df0-9e7b-ff7e7d12fb0f"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
