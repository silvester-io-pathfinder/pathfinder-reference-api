using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SeverMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("4d8de025-9342-4801-a121-81d69352b8aa");

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
            yield return new TextBlock { Id = Guid.Parse("b2583ab7-6686-4542-9c68-db1f836d7d49"), Type = TextBlockType.Text, Text = "You apply a frayed thread, a pinch of fulu ash, or a similar undone charm, and you swing to break a spell. Make a (action: Strike) against an enemy. If you hit and deal damage, you attempt to counteract a single spell active on the target (your choice). Your counteract level is equal to half your level (rounded up), and your counteract check modifier is equal to your class DC – 10." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("73a0c6e2-5227-4e26-bf10-09bea93a9117"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
