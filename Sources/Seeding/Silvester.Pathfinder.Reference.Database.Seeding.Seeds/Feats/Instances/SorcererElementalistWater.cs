using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SorcererElementalistWater : Template
    {
        public static readonly Guid ID = Guid.Parse("26d258c0-1be9-45cc-8fed-059acba155c7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sorcerer Elementalist - Water",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a3e9e9fa-30d2-4a55-ab60-0a6dbebdbf4b"), Type = TextBlockType.Text, Text = $"You replace your initial bloodline spell with the initial water elemental focus spell ({ToMarkdownLink<Models.Entities.Spell>("rising surf", Spells.Instances.RisingSurf.ID)}), and your advanced bloodline spell (if you get it) with the advanced water elemental focus spell ({ToMarkdownLink<Models.Entities.Spell>("pulverizing cascade", Spells.Instances.PulverizingCascade.ID)})." };
            yield return new TextBlock { Id = Guid.Parse("2ce49c2a-f41e-488a-8978-d083d7414c6c"), Type = TextBlockType.Text, Text = $"You can only select this option if your bloodline's elemental type is water." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f067ac6d-0e30-46dc-95de-532cb887ac3d"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
