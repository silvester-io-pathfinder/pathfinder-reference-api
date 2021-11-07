using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FireLung : Template
    {
        public static readonly Guid ID = Guid.Parse("8470a897-48fb-49a0-8ac0-9bf8ac889a80");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fire Lung",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fca3fd8e-ce11-473b-b174-0b8ed7c5870b"), Type = TextBlockType.Text, Text = "A lifetime of proximity to flames has inured your lungs and eyes to smoke. You can breathe normally in areas of ash and smoke without risk of suffocation, and you ignore the concealed condition from smoke. You need only a successful DC 10 flat check to recover from persistent fire damage, rather than DC 15 (and the DC when receiving particularly effective assistance is 5 instead of 10)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificDruidicOrder(Guid.Parse("fb0d5ddf-9cbb-4251-9535-5f2c83183853"), DruidicOrders.Instances.Flame.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4ba61dcc-9ecf-44be-ad1e-51cc157fb3e2"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
