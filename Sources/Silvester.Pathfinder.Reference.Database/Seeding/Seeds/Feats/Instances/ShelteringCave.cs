using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShelteringCave : Template
    {
        public static readonly Guid ID = Guid.Parse("68f5b97b-df86-4bbb-b60e-d5694229fefe");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sheltering Cave",
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
            yield return new TextBlock { Id = Guid.Parse("6c15ba0d-97af-4126-aced-a1ab26b40f21"), Type = TextBlockType.Text, Text = "You spend 10 minutes communing with spirits of earth and stone, requesting shelter. At the end of this time, the earth rises and opens, forming a small cave or earthen mound 20 feet in diameter and 10 feet high. This cave has the (trait: structure) trait and the same restrictions as structures created by magic items. The cave has a single entrance and provides shelter from the elements. The cave remains for 12 hours or until you spend 10 minutes coaxing the earth to close." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificDruidicOrder(Guid.Parse("97e264c8-f2aa-46e5-a12b-c78b35839a9a"), DruidicOrders.Instances.Stone.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d422e3c4-bad3-4d8c-9450-f78e93a03d6c"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
