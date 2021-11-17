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
    public class Shax : Template
    {
        public static readonly Guid ID = Guid.Parse("cdc7a5c4-71e7-4296-bd43-41456f915adf");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.DemonLords.ID,
                AlignmentId = Alignments.Instances.ChaoticEvil.ID,
                Name = "Shax",
                Edicts = "Plot and commit murders, tell lies, torture creatures.",
                Anathema = "Sleep in a building with fewer than ﬁve rooms, allow a victim to escape due to gloating.",
                Title = "The Bloody Marquis",
                AreasOfConcern = "Envy, lies, and sadistic murders.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("909dd5f2-73af-4681-a491-5b27b9173c91"), Type = TextBlockType.Text, Text = "Shax, the Blood Marquis, is the demon lord of envy, lies, and sadistic murders. Shax's capacity for cruelty is legendary even among the ranks of demon lords, and he takes extreme pleasure in watching the last light of hope fade from the eyes of his victims. He is the original creator of the babau demons, and those whom he personally flays and corrupts with Abyssal influence remain exemplars of their kind. Shax appears as a human man with a dove's head, feet, and wings, carrying countless knives and other weapons all over his body. Shax is most frequently worshipped by sadists, lone murderers, and serial killers." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("ff36480c-7c8c-42e0-a764-27c9f1f6dac2"), Spells.Instances.PhantomPain.ID);
            builder.GainSpecificSpell(Guid.Parse("946db64f-9add-42ec-8c23-df79d785971d"), Spells.Instances.Invisibility.ID);
            builder.GainSpecificSpell(Guid.Parse("79efafdf-c289-4960-95a1-9184cb38c65a"), Spells.Instances.Haste.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return MeleeWeapons.Instances.Dagger.ID;
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
            yield return Skills.Instances.Intimidation.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Dexterity.ID;
            yield return Stats.Instances.Charisma.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Ambition.ID;
            yield return Domains.Instances.Death.ID;
            yield return Domains.Instances.Pain.ID;
            yield return Domains.Instances.Trickery.ID;
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
                Id = Guid.Parse("5ecdfac6-d981-458e-bbdc-dcbd97031da3"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 126
            };
        }
    }
}
