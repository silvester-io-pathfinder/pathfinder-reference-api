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
    public class MartialArtistDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("acf61765-4cf7-4c27-aeec-0c31b0c9be96");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Martial Artist Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you have gained two other feats from the martial artist archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c5f444c4-3218-420b-91fd-e44d4e0da0dd"), Type = TextBlockType.Text, Text = $"You have trained to use your fists as deadly weapons. The damage die for your fist unarmed attacks becomes 1d6 instead of 1d4. You don't take the -2 circumstance penalty for making a lethal attack with your nonlethal unarmed attacks. Whenever you gain a class feature that grants you expert or greater proficiency in certain weapons, you also gain that proficiency rank in all unarmed attacks." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Dedication.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5c658ec9-f9c3-48c4-a4b1-14b4f764bb05"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
