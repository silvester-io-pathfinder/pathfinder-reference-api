using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HomewardBound : Template
    {
        public static readonly Guid ID = Guid.Parse("30be760b-d403-4f00-b56c-ffc87bf70657");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Homeward Bound",
                Level = 17,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "twice per week"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1be6e62b-0bc3-4353-a7c2-f4f7c922f002"), Type = TextBlockType.Text, Text = "The connection between you and the First World resonates within your body stronger than it does for most gnomes, allowing you to cross the threshold between the Material Plane and the First World. You gain (spell: plane shift) as a primal innate spell. You can cast it twice per week. This can be used only to travel back and forth between the First World and the Material Plane. Due to your body’s natural resonance, you can act as the spell focus, and you don’t require a tuning fork." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0817ff48-0ce3-4cf7-b462-adbe37eaade9"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
