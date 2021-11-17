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
    public class Kelizandri : Template
    {
        public static readonly Guid ID = Guid.Parse("799805e2-7911-4017-a2cb-16d9764527b5");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.ElementalLords.ID,
                AlignmentId = Alignments.Instances.NeutralEvil.ID,
                Name = "Kelizandri",
                Edicts = "Instill hydrophobia in others, kill your foes by drowning them, sacrifice treasures to the depths of the ocean.",
                Anathema = "Destroy a body of water, use magic to calm the waves.",
                Title = "The Brackish Emperor",
                AreasOfConcern = "The deep sea, waves, and drowning.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("f3490a0b-c1eb-421c-a045-4359f98d945e"), Type = TextBlockType.Text, Text = "Kelizandri, the elemental lord of water, oversees the deep sea, waves, and drowning. The Brackish Emperor claims to be the offspring of an ancient god and abrine dragon, and he usually takes the form of an immense aquatic dragon with metallic scales and crystalline talons. He spends much of his time slumbering in his magnificent Palace of Salt and Bones, entertaining himself with rampages of wanton destruction and conquest whenever he wakes." };
            yield return new TextBlock { Id = Guid.Parse("e0f7e618-bd08-41f9-bb93-3644d95e295d"), Type = TextBlockType.Text, Text = "Kelizandri's worshippers include brine dragons,water elementals, and mortals who revere the inhospitable unknowns of the deep sea. He holds no love formarids, having killed the last Saline Padishah, Niloufar the Great, and destroyed her capital city of Arzanib. The lord's domain on thePlane of Wateris the Brackish Empire Kelizandrika, a conglomeration of affiliated brine dragon–controlled realms. The most powerful dragons of Kelizandrika's ruling councils are said to advise the elemental lord personally." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("e494ebee-0898-4213-9a13-fe9dc3c3c8c2"), Spells.Instances.Fear.ID);
            builder.GainSpecificSpell(Guid.Parse("f1a6e65b-52d9-41cd-8a64-9ccb509c5946"), Spells.Instances.SummonElemental.ID);
            builder.GainSpecificSpell(Guid.Parse("bbbf4c8c-14d8-4c52-9fd7-28eee71febc0"), Spells.Instances.HydraulicTorrent.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return MeleeWeapons.Instances.Trident.ID;
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
            yield return Skills.Instances.Athletics.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Constitution.ID;
            yield return Stats.Instances.Charisma.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Destruction.ID;
            yield return Domains.Instances.Nightmares.ID;
            yield return Domains.Instances.Travel.ID;
            yield return Domains.Instances.Water.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.TrueNeutral.ID;
            yield return Alignments.Instances.LawfulEvil.ID;
            yield return Alignments.Instances.NeutralEvil.ID;
            yield return Alignments.Instances.ChaoticEvil.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("85559795-bbe5-43f6-8959-c524edc1f09d"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 126
            };
        }
    }
}
