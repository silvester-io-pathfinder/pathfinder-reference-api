using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Muses.Instances
{
    public class Enigma : Template
    {
        public static readonly Guid ID = Guid.Parse("57e64b8c-9ae0-4270-9e6b-b547024b1618");
        
        protected override Muse GetMuse()
        {
            return new Muse
            {
                Id = ID, 
                Name = "Enigma",
                Description = "Your muse is a mystery, driving you to uncover the hidden secrets of the multiverse. If your muse is a creature, it might be a dragon or otherworldly being; if a deity, it might be Irori or Nethys. You gain the Bardic Lore feat and add true strike to your spell repertoire."
            };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificFeat(Guid.Parse("900aa644-69cd-4975-9275-73b57546fead"), Feats.Instances.BardicLore.ID);
            builder.GainSpecificSpell(Guid.Parse("7a036324-5ffe-45f8-853b-8324b78a03fe"), Spells.Instances.TrueStrike.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("83cfdac3-a6b9-4b0e-ac07-c9e2853a32fd"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 97
            };
        }
    }
}
