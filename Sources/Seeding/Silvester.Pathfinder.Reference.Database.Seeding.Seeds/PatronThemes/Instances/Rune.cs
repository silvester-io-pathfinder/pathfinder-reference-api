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
        public static readonly Guid ID = Guid.Parse("de684545-619e-4bab-b57b-5a095f9bf749");
        
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
            };
        }

        protected override IEnumerable<Guid> GetGrantedSpellOptions()
        {
            yield return Spells.Instances.MagicWeapon.ID;
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpellCasting(Guid.Parse("2496f0d6-1f2d-4ccc-bfa6-115f93d8b89a"), MagicTraditions.Instances.Arcane.ID);
            builder.GainSpecificSkillProficiency(Guid.Parse("d023af23-885d-432c-b343-999db6691c2a"), Proficiencies.Instances.Trained.ID, Skills.Instances.Arcana.ID);
            builder.GainSpecificSpell(Guid.Parse("1408ebfc-8714-4f20-a056-f1cce3754221"), Spells.Instances.DiscernSecrets.ID);
            builder.GainSpecificSpell(Guid.Parse("d935e0e1-574d-455d-a967-be67ed4ad02e"), Spells.Instances.MagicWeapon.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("46d35055-c419-4729-a1f0-64181117f3b2"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 99
            };
        }
    }
}
