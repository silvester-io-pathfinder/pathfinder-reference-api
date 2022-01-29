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
    public class VisionOfWeakness : Template
    {
        public static readonly Guid ID = Guid.Parse("131a1ccf-d5d7-4daa-b215-703eece6fbdb");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Vision of Weakness",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("600dbfed-e967-4fc5-bb2d-de6e5ba38231"), Type = TextBlockType.Text, Text = $"You can call upon divine insights to single out your foes' weak points. You learn the {ToMarkdownLink<Models.Entities.Spell>("vision of weakness", Spells.Instances.VisionOfWeakness.ID)} revelation spell. Increase the number of Focus Points in your focus pool by 1." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dca02c85-bf1f-40b7-a92c-5e732c5ea8f4"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
