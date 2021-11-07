using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FireResistance : Template
    {
        public static readonly Guid ID = Guid.Parse("056e99ad-c3e7-4ae4-acba-574376032a3e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fire Resistance",
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
            yield return new TextBlock { Id = Guid.Parse("1d82a3e2-69c9-4ff6-a7d4-2ae6696306b4"), Type = TextBlockType.Text, Text = "Your connection to heat and flame means that fire is reluctant to bring its full force to bear against you. You gain fire resistance equal to half your level, and you gain a +1 circumstance bonus to saving throws against fire effects." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificDruidicOrder(Guid.Parse("e308bc56-a581-485a-8e47-6aa1ebba75e2"), DruidicOrders.Instances.Flame.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("608d4920-de53-4e1e-bccb-2088d451db24"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
