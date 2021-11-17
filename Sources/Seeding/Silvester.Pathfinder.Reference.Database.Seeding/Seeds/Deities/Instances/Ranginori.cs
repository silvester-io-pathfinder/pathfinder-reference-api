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
    public class Ranginori : Template
    {
        public static readonly Guid ID = Guid.Parse("8e2f86a7-d728-442c-af37-49c758785a61");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.ElementalLords.ID,
                AlignmentId = Alignments.Instances.NeutralGood.ID,
                Name = "Ranginori",
                Edicts = "Open closed areas to fresh air, travel throughout your surroundings daily, fly or make creations that fly.",
                Anathema = "Wrongfully imprison a creature, restrain a creature longer or more tightly than is necessary, suffocate a creature.",
                Title = "Zephyrous Prince",
                AreasOfConcern = "Air, welcome breezes, and thunderstorms.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("6f7e354c-2093-42ac-93a9-f9e2a3c693de"), Type = TextBlockType.Text, Text = "The benevolent elemental lord of air is Ranginori, the Zephyrous Prince, lord of air, welcome breezes, and thunderstorms. When he appears before mortals, Ranginori takes the form of an immense, lion-headed serpent spun from forbidding clouds, with hundreds of clawed feet and a mane that dances with lightning. Recently freed from his imprisonment within theUntouchable Opalby agents of the Pathfinder Society, the Zephyrous Prince has accumulated a small but loyal following in search of liberation, hope, and change for the multiverse. He is regaining his strength and preparing to find and liberate the other benevolent elemental lords, bringing balance back to the Elemental Planes." };
            yield return new TextBlock { Id = Guid.Parse("88018ad1-d122-40be-9e89-2cf15dfbcbb4"), Type = TextBlockType.Text, Text = "As the single free benevolent elemental lord, Ranginori is in a vulnerable situation, in desperate need of allies and followers to aid him against the combined might of the evil elemental lords. He has reestablished his realm on thePlane of Air: the Roaring Spark, a floating spiral of ruins that branch outward from a central crack of thunder. As the elemental lord regains his power and his domain returns to life, the vestiges of his ancient keeps and towers rebuild themselves while new branches form." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("3fc30bf3-15b9-442d-9f9e-0a8ffc4cfc27"), Spells.Instances.LiberatingCommand.ID);
            builder.GainSpecificSpell(Guid.Parse("651ea4d3-b80c-4375-bb7b-cc0b3b790d0f"), Spells.Instances.Fly.ID);
            builder.GainSpecificSpell(Guid.Parse("c9cce32d-733b-46a4-a665-6d9a50f94d60"), Spells.Instances.ChainLightning.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return MeleeWeapons.Instances.Whip.ID;
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
            yield return Skills.Instances.Acrobatics.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Dexterity.ID;
            yield return Stats.Instances.Charisma.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Air.ID;
            yield return Domains.Instances.Freedom.ID;
            yield return Domains.Instances.Lightning.ID;
            yield return Domains.Instances.Travel.ID;
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
                Id = Guid.Parse("f987e747-6b08-4223-856e-1164490ea750"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 128
            };
        }
    }
}
