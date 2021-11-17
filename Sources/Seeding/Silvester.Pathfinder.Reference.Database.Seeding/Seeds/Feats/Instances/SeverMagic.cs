using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SeverMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("784ce614-e98d-4ff0-a769-fda313e23383");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sever Magic",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("20e0e643-a3b4-4d86-b8f3-6b8f55814bde"), Type = TextBlockType.Text, Text = "You apply a frayed thread, a pinch of fulu ash, or a similar undone charm, and you swing to break a spell. Make a (action: Strike) against an enemy. If you hit and deal damage, you attempt to counteract a single spell active on the target (your choice). Your counteract level is equal to half your level (rounded up), and your counteract check modifier is equal to your class DC – 10." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("91a5cf21-a53b-48c1-b737-b102e035741e"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
