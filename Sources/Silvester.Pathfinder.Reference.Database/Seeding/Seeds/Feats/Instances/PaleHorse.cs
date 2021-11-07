using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PaleHorse : Template
    {
        public static readonly Guid ID = Guid.Parse("bea4294f-edd2-4d8e-8bdf-2139b5430dd1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Pale Horse",
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
            yield return new TextBlock { Id = Guid.Parse("1527968a-1437-4b6d-8d65-0f867d49d33d"), Type = TextBlockType.Text, Text = "Your mount becomes a grotesque creature of foreboding when you ride it. Its appearance transforms as flames erupt from its skin, a whorl of negative energy surrounds it, or poison leaks from its flesh. When you (action: Mount | Mount / Dismount) your steed ally, you can choose fire, negative, or poison. As long as you ride it, your steed gains resistance 10 to the chosen damage type, and any creature that touches your steed takes 1d6 damage of the chosen type; this includes hitting the steed with unarmed attacks or with a melee weapon (action: Strike) while adjacent to the steed. This damage increases to 2d6 at 16th level and 3d6 at 20th level." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificDivineAlly(Guid.Parse("e074f946-3ab6-4791-b22a-b7495db0b2c4"), DivineAllies.Instances.Steed.ID);
            builder.HaveSpecificTenet(Guid.Parse("b4a1a681-807d-4469-9838-adf7971f04a8"), Tenets.Instances.Evil.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3197fe71-26ab-4ed3-92ea-01fd97d32037"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
