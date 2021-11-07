using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GreenEmpathy : Template
    {
        public static readonly Guid ID = Guid.Parse("d3b25e5d-dbb9-4785-bd9a-752ffb9146f3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Green Empathy",
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
            yield return new TextBlock { Id = Guid.Parse("46ffbc8e-4519-4c7d-908d-9fd3b80dd206"), Type = TextBlockType.Text, Text = "You can communicate with plants on a basic level and use Diplomacy to (Action: Make an Impression) on them and to make very simple (Action: Requests | Request) of them. Non-creature plants typically can’t fulfill most requests you might ask of them unless you have access to other magic such as (Spell: speak with plants). Because of your affiliation with the leaf order, plants have a sense that you support them, so you gain a +2 circumstance bonus on your check to make a (Action: Request) of a plant using Green Empathy." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificDruidicOrder(Guid.Parse("bef9857f-2f6c-4a50-a883-4d72d7b8034b"), DruidicOrders.Instances.Leaf.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e7f92aac-7848-4d4f-85b7-7a7ae29d8652"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
