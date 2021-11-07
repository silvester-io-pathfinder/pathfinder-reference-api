using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class StarOrb : Template
    {
        public static readonly Guid ID = Guid.Parse("24f13c9b-178e-452b-90c9-f2d94894c51b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Star Orb",
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
            yield return new TextBlock { Id = Guid.Parse("8d16915e-ebf8-4491-bd38-62bbf5c0e25e"), Type = TextBlockType.Text, Text = "Your magic has crystallized into a spherical stone. You gain a familiar, except it’s a star orb: a Tiny stone of light Bulk. The familiar has no Speeds and must select a Speed familiar ability before it can move, animating in a way appropriate to the chosen Speed and using the statistics of a normal familiar for that day; when it‘s an immobile stone, it can’t select any familiar or master abilities that require it to move. It always has the innate surge master ability (Advanced Player’s Guide 147)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5ebeb3f2-f30b-4695-a870-d0aea25bbb5f"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
