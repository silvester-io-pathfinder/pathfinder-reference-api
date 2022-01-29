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
    public class NightMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("19f27d7f-faa7-4c2d-bb93-0c0c6b048ded");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Night Magic",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c08ffe50-3838-4fbe-89f0-e37dd9feaed5"), Type = TextBlockType.Text, Text = $"You can tap into the magic that runs through your blood. You gain {ToMarkdownLink<Models.Entities.Spell>("animal form", Spells.Instances.AnimalForm.ID)} (wolf only, using the statistics for a canine) and {ToMarkdownLink<Models.Entities.Spell>("obscuring mist", Spells.Instances.ObscuringMist.ID)} as 2nd-level divine innate spells. You can cast each of these spells once per day." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("945ec76e-57ea-4fde-9c89-c6dd06d70254"), Traits.Instances.Dhampir.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("045993db-0726-4826-9eb6-fffa6de3cc1e"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
