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
    public class AasimarsMercy : Template
    {
        public static readonly Guid ID = Guid.Parse("7e5948f3-12f3-4eab-b20b-9e63ec4925c2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Aasimar's Mercy",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d6f1595d-9b49-4117-9a89-9382c211c661"), Type = TextBlockType.Text, Text = $"Your celestial powers allow you to remove lesser afflictions with ease. Each day, you can cast two 4th-level divine innate spells. You can choose from the following spells each time you cast: {ToMarkdownLink<Models.Entities.Spell>("remove curse", Spells.Instances.RemoveCurse.ID)}, {ToMarkdownLink<Models.Entities.Spell>("remove disease", Spells.Instances.RemoveDisease.ID)}, and {ToMarkdownLink<Models.Entities.Spell>("neutralize poison", Spells.Instances.NeutralizePoison.ID)}." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Aasimar.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2e86bdc9-c3dd-40a8-9b72-f2e4e08ca0ee"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
