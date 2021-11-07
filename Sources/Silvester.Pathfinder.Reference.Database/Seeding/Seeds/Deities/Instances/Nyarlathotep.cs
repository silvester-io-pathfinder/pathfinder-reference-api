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
    public class Nyarlathotep : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.OuterGodsAndGreatOldOnes.ID,
                AlignmentId = Alignments.Instances.ChaoticEvil.ID,
                Name = "Nyarlathotep",
                Edicts = "Sow discord among allies, misuse positions of authority by steering events toward apocalyptic ends.",
                Anathema = "None.",
                Title = "The Crawling Chaos",
                
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Nyarlathotep is a being of a thousand shapes, each of which has a name, such as theHaunter of the Darkor the Black Pharaoh. Because he has walked the world in mortal form, Nyarlathotep is unique among the Outer Gods for appearing comprehensible and understandable—but this is a facade. The Crawling Chaos, as he is also known, appears humanlike not because he identifies with mortal concerns or cares for his mortal followers, but because a mortal shape makes it easier for him to do his work: spreading the influence of the Outer Gods." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "In his role as a herald, messenger, and agent provocateur for the Outer Gods, Nyarlathotep is the Outer God most likely to have direct interactions with mortals. He answers prayers, teaches evil magic, and inserts himself into history—all to enable mortal cruelty, facilitate the release of Great Old Ones, and turn whole societies toward worship of the Outer Gods. He was instrumental in the fall of Ancient Osirion, and some believe he led Taldor to launch the Armies of Exploration, a glorious folly that proved the ruin of that empire. There are countless tales of his interaction with (and often possession of) mortal cultists and magicians who dare to call upon him, and they all end in grotesque corruption and death. Nyarlathotep also lingers among Azathoth's court, carrying out schemes under the guise of the Primal Chaos's will." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.MessageRune.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.HumanoidForm.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Enthrall.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Suggestion.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.SummonEntity.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Mislead.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.ProjectImage.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.DreamCouncil.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Weird.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return MeleeWeapons.Instances.Staff.ID;
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
            
            yield return Stats.Instances.Dexterity.ID;
            yield return Stats.Instances.Intelligence.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Knowledge.ID;
            yield return Domains.Instances.Magic.ID;
            yield return Domains.Instances.Nightmares.ID;
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
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 130
            };
        }
    }
}
