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
    public class Atreia : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.ElementalLords.ID,
                AlignmentId = Alignments.Instances.NeutralGood.ID,
                Name = "Atreia",
                Edicts = "Burn away corruption, clear the way for new growth, purify tainted areas.",
                Anathema = "Deny a suffering creature warmth, shade, or water; abandon a creature in darkness.",
                Title = "The Lambent King",
                AreasOfConcern = "Fire, purification, and radiance.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Responsible for fire, purification, and radiance, Atreia the Lambent King is the benevolent elemental lord of fire. When the multiverse was young, Atreia soared across thePlane of Fireas a triple-headed ibis, with wings that burned and eyes of flame, routing evil from the plane. Now, he is imprisoned within theGarnet Brand, a red gem encased in an eternal shroud of steam. Though he cannot hear or grant power to his followers from his prison, some groups ofsalamanderson the Plane of Fire still honor the Lambent King for his dominion over protection and life-giving fire, as do a few small circles of mortals who hold the discovery and purification of evil above all other causes. Statues depicting his likeness can be found across his former realms, hidden in ancient sites dedicated to healing and holy light." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Soothe.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.GhostlyWeapon.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.FireShield.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return MeleeWeapons.Instances.Katar.ID;
        }

        protected override IEnumerable<Guid> GetFavoredRangedWeapons()
        {
            yield break;
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
            yield return Skills.Instances.Performance.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Wisdom.ID;
            yield return Stats.Instances.Charisma.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Fire.ID;
            yield return Domains.Instances.Healing.ID;
            yield return Domains.Instances.Protection.ID;
            yield return Domains.Instances.Sun.ID;
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
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 126
            };
        }
    }
}
