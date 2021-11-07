using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Spellstriker : Template
    {
        public static readonly Guid ID = Guid.Parse("630874e8-6c7f-4177-95ac-8f5fa868de05");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Spellstriker",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4302550d-f2ca-4aa4-85d8-25e0012fc558"), Type = TextBlockType.Text, Text = "You gain the magus’s (feat: Spellstrike) activity. You can recharge it only as an activity that takes 1 minute. This restriction applies even if you gain another ability that recharges (feat: Spellstrike)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("1dd3d6eb-ca2f-445a-b169-562de2835821"), Feats.Instances.MagusDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2bf34ceb-726e-4729-bbe7-0e0f22365e0f"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
