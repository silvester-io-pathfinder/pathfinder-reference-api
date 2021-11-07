using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RazzleDazzle : Template
    {
        public static readonly Guid ID = Guid.Parse("dee5e127-f40a-4778-95ae-9667e9789ae8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Razzle-Dazzle",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You blind or dazzle a creature.",
                Frequency = "once per hour"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f51ea424-5973-4ec2-821f-e26e38b17108"), Type = TextBlockType.Text, Text = "You’ve spent considerable time practicing the manipulation of light, weaponizing your blade’s reflection or bolstering the luminosity of magical displays to unconventional heights. Extend the duration of the blinded or dazzled condition you give the target by 1 round." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("90f27241-0c91-4a82-9743-829fb42a446e"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
