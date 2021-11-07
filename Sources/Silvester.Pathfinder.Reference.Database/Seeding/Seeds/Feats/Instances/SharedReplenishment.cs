using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SharedReplenishment : Template
    {
        public static readonly Guid ID = Guid.Parse("ee99cc3a-dba4-4d96-ad8f-0621b50f3c89");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shared Replenishment",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("31207c76-4760-4822-add1-2534090451d9"), Type = TextBlockType.Text, Text = "When your deity blesses your warlike acts, you can extend that favor to your allies. You can grant the temporary Hit Points from (feat: Replenishment of War) to an ally within 10 feet instead of gaining them yourself. You can grant these temporary Hit Points to a different ally each time, meaning you might be able to grant them to multiple creatures in a single turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("97aab5cb-de08-4d0c-b7a4-93d66c1b66f2"), Feats.Instances.ReplenishmentOfWar.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d4d9e663-0a3d-4261-89d2-12b0737d67a7"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
