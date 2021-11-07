using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AdvancedElementalSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("fc6c70c3-0504-4918-bf06-08919ef0e1b3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Advanced Elemental Spell",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f35ac967-99f9-482c-a025-f5ada883034a"), Type = TextBlockType.Text, Text = "Your connection to one of the great elemental aspects of nature deepens, allowing you further control over its powers. You gain the advanced order spell associated with your order: if you’re a member of the flame order, you gain (spell: combustion); if you’re a member of the stone order, you gain (spell: stone lance); if you’re a member of the storm order, you gain (spell: powerful inhalation); if you’re a member of the wave order, you gain (spell: pulverizing cascade). Increase the number of Focus Points in your focus pool by 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("7ac86b12-fb82-4b0e-8ee0-5d1452ffe988"), or => 
            {
                or.HaveSpecificDruidicOrder(Guid.Parse("877cd741-2222-4fa9-83ff-8b5a5ee7b036"), DruidicOrders.Instances.Flame.ID);
                or.HaveSpecificDruidicOrder(Guid.Parse("dae35d34-8174-41b7-9d48-d9cd34c1826f"), DruidicOrders.Instances.Stone.ID);
                or.HaveSpecificDruidicOrder(Guid.Parse("640cdf09-a587-482c-90ef-6e4ac32a865d"), DruidicOrders.Instances.Storm.ID);
                or.HaveSpecificDruidicOrder(Guid.Parse("24133138-b6c1-4aa1-96bf-bb9c294afb15"), DruidicOrders.Instances.Wave.ID);
            });
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("846c1da3-4cf1-47db-8170-c6868fd2867e"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
