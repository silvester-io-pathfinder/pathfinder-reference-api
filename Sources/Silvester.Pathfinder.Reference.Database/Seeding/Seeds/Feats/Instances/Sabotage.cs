using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Sabotage : Template
    {
        public static readonly Guid ID = Guid.Parse("dbc9d2ba-9a5e-48b9-a7e0-3294999527c0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sabotage",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0104f387-9b14-487b-ab26-ef76799bf1e9"), Type = TextBlockType.Text, Text = "You subtly damage others’ equipment. Choose one item that a creature within your reach wields or carries. The item must have moving parts that you could possibly sabotage (a shortbow could be sabotaged, but a longsword could not). Attempt a Thievery check against the Reflex DC of the creature. Damage dealt by Sabotage can’t take the item below its Broken Threshold." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("deaec135-30ff-4bfd-8f60-a72081574226"),
                CriticalSuccess = "You deal damage equal to four times your Thievery proficiency bonus.",
                Success = "You deal damage equal to double your Thievery proficiency bonus.",
                
                CriticalFailure = "Temporarily immune to your Sabotage for 1 day.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c6ec33b1-b71d-4bd6-ade0-a1340ddb6b7b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
