using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class StarOrb : Template
    {
        public static readonly Guid ID = Guid.Parse("8ff4dd80-f798-43f7-8f95-f0314dc2e8ab");

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
            yield return new TextBlock { Id = Guid.Parse("e152f03a-ffec-4d74-9a21-4fa91cfbfc4c"), Type = TextBlockType.Text, Text = $"Your magic has crystallized into a spherical stone. You gain a familiar, except it's a star orb: a Tiny stone of light Bulk. The familiar has no Speeds and must select a Speed familiar ability before it can move, animating in a way appropriate to the chosen Speed and using the statistics of a normal familiar for that day; when it‘s an immobile stone, it can't select any familiar or master abilities that require it to move. It always has the innate surge master ability (Advanced Player's Guide 147)." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("83778803-2d32-44d8-9061-d2e4ea2d5b1e"), Traits.Instances.Kitsune.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f466166d-18e1-4ec8-b3d8-53da21b7c811"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
