using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class VanthsWeaponFamiliarity : Template
    {
        public static readonly Guid ID = Guid.Parse("223fb677-1e32-44fd-8455-9cbb24bfcbb0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Vanth's Weapon Familiarity",
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
            yield return new TextBlock { Id = Guid.Parse("2c3d7bb7-08ef-4f6c-8596-56ac0b95972e"), Type = TextBlockType.Text, Text = "You seek to emulate vanth reapers’ fighting styles. You are trained with (item: bo staves | bo staff), (item: longbows | longbow), (item: composite longbows | composite longbow), (item: scythes | scythe), and (item: staves | staff)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3a5629f6-f602-4c2f-9a75-1363c45fcddd"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
