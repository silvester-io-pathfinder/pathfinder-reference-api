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
    public class Irez : Template
    {
        public static readonly Guid ID = Guid.Parse("58a10c8e-884e-4fa9-aa2f-57011f0e3bfd");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.EmpyrealLords.ID,
                AlignmentId = Alignments.Instances.NeutralGood.ID,
                Name = "Irez",
                Edicts = "Read fortunes, practice calligraphy, devise and study runes.",
                Anathema = "Destroy magic scrolls, cheat at games of chance, deliberately write illegibly.",
                Title = "Lady of Inscribed Wonder",
                AreasOfConcern = "Glyphs, scribes, and spells.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("488d18bb-01c2-4840-a77c-fd32ed1e89ec"), Type = TextBlockType.Text, Text = "Cards, glyphs, scribes, and spells are all the purview of the Lady of Inscribed Wonder. She holds knowledge and understanding of the great power and symbolism behind runes. In particular, Irez understands how runes can supplement and empower arcane magic. It's through this understanding that Irez is able to make enigmatic predictions on events in the distant future, which more often than not come to pass. Many of her followers are calligraphers, gamblers, harrow readers and others who regularly handle cards and symbols, be they for an arcane purpose, prophetic practices, or their more mundane applications." };
            yield return new TextBlock { Id = Guid.Parse("2d4390bd-65ab-4b66-9eb0-54deb649d4eb"), Type = TextBlockType.Text, Text = "Those who have seen Irez, either in person or through the cards, describe her as a woman with the body of a powerful serpent and large wings resembling those of a bat. Irez is constantly draped with strips of parchment, each bearing glyphs that bear the secret to a particular spell or specific cards, such as the harrow's Tyrant card." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("57357f06-d054-4320-92e2-9ac7f13affed"), Spells.Instances.AnticipatePeril.ID);
            builder.GainSpecificSpell(Guid.Parse("63ab59b8-9ad7-477d-ad52-d9a30d1f8f8d"), Spells.Instances.MirrorImage.ID);
            builder.GainSpecificSpell(Guid.Parse("d217bc00-7b29-419a-83a7-2c36f505cb22"), Spells.Instances.SecretPage.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            yield break;
        }

        protected override IEnumerable<Guid> GetFavoredRangedWeapons()
        {
            
            yield return RangedWeapons.Instances.Dart.ID;
        }

        protected override IEnumerable<Guid> GetFavoredUnarmedWeapons()
        {
            yield break;
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
            
            yield return Stats.Instances.Dexterity.ID;
            yield return Stats.Instances.Intelligence.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Fate.ID;
            yield return Domains.Instances.Glyph.ID;
            yield return Domains.Instances.Luck.ID;
            yield return Domains.Instances.Magic.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.LawfulGood.ID;
            yield return Alignments.Instances.NeutralGood.ID;
            yield return Alignments.Instances.ChaoticGood.ID;
            yield return Alignments.Instances.TrueNeutral.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("3c120ef8-df90-4d79-a261-a2df44f9f1af"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 128
            };
        }
    }
}
