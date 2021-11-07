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
    public class ConquerorWorm : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.OtherGods.ID,
                Name = "Conqueror Worm",
                Edicts = "Manipulate those in power, foster psychic abilities, endorse unjust laws.",
                Anathema = "Enact hasty schemes, tell the truth except to nurture a larger lie, reveal those higher in the conqueror worm's network.",
                
                
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Individual conqueror worms are lesser deities, capable of granting spells to those who worship them. Often, the conqueror worm's clerics are the only ones in its vast network of hidden agents and depraved cults with an inkling as to the nature of the malevolent creature pulling the strings. While individual conqueror worms have diferent edicts, anathema, and favored weapons beftting their personalities, the following is common among conqueror worms" };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Charm.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.MindProbe.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.WarpMind.ID);
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
            yield return Skills.Instances.Deception.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            yield break;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Ambition.ID;
            yield return Domains.Instances.Secrecy.ID;
            yield return Domains.Instances.Trickery.ID;
            yield return Domains.Instances.Tyranny.ID;
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
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.NightOfTheGrayDeath.ID,
                Page = 67
            };
        }
    }
}
