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
    public class HexMaster : Template
    {
        public static readonly Guid ID = Guid.Parse("7b935b46-3dd8-452e-8d53-6627c26d765b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Hex Master",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("aef9e19f-9874-4729-981b-d9895c032c87"), Type = TextBlockType.Text, Text = $"You embody the link to your patron so completely that you can cast your hexes in rapid succession. You are no longer limited to casting only a single hex each turn. In addition, when you cast {ToMarkdownLink<Models.Entities.Spell>("cackle", Spells.Instances.Cackle.ID)} to sustain a hex, you gain the effects of {ToMarkdownLink<Models.Entities.Action>("Sustain a Spell", Actions.Instances.SustainASpell.ID)} for all your active hexes that have a duration of sustained." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3a685586-96da-4409-975f-e08734e80a84"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
