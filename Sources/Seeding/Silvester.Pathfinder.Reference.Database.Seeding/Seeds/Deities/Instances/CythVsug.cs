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
    public class CythVsug : Template
    {
        public static readonly Guid ID = Guid.Parse("b3c5ab6c-0279-4165-8afb-8830aba5dead");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.DemonLords.ID,
                AlignmentId = Alignments.Instances.ChaoticEvil.ID,
                Name = "Cyth-V'sug",
                Edicts = "Corrupt all that exists with parasites or fungus, promote the growth of fungus, feast on rotten flesh or fungus.",
                Anathema = "Purify your food, cure a disease or kill a parasite, tolerate another demon lord or their servants (except.",
                Title = "Prince of the Blasted Heath",
                AreasOfConcern = "Disease, fungus, and parasites.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("23533f3b-3248-418e-8f81-69caf576476c"), Type = TextBlockType.Text, Text = "Cyth-V'sug, Prince of the Blasted Heath, is the demon lord of disease, fungus, and parasites. Originally a qlippoth lord, he was exiled by his peers for accepting mortal worshippers. Transformed into one of the demons he despises, Cyth-V'sug seeks to devour all life to put an end to demons and, ultimately, himself. He most often appears as an enormous draconic figure of snarled vines, fungal growths, and flailing tentacles. Cyth-V'sug is most often worshipped by recluses who seek to bring decay and destruction to their environs, though denizens of the Darklands also pay homage to him." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("47ebbab4-c660-42ed-96ed-45bb62508259"), Spells.Instances.SummonPlantOrFungus.ID);
            builder.GainSpecificSpell(Guid.Parse("1d670e51-6047-4d3c-a190-67c67bd89c65"), Spells.Instances.FungalHyphae.ID);
            builder.GainSpecificSpell(Guid.Parse("bf6ac4c1-2cda-415e-9ade-82d2f61a6757"), Spells.Instances.PlantForm.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return MeleeWeapons.Instances.Scimitar.ID;
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
            yield return Domains.Instances.Change.ID;
            yield return Domains.Instances.Decay.ID;
            yield return Domains.Instances.Nature.ID;
            yield return Domains.Instances.Plague.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.ChaoticEvil.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("471065e5-fde5-4cc0-b6a3-f496801d3b42"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 124
            };
        }
    }
}
