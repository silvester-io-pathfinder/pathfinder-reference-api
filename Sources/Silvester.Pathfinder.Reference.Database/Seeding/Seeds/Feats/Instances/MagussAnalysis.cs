using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MagussAnalysis : Template
    {
        public static readonly Guid ID = Guid.Parse("d95ed5b3-3064-449c-a8f1-efa3f1ce4bb0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Magus's Analysis",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("cc0ef375-c941-4010-b789-d8cbcb611dd7"), Type = TextBlockType.Text, Text = "You make an assessment informed by your knowledge of how a creature fights. Attempt a check to (action: Recall Knowledge) about a creature. You gain a +1 circumstance bonus to your check if you previously hit the creature with a (action: Strike) this turn. If your check is successful, recharge your (feat: Spellstrike). The subject of your check is temporarily immune to Magus’s Analysis for 1 day." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("4978a331-a043-4cc2-8100-b84e0facb1eb"), Feats.Instances.Spellstrike.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("68bf28c4-fe90-48f1-89cd-bc09b3b172c7"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
