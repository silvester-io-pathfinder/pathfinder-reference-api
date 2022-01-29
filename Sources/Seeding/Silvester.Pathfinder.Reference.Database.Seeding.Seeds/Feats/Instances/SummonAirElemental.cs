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
    public class SummonAirElemental : Template
    {
        public static readonly Guid ID = Guid.Parse("20fe5893-d377-44d9-889e-b7dedd3efdd6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Summon Air Elemental",
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
            yield return new TextBlock { Id = Guid.Parse("9d0681f1-f399-4131-8f97-0666f12732ba"), Type = TextBlockType.Text, Text = $"You have a connection to the Inner Spheres, allowing you to summon an elemental ally. Once per day, you can cast {ToMarkdownLink<Models.Entities.Spell>("summon elemental", Spells.Instances.SummonElemental.ID)} as a 5th-level primal innate spell, but the elemental summoned must be an {ToMarkdownLink<Models.Entities.Trait>("air", Traits.Instances.Air.ID)} elemental." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("28cd985b-c781-4ba2-9a30-39752428cf60"), Traits.Instances.Sylph.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("401b09f1-0d1f-417b-93df-d46b274c1822"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
