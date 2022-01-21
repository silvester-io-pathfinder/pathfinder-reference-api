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
    public class Trelmarixian : Template
    {
        public static readonly Guid ID = Guid.Parse("e2713cbd-4366-410b-93a8-a7f25cf3100f");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.Horsemen.ID,
                AlignmentId = Alignments.Instances.NeutralEvil.ID,
                Name = "Trelmarixian",
                Edicts = "End all mortal life through wasting consumption and starvation, violently consume matter and souls.",
                Anathema = "Kill or remove a parasite or tumor, grow food.",
                Title = "The Lysogenic Prince",
                AreasOfConcern = "Famine.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("08216517-4f39-48e1-9320-30d76e9d76f2"), Type = TextBlockType.Text, Text = "Before his mortal death, Trelmarixian had already destroyed an entire world. Born a daemonic-blooded tiefling, his hatred of those around him was an all-consuming hunger, and he never knew peace. During an eclipse, he performed a ritual so powerful it mummified every living creature on his world, and his heart was finally full. Dying from starvation but elated by his success, Trelmarixian heard a voice call out to him. The voice mocked him, exclaiming all he'd accomplished was insignificant compared to what awaited him next. Trelmarixian's last mortal memory was of staring into an eclipse." };
            yield return new TextBlock { Id = Guid.Parse("0d8baab8-0964-485a-96d4-a9fead7a0d5c"), Type = TextBlockType.Text, Text = "Lyutheria, the original Horseman of Famine, was impressed by Trelmarixian's conquest and took him on as her apprentice, fatally underestimating his ambitions. After Trelmarixian learned all he could from his master, he devoured her and assumed her title." };
            yield return new TextBlock { Id = Guid.Parse("018e236e-406d-45aa-8f96-8a07cd41f920"), Type = TextBlockType.Text, Text = "Trelmarixian appears as sickly man with three snapping jackal heads and putrid, membranous flesh that is constantly dripping and sloughing off his body. As the Horseman of Famine, Trelmarixian ushers in oblivion slowly, watching mortals waste away as their bodies turn against them. He spreads cancer by touch, inciting cells to rebellion, and his breath causes outbreaks of hives and asthma attacks in those nearby. He aligns himself with Szuriel to see that soldiers never make it home to reap their fields, leaving crops to rot on the vine. He collaborates with Apollyon to spread diseases from livestock, rendering butchers' larders barren. Trelmarixian has little trust for Charon, however, certain that the oldest Horseman is hiding secrets." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("82ff69f7-fe78-40f7-92db-7193088bbae0"), Spells.Instances.Grease.ID);
            builder.GainSpecificSpell(Guid.Parse("86e1a63f-a85b-49e6-83f7-01c4dc20dbf2"), Spells.Instances.FeastOfAshes.ID);
            builder.GainSpecificSpell(Guid.Parse("d78f2e76-b06b-40c4-88b8-4c53a35654f0"), Spells.Instances.AcidStorm.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return Items.MeleeWeapons.Instances.SpikedGauntlet.ID;
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
            yield return Skills.Instances.Nature.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Constitution.ID;
            yield return Stats.Instances.Wisdom.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Decay.ID;
            yield return Domains.Instances.Dust.ID;
            yield return Domains.Instances.Earth.ID;
            yield return Domains.Instances.Nightmares.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.LawfulEvil.ID;
            yield return Alignments.Instances.NeutralEvil.ID;
            yield return Alignments.Instances.ChaoticEvil.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("86287ab1-e2c9-428d-ba86-f01086dfd9a5"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 130
            };
        }
    }
}