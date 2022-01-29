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
    public class Svetocher : Template
    {
        public static readonly Guid ID = Guid.Parse("2abcff35-7564-4c2a-9a27-56858d510511");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Svetocher",
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
            yield return new TextBlock { Id = Guid.Parse("82ea3ce3-c691-4c68-ac88-195f66e1a794"), Type = TextBlockType.Text, Text = $"You were born to one of the moroi, the most common vampires, and you share their supernatural fortitude and power of persuasion. When you have the drained condition, calculate the penalty to your Fortitude saves and your Hit Point reduction as though the condition value were 1 lower. You are trained Diplomacy. If you would automatically be trained in it, you instead become trained in a skill of your choice." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("34105514-37b2-4cc6-8672-8ddd0386b80d"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
