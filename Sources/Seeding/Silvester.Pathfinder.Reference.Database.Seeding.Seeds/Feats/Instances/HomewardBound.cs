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
    public class HomewardBound : Template
    {
        public static readonly Guid ID = Guid.Parse("87ec7b21-0eb6-4865-b5f5-da7d5fbbb4a5");

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
            yield return new TextBlock { Id = Guid.Parse("592fe2ba-d608-4e17-8db2-c54e68a3fee9"), Type = TextBlockType.Text, Text = $"The connection between you and the First World resonates within your body stronger than it does for most gnomes, allowing you to cross the threshold between the Material Plane and the First World. You gain {ToMarkdownLink<Models.Entities.Spell>("plane shift", Spells.Instances.PlaneShift.ID)} as a primal innate spell. You can cast it twice per week. This can be used only to travel back and forth between the First World and the Material Plane. Due to your body's natural resonance, you can act as the spell focus, and you don't require a tuning fork." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("336491cf-f8b4-4545-99fb-74e3e112b16f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
