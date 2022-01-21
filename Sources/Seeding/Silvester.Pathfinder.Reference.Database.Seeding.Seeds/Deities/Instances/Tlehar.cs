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
    public class Tlehar : Template
    {
        public static readonly Guid ID = Guid.Parse("65dca6e7-eb91-43cf-bff4-3d9229657324");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.OldSunGods.ID,
                AlignmentId = Alignments.Instances.NeutralGood.ID,
                Name = "Tlehar",
                Edicts = "Give yourself fully to everything you attempt, always maintain hope that tomorrow will be a better day, treasure every gift you are given by those who matter to you.",
                Anathema = "Lose your motivation to your regrets, spread despair, treat a loved one poorly.",
                Title = "The Rising Sun",
                AreasOfConcern = "Iron, love, and rebirth.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("7afaa5e7-dbee-4199-91b1-845cc0d1c395"), Type = TextBlockType.Text, Text = "The Lioness Goddess of iron, love, and rebirth. She is most commonly depicted as human but with the head of a lioness, her fur a dull gray and her eyes black as night." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("6ae08d35-b744-4781-9ec9-9c96db802b92"), Spells.Instances.Soothe.ID);
            builder.GainSpecificSpell(Guid.Parse("a2d546a2-0b25-4bc8-b8cd-e17ebd91c36c"), Spells.Instances.Enthrall.ID);
            builder.GainSpecificSpell(Guid.Parse("a16036ef-9a70-4668-9a8c-2494e7990c2c"), Spells.Instances.DreamingPotential.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return Items.MeleeWeapons.Instances.Morningstar.ID;
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
            yield return Skills.Instances.Crafting.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Intelligence.ID;
            yield return Stats.Instances.Charisma.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Cities.ID;
            yield return Domains.Instances.Healing.ID;
            yield return Domains.Instances.Passion.ID;
            yield return Domains.Instances.Sun.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.LawfulGood.ID;
            yield return Alignments.Instances.NeutralGood.ID;
            yield return Alignments.Instances.ChaoticGood.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("d329eff6-66d7-4d2c-96cd-7793ad4485f8"),
                SourceId = Sources.Instances.Legends.ID,
                Page = 100
            };
        }
    }
}
