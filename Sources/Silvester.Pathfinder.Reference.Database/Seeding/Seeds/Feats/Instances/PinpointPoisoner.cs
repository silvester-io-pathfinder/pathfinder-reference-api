using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PinpointPoisoner : Template
    {
        public static readonly Guid ID = Guid.Parse("2e1504b6-fc11-4815-ad92-a8359cb9bd89");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Pinpoint Poisoner",
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
            yield return new TextBlock { Id = Guid.Parse("38cdb111-bead-45a7-87ae-2ec35500ca05"), Type = TextBlockType.Text, Text = "Unsuspecting targets are especially vulnerable to your poisons. When you successfully (action: Strike) a flat-footed creature with a poisoned weapon or expose a flat-footed creature to an (trait: inhaled) poison, the flat-footed condition also gives that creature a -2 circumstance penalty to its initial save against that poison." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("fab68a1c-af9a-4233-bbf1-a020f34e6a91"), Feats.Instances.PoisonerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("05bf10cb-0353-472f-a119-0331d63ee53f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
