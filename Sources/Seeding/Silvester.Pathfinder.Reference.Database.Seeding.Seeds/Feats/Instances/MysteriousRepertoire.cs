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
    public class MysteriousRepertoire : Template
    {
        public static readonly Guid ID = Guid.Parse("5bebf864-e41d-4661-9d95-72ca692b29a1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mysterious Repertoire",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("84db77d3-65db-4ffc-97f8-91acfea035f0"), Type = TextBlockType.Text, Text = $"Your mystery holds unknowable depths of magic not always associated with the divine. You can have one spell in your spell repertoire not on the divine spell list, in addition to spells you've added to your spell list from feats like {ToMarkdownLink<Models.Entities.Feat>("Divine Access", Feats.Instances.DivineAccess.ID)}. You cast that spell as a divine spell. You can swap which spell you add and from which tradition as you could any other oracle spell, but you can't use this feat to have more than one spell from another tradition in your spell repertoire at the same time." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Oracle.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ae261fe5-7780-41e6-a0a9-64d92c094567"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
