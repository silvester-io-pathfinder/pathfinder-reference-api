using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SuperiorSight : Template
    {
        public static readonly Guid ID = Guid.Parse("79ffb8c1-1f8b-4741-866e-511ca527a85f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Superior Sight",
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
            yield return new TextBlock { Id = Guid.Parse("9f27f34f-a915-4ee9-abb6-8ce64c4b9428"), Type = TextBlockType.Text, Text = $"~ Access: secure Visitor's Pins or an alliance with Mengkare." };
            yield return new TextBlock { Id = Guid.Parse("e4f7aef5-ca47-46db-a291-bbf13bd3cf3d"), Type = TextBlockType.Text, Text = $"Your senses are peerless. You gain a +2 circumstance bonus to Perception checks, and you gain low-light vision. If you already have low-light vision, gain darkvision instead. Furthermore, when you target an enemy, you automatically succeed at the flat check if that enemy is concealed, hidden, or undetected." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e807f5a1-a7d4-4a86-97dd-dba3d7187cf4"),
                SourceId = Sources.Instances.AgeOfAshes.ID,
                Page = -1
            };
        }
    }
}
