using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShelteringCave : Template
    {
        public static readonly Guid ID = Guid.Parse("5e48f1c7-3dc3-433f-958a-84ab84a48ed2");

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
            yield return new TextBlock { Id = Guid.Parse("6c056b2a-5801-4604-b80e-33962e66a6df"), Type = TextBlockType.Text, Text = $"You spend 10 minutes communing with spirits of earth and stone, requesting shelter. At the end of this time, the earth rises and opens, forming a small cave or earthen mound 20 feet in diameter and 10 feet high. This cave has the {ToMarkdownLink<Models.Entities.Trait>("structure", Traits.Instances.Structure.ID)} trait and the same restrictions as structures created by magic items. The cave has a single entrance and provides shelter from the elements. The cave remains for 12 hours or until you spend 10 minutes coaxing the earth to close." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificDruidicOrder(Guid.Parse("f31e4347-300c-451e-987f-7af6173269fc"), DruidicOrders.Instances.Stone.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5904112b-d1ce-4ef2-a147-2da1695e93af"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
