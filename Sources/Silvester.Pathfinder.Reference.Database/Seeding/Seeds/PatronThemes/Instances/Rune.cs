using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PatronThemes.Instances
{
    public class Rune : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override PatronTheme GetPatronTheme()
        {
            return new PatronTheme
            {
                Id = ID, 
                Name = "Rune",
                Description = "Your patron is one of sigils and symbols, tomes and texts, words and wisdom.",
                RarityId = Rarities.Instances.Common.ID,
                PatronSkillId = Skills.Instances.Arcana.ID,
                MagicTraditionId = MagicTraditions.Instances.Arcane.ID,
                HexCantripId = Spells.Instances.DiscernSecrets.ID,
            };
        }

        protected override IEnumerable<Guid> GetGrantedSpellOptions()
        {
            yield return Spells.Instances.MagicWeapon.ID;
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpellCasting(Guid.Parse(""), MagicTraditions.Instances.Arcane.ID);
            builder.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Arcana.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.DiscernSecrets.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.MagicWeapon.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 99
            };
        }
    }
}
