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
    public class Narriseminek : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.MonitorDemigods.ID,
                AlignmentId = Alignments.Instances.ChaoticNeutral.ID,
                Name = "Narriseminek",
                Edicts = "Divine the future, transform the bodies of willing creatures, rebel against organized structures.",
                Anathema = "Refuse to speak to a keketar, eschew a challenge by turning down a promotion or an advancement.",
                Title = "The Crownless, the Maker of Kings",
                AreasOfConcern = "Ascendance, keketars, and revelations.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Called the Crownless and the Maker of Kings, Narriseminek often appears as a protean with a scar around their pate, as if left by a burning crown. Their true form, though similar, is rarely seen: an iridescent and golden protean with a halo of burning eyes but empty eye sockets. The protean lord of ascendance, keketars, and revelations rarely interacts with non-proteans, but to their protean worshippers, they offer exalted transformations and revelations that can change a being's entire outlook. Worshippers of Narriseminek, both mortal and protean, spend their time divining the future and using magic to transform their bodies—a practice they also extend to any other willing creatures who ask. Their revelations take the form of patterns emerging in otherwise random events; Narriseminek's followers reject astrology and other forms of divination based on predictable cycles." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Mindlink.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Confusion.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Synesthesia.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return MeleeWeapons.Instances.Hatchet.ID;
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
            
            yield return Stats.Instances.Dexterity.ID;
            yield return Stats.Instances.Wisdom.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Delirium.ID;
            yield return Domains.Instances.Freedom.ID;
            yield return Domains.Instances.Knowledge.ID;
            yield return Domains.Instances.Perfection.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.ChaoticGood.ID;
            yield return Alignments.Instances.ChaoticNeutral.ID;
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
