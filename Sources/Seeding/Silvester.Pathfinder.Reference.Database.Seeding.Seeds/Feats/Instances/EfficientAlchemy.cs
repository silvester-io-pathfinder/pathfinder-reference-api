using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EfficientAlchemy : Template
    {
        public static readonly Guid ID = Guid.Parse("3cfa9d04-64da-4d5b-accc-c3f93b9607c3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Efficient Alchemy",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("df9aee77-d30d-4adf-bdab-1b869cfb37c5"), Type = TextBlockType.Text, Text = $"~ Access: secure Visitor's Pins or an alliance with Mengkare." };
            yield return new TextBlock { Id = Guid.Parse("37214942-c9b0-4d4f-b238-359def2c4a79"), Type = TextBlockType.Text, Text = $"Your daily preparations are particularly efficient and plentiful. When using your infused reagents to create alchemical items during your daily preparations, you make a batch of three of a given item instead of a batch of two, or a batch of four if your field normally lets you create three of that item." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fae1ebbf-c8f4-4646-b2c1-e001e3143ab7"),
                SourceId = Sources.Instances.AgeOfAshes.ID,
                Page = -1
            };
        }
    }
}
