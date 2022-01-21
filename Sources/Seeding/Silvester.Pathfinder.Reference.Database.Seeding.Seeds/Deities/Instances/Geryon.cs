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
    public class Geryon : Template
    {
        public static readonly Guid ID = Guid.Parse("42ed7846-cbd2-408b-b392-d5bbf1940bac");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.Archdevils.ID,
                AlignmentId = Alignments.Instances.LawfulEvil.ID,
                Name = "Geryon",
                Edicts = "Hoard knowledge, test the boundaries of taboo, spread falsehoods to dupe the foolhardy.",
                Anathema = "Declare knowledge heresy or forbidden, break your word.",
                Title = "The Serpent",
                
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("07e229f5-b338-4590-a616-1fd3bc1b80df"), Type = TextBlockType.Text, Text = "Once the mightiest of asura ranas, Geryon betrayed hundreds of Hell's original asura inhabitants to aid Asmodeus in claiming the plane, in the process earning himself the title the Source of Lies. His realm of Stygia, Hell's fifth layer, hews most closely to the nature of Hell before Asmodeus reshaped the plane, and it contains the sunken ruins of countless cities and libraries predating the war against Heaven. The archdevil hoards knowledge and secrets—especially that which has been forbidden— while spreading falsehoods and heresies to mislead the ignorant, and his followers revel in the same." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("0bc3aa00-2904-4916-8c59-129f52875686"), Spells.Instances.AcidicBurst.ID);
            builder.GainSpecificSpell(Guid.Parse("7a50d534-20c0-4859-809f-d1b4354904d3"), Spells.Instances.AnimalForm.ID);
            builder.GainSpecificSpell(Guid.Parse("da6ad6ec-5ce0-4872-930e-672427b28655"), Spells.Instances.Hypercognition.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return Items.MeleeWeapons.Instances.WarFlail.ID;
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
            yield return Skills.Instances.Occultism.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Intelligence.ID;
            yield return Stats.Instances.Wisdom.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Might.ID;
            yield return Domains.Instances.Truth.ID;
            yield return Domains.Instances.Water.ID;
            yield return Domains.Instances.Wyrmkin.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.LawfulEvil.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("5fdf2ae9-7271-470b-a2a2-c29ceb48e143"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 124
            };
        }
    }
}
