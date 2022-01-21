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
    public class Abraxas : Template
    {
        public static readonly Guid ID = Guid.Parse("2e1078d1-4480-41dc-88b4-574c4bb2e723");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.DemonLords.ID,
                AlignmentId = Alignments.Instances.ChaoticEvil.ID,
                Name = "Abraxas",
                Edicts = "Learn and hoard forbidden magic, steal secrets from others.",
                Anathema = "Destroy forbidden lore, reveal the entirety of a secret.",
                Title = "Master of the Final Incantation",
                AreasOfConcern = "Forbidden lore, magic, and snakes.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("6f4e0457-36f4-4240-9115-3908c0dcaafa"), Type = TextBlockType.Text, Text = "Abraxas, the Master of the Final Incantation, is the demon lord of forbidden lore, magic, and snakes. Abraxas has an encyclopedic knowledge of magical formulas and destructive secrets, favoring those that inflict suffering and destruction. His Final Incantation is a word of power that can unravel the mightiest of spells and unmake even artifacts. He takes the form of a viper-legged humanoid with a fanged, deformed bird's head. Abraxas's cults are most prevalent among the drow of Golarion, but small circles devoted to him can be found in most major cities on the surface as well." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("c8395d57-ce6a-4bc0-bc8b-487b36d23706"), Spells.Instances.ShareLore.ID);
            builder.GainSpecificSpell(Guid.Parse("67b2ecbc-b62b-493d-8882-a8c2e01eb91e"), Spells.Instances.SpectralHand.ID);
            builder.GainSpecificSpell(Guid.Parse("30c51989-c8d9-456a-9232-07f1dfcb5566"), Spells.Instances.Hypercognition.ID);
            builder.GainSpecificSpell(Guid.Parse("08a81441-0dc9-4b05-b4ca-6852eab3376d"), Spells.Instances.ReflectiveScales.ID);
            builder.GainSpecificSpell(Guid.Parse("a3636800-56a7-4524-93fa-34e69ca50e47"), Spells.Instances.BlackTentacles.ID);
            builder.GainSpecificSpell(Guid.Parse("b47edfa8-b43f-4c52-96bb-b8401a770d7b"), Spells.Instances.Feeblemind.ID);
            builder.GainSpecificSpell(Guid.Parse("4069f44b-0244-4e54-8eec-6396c152a60f"), Spells.Instances.SpellTurning.ID);
            builder.GainSpecificSpell(Guid.Parse("f046f2f7-6446-4565-977d-44d57e282bf2"), Spells.Instances.UnrelentingObservation.ID);
            builder.GainSpecificSpell(Guid.Parse("137cbba1-073a-47b9-a3a2-231b8ccd2c47"), Spells.Instances.Disjunction.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return Items.MeleeWeapons.Instances.Whip.ID;
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
            yield return Skills.Instances.Arcana.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Intelligence.ID;
            yield return Stats.Instances.Wisdom.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Destruction.ID;
            yield return Domains.Instances.Knowledge.ID;
            yield return Domains.Instances.Magic.ID;
            yield return Domains.Instances.Wyrmkin.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.NeutralEvil.ID;
            yield return Alignments.Instances.ChaoticEvil.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("edbfc764-e7df-4396-a6e4-d0aebfe5d036"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 124
            };
        }
    }
}
