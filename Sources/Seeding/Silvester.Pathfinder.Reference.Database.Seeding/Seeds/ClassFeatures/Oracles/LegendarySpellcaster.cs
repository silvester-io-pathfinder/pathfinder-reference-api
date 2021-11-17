using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Oracles
{
    public class LegendarySpellcaster : Template
    {
        public static readonly Guid ID = Guid.Parse("a0fc65a1-fef8-4dc2-91e6-741e6efd5d9a");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 19,
                Name = "Legendary Spellcaster", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("7d262a7d-9097-4c9c-9be7-ed8efeb09c4b"), Type = TextBlockType.Text, Text = "You can harness divine power at a level few others can match. Your proficiency ranks for divine spell attack rolls and spell DCs increase to legendary." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpellAttackProficiency(Guid.Parse("a4d73f65-08ae-47c2-87e1-8c9950dedbe0"), Proficiencies.Instances.Legendary.ID);
            builder.GainSpecificSpellDcProficiency(Guid.Parse("6cdfb705-0d73-4840-bbfb-2ae1c1c1721c"), Proficiencies.Instances.Legendary.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("46cf1509-2f05-416b-8049-0564e08a91fb"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 72
            };
        }
    }
}
