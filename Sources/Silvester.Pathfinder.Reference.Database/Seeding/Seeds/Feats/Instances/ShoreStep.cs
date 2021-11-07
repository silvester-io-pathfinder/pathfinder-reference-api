using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShoreStep : Template
    {
        public static readonly Guid ID = Guid.Parse("171228ba-d4f7-4fce-8b59-18568f70f854");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shore Step",
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
            yield return new TextBlock { Id = Guid.Parse("7880db79-c5dd-413c-be9d-7a8c8cef2dff"), Type = TextBlockType.Text, Text = "The shallows and tide pools have always called to you and let you pass unhindered. You ignore difficult terrain resulting from shallow water. In addition, if you roll a success on an Acrobatics check to (action: Balance) on a slippery or wet surface, or on an Athletics check to (action: Swim), you get a critical success instead." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificDruidicOrder(Guid.Parse("ecace3af-51c6-48b9-a495-36dd3f39c6fe"), DruidicOrders.Instances.Wave.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2477b4ef-cea8-4c6e-b82f-7cb537d85414"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
