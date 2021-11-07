using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PlantShape : Template
    {
        public static readonly Guid ID = Guid.Parse("f180d7db-0ee4-4646-8486-027b507c886a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Plant Shape",
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
            yield return new TextBlock { Id = Guid.Parse("3a407a25-e6c2-4e91-97de-8106cbad8454"), Type = TextBlockType.Text, Text = "You can take the form of a plant creature. Add the forms listed in (Spell: plant form) to your (Spell: wild shape) list; if you don’t have (Spell: wild shape), you can instead cast (Spell: plant form) once per day, heightened to the same level as your highest druid spell slot. Whenever you’re polymorphed into another form using (Spell: wild shape), you gain resistance 5 to poison." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("c83115ed-622e-4e4b-bb00-46bcffbce05c"), or => 
            {
                or.HaveSpecificDruidicOrder(Guid.Parse("f3f03652-3ff6-4a47-a163-60f0a52b21d2"), DruidicOrders.Instances.Leaf.ID);
                or.HaveSpecificDruidicOrder(Guid.Parse("05a92b4c-ad17-4c11-b306-ec44d12b3d2b"), DruidicOrders.Instances.Wild.ID);
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
                Id = Guid.Parse("f0abeb42-b1d6-4f63-a512-d3036f164a85"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
