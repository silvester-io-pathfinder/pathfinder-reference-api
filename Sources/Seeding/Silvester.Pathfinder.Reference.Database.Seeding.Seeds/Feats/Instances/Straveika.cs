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
    public class Straveika : Template
    {
        public static readonly Guid ID = Guid.Parse("55ffc919-e3c7-4e16-aebe-82a5a5cf1530");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Straveika",
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
            yield return new TextBlock { Id = Guid.Parse("5622afe2-1aa9-463c-beda-d4874ff6f46c"), Type = TextBlockType.Text, Text = $"You descend from one of the truly ancient vampires, a nosferatu cursed to eternal life but not eternal youth. People call you straveika, or ancient-born. The vestiges of your forebear's powers of domination have left you with an understanding of how a creature's intentions change its behaviors. You gain a +1 circumstance bonus to Perception checks to {ToMarkdownLink<Models.Entities.Action>("Sense Motive", Actions.Instances.SenseMotive.ID)} and Perception DCs against attempts to {ToMarkdownLink<Models.Entities.SkillAction>("Lie", SkillActions.Instances.Lie.ID)} to you." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Dhampir.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Lineage.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e3baf7d9-3753-42cc-99a2-92d1d7a46323"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
