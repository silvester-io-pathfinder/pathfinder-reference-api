using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MagussAnalysis : Template
    {
        public static readonly Guid ID = Guid.Parse("012b5d29-4710-4061-bdae-bc17d7faca19");

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
            yield return new TextBlock { Id = Guid.Parse("d2c4bb75-40b9-4f79-929d-d8e8704b3a9b"), Type = TextBlockType.Text, Text = "You make an assessment informed by your knowledge of how a creature fights. Attempt a check to (action: Recall Knowledge) about a creature. You gain a +1 circumstance bonus to your check if you previously hit the creature with a (action: Strike) this turn. If your check is successful, recharge your (feat: Spellstrike). The subject of your check is temporarily immune to Magus's Analysis for 1 day." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("aff65198-1406-4cd2-ac8a-2c79548ea13c"), Feats.Instances.Spellstrike.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("78946f65-0abb-4064-8081-9fff3cacf946"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
