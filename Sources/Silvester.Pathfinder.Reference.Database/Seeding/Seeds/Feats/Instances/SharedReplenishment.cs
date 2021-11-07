using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SharedReplenishment : Template
    {
        public static readonly Guid ID = Guid.Parse("8f897e1d-71a4-4254-b2dd-bad919a87ae6");

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
            yield return new TextBlock { Id = Guid.Parse("b6db7147-ea93-4c1d-b5d0-0829e7110b20"), Type = TextBlockType.Text, Text = "When your deity blesses your warlike acts, you can extend that favor to your allies. You can grant the temporary Hit Points from (feat: Replenishment of War) to an ally within 10 feet instead of gaining them yourself. You can grant these temporary Hit Points to a different ally each time, meaning you might be able to grant them to multiple creatures in a single turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("65f32869-24b4-4c77-99d5-5fea99b8102f"), Feats.Instances.ReplenishmentOfWar.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ee00e1ce-c93c-4301-ba74-d71e294ccf68"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
