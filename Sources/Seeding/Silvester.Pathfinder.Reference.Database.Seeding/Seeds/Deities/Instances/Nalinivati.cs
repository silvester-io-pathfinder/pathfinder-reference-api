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
        public static readonly Guid ID = Guid.Parse("8c191814-45a9-4d9f-b685-5cb4ed2756cd");

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
            builder.GainSpecificSpell(Guid.Parse("53f759c7-9584-4f07-8f3a-bbc5e48f4c68"), Spells.Instances.Charm.ID);
            builder.GainSpecificSpell(Guid.Parse("ad4e70b8-1b9f-4115-8379-17a8d1f93761"), Spells.Instances.Invisibility.ID);
            builder.GainSpecificSpell(Guid.Parse("109f48b7-266c-4c09-978d-715f6ff78fb6"), Spells.Instances.LightningBolt.ID);
            builder.GainSpecificSpell(Guid.Parse("58e5ac36-9921-426e-8757-8c9bfbba79c8"), Spells.Instances.ReflectiveScales.ID);
            builder.GainSpecificSpell(Guid.Parse("60dc87cf-ebd7-4195-9ad1-919efec7f04c"), Spells.Instances.SubconsciousSuggestion.ID);
            builder.GainSpecificSpell(Guid.Parse("4fb83130-1d11-4412-b167-46a441c3136b"), Spells.Instances.Mislead.ID);
            builder.GainSpecificSpell(Guid.Parse("e3c57f7c-7641-46f2-98f2-6956a2ed276b"), Spells.Instances.Contingency.ID);
            builder.GainSpecificSpell(Guid.Parse("7063d742-f3e1-463b-a08f-0e46ae8d988b"), Spells.Instances.ScintillatingPattern.ID);
            builder.GainSpecificSpell(Guid.Parse("a63a8963-8dbb-4f5d-aa7b-9cfa468bec2a"), Spells.Instances.StormOfVengeance.ID);
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
                Id = Guid.Parse("6b7b6f4c-ca25-45aa-85fa-5293eb8e4116"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 132
            };
        }
    }
}
