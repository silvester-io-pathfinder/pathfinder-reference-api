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
    public class Mammon : Template
    {
        public static readonly Guid ID = Guid.Parse("92b934ab-72f9-43b5-a759-10420e398e8b");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.Archdevils.ID,
                AlignmentId = Alignments.Instances.LawfulEvil.ID,
                Name = "Mammon",
                Edicts = "Gain financial control over others, gather new wealth, count your riches.",
                Anathema = "Leave the cult of Mammon, allow those who steal from you to go unpunished.",
                Title = "The Argent Prince",
                
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("991bdfa3-271c-456c-8240-f0cf8c724bcf"), Type = TextBlockType.Text, Text = "Mammon, the Grasping One, oversees the vast treasuries of Hell secured in the vaults of Erebus, Hell's third layer. As his angelic form was slain, he has no form of his own, so instead he infuses the very wealth that he guards, taking forms composed of riches and extending his senses out through each nigh-uncountable coin—he knows well the exact sum held in Hell's vaults and the greatest treasures among them. His worshippers are the greedy rich and poor alike, and he often arranges for such mortals to stumble across a “lucky copper” through which he whispers encouragements for the bearer to indulge in greater and greater vices, eventually claiming their soul as his own." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("5ac1d47c-de7e-4902-b5a7-a594d7895105"), Spells.Instances.ShatteringGem.ID);
            builder.GainSpecificSpell(Guid.Parse("32932b15-d898-4b92-b848-5fe0cb3d783f"), Spells.Instances.Creation.ID);
            builder.GainSpecificSpell(Guid.Parse("fcb6fe8f-3149-4591-875f-707428e354d5"), Spells.Instances.MagnificentMansion.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return Items.MeleeWeapons.Instances.Spear.ID;
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
            yield return Skills.Instances.Thievery.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Wisdom.ID;
            yield return Stats.Instances.Charisma.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Ambition.ID;
            yield return Domains.Instances.Creation.ID;
            yield return Domains.Instances.Toil.ID;
            yield return Domains.Instances.Wealth.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.LawfulEvil.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("6407500a-f01a-497a-adf8-10e5d8d8753b"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 124
            };
        }
    }
}
