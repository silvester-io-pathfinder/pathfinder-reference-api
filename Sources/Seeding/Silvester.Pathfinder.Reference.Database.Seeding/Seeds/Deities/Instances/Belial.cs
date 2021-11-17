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
    public class Belial : Template
    {
        public static readonly Guid ID = Guid.Parse("8772352b-68f2-4d0b-ab2c-06c023f0d800");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.Archdevils.ID,
                AlignmentId = Alignments.Instances.LawfulEvil.ID,
                Name = "Belial",
                Edicts = "Indulge your basest desires, create deadly weapons.",
                Anathema = "Impede an act of high hedonism, become too attached to a lover or project.",
                Title = "The Pale Kiss",
                
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("c5296a11-0026-4176-98d5-0e20dff38f30"), Type = TextBlockType.Text, Text = "The lord of Hell's fourth layer, Phlegethon, is Belial. The Pale Kiss was created by Asmodeus as an object of adoration, with perfect form and beauty in the eyes of every creature. As a result, Belial has a virtually unlimited malleability of form, shifting between shapes almost constantly. His appearance is often as dualistic as his personality: half his body beautiful and half grotesque, much as he revels equally in pleasure and pain. As he is a creature of carnal desires, so are his followers: those who crave forbidden pleasures of the flesh but hide behind masks of respectability." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("3285c7cc-6604-42e0-9937-6f33ccb6b55a"), Spells.Instances.Charm.ID);
            builder.GainSpecificSpell(Guid.Parse("a05becef-9271-4cd4-90fc-fecdec53c4ea"), Spells.Instances.HumanoidForm.ID);
            builder.GainSpecificSpell(Guid.Parse("1e8479a4-abd9-4fa1-abf6-278c5590bfe9"), Spells.Instances.Enthrall.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return MeleeWeapons.Instances.Ranseur.ID;
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
            yield return Skills.Instances.Diplomacy.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Intelligence.ID;
            yield return Stats.Instances.Charisma.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Change.ID;
            yield return Domains.Instances.Passion.ID;
            yield return Domains.Instances.Trickery.ID;
            yield return Domains.Instances.Zeal.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.LawfulEvil.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("077d7fe5-360c-45f3-839b-0d71e44cac58"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 124
            };
        }
    }
}
