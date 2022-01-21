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
    public class Azathoth : Template
    {
        public static readonly Guid ID = Guid.Parse("93615a18-0bd9-4c8c-b25e-a256ded1b861");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.OuterGodsAndGreatOldOnes.ID,
                AlignmentId = Alignments.Instances.ChaoticNeutral.ID,
                Name = "Azathoth",
                Edicts = "Gather a court of devotees, create discordant piping or babbling.",
                Anathema = "None.",
                Title = "The Primal Chaos",
                
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("cbae5fa4-afb1-4d3e-ba7e-24a084aedc67"), Type = TextBlockType.Text, Text = "Azathoth is the Daemon Sultan and the Primal Chaos, a roiling mass of destructive and transformative power the size of a sun, dwelling in the darkness between the stars, deep in the center of the universe. There, masked from mortal sight by a veil of swirling colors, he is surrounded by the other Outer Gods that make up his court, dancing and cavorting about him endlessly, filling the void with the sound of ghastly flutes. Azathoth is utterly unaware of and uncaring toward those few who have come to revere and worship him. It is precisely this blind, uncaring nature that makes Azathoth the perfect embodiment of a blind, uncaring universe. Azathoth's name, however, has great power over the Outer Gods when properly invoked. He has also sometimes been summoned by mortal priests—and though these summons attract only a tiny sliver of his attention and manifest as a form other than that of the Primal Chaos, they nevertheless lead to destruction on a massive scale." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("ad34b195-ed1f-4717-97c1-14492698ff0c"), Spells.Instances.IllOmen.ID);
            builder.GainSpecificSpell(Guid.Parse("07bfd336-280d-4e4f-8119-9740c6e61e7f"), Spells.Instances.SynapticPulse.ID);
            builder.GainSpecificSpell(Guid.Parse("d29f2655-a9d3-4132-8af8-b4559599cf49"), Spells.Instances.UnfathomableSong.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return Items.MeleeWeapons.Instances.Warhammer.ID;
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
            
            yield return Stats.Instances.Constitution.ID;
            yield return Stats.Instances.Charisma.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Decay.ID;
            yield return Domains.Instances.Destruction.ID;
            yield return Domains.Instances.Nightmares.ID;
            yield return Domains.Instances.Void.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.ChaoticNeutral.ID;
            yield return Alignments.Instances.ChaoticEvil.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("c62efeea-fb1e-45d4-a8dd-29c1e0e01e43"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 130
            };
        }
    }
}
