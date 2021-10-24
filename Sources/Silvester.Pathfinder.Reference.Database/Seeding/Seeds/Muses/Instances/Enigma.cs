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
        public static readonly Guid ID = Guid.Parse("");
        
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
            builder.GainSpecificFeat(Guid.Parse(""), Feats.Instances.BardicLore.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.TrueStrike.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 97
            };
        }
    }
}
