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
    public class LifeLeap : Template
    {
        public static readonly Guid ID = Guid.Parse("b090fe09-8259-409b-afab-e59b4b30c7b9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Life Leap",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2070eeef-e571-45a1-adc6-ebc109241fc1"), Type = TextBlockType.Text, Text = $"You phase through a space that a living creature occupies in a flash, spontaneously appearing on the opposite side of it in a vibrant display of colorful light. You move from your current location to another location that's still adjacent to the same living creature, but on the opposite side or corner of the creature's space." };
            yield return new TextBlock { Id = Guid.Parse("9fca80dd-1ed9-4f6c-ba55-d26893762db4"), Type = TextBlockType.Text, Text = $"To determine whether a position is valid, use the same rules as for flanking: a line through the center of the two spaces must pass through opposite sides or corners of the creature's space. You pass through the creature's life force, appearing in the selected location; this doesn't trigger reactions based on movement. You must be able to see your destination, and you can't move farther than your Speed would allow." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Gnome.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Move.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Necromancy.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Teleportation.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ed07db7f-b81c-4744-9ddc-a3f8900834cf"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
