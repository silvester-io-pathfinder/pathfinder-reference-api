using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Deities.Instances
{
    public class Nalinivati : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.TianGods.ID,
                AlignmentId = Alignments.Instances.TrueNeutral.ID,
                Name = "Nalinivati",
                Edicts = "Seek out magic and use it, use poison, heal poisons, bear or adopt children, raise snakes.",
                Anathema = "Kill a harmless snake or swan, spurn friends due to jealousy or romantic competition, betray your offspring, separate lovers.",
                Title = "The Serpent's Kiss",
                
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield break;
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Charm.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Invisibility.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.LightningBolt.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.ReflectiveScales.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.SubconsciousSuggestion.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Mislead.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Contingency.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.ScintillatingPattern.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.StormOfVengeance.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return MeleeWeapons.Instances.Urumi.ID;
        }

        protected override IEnumerable<Guid> GetFavoredRangedWeapons()
        {
            yield break;
        }

        protected override IEnumerable<Guid> GetFavoredUnarmedWeapons()
        {
            
            yield return UnarmedWeapons.Instances.Jaws.ID;
        }

        protected override DivineIntercession? GetDivineIntercession()
        {
            return null;
        }

        protected override IEnumerable<Guid> GetDivineSkills()
        {
            yield return Skills.Instances.Arcana.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Wisdom.ID;
            yield return Stats.Instances.Charisma.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Glyph.ID;
            yield return Domains.Instances.Magic.ID;
            yield return Domains.Instances.Passion.ID;
            yield return Domains.Instances.Wyrmkin.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.NeutralGood.ID;
            yield return Alignments.Instances.LawfulNeutral.ID;
            yield return Alignments.Instances.TrueNeutral.ID;
            yield return Alignments.Instances.NeutralEvil.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 132
            };
        }
    }
}
