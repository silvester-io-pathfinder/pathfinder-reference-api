using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SummonEarthElemental : Template
    {
        public static readonly Guid ID = Guid.Parse("d074ca4c-0b26-40de-bed4-6e024182b09d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Summon Earth Elemental",
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
            yield return new TextBlock { Id = Guid.Parse("bc65ca4b-52f0-4c5a-91e5-f7d128768376"), Type = TextBlockType.Text, Text = $"You have a connection to the Inner Sphere, allowing you to summon an elemental ally. Once per day, you can cast {ToMarkdownLink<Models.Entities.Spell>("summon elemental", Spells.Instances.SummonElemental.ID)} as a 5th-level primal innate spell, but the elemental summoned must be an {ToMarkdownLink<Models.Entities.Trait>("earth", Traits.Instances.Earth.ID)} elemental." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a2a502d7-ec62-4eb9-aa73-d01f2ff43bc4"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
