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
    public class Uvuko : Template
    {
        public static readonly Guid ID = Guid.Parse("a4d05e8f-f05f-47ed-93c9-b736e206ec7c");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.OtherGods.ID,
                AlignmentId = Alignments.Instances.ChaoticGood.ID,
                Name = "Uvuko",
                Edicts = "Embrace change and the future, master adversity with flexibility, foster freedom and progress for others.",
                Anathema = "Allow yourself and your surroundings to stagnate, crush an egg, use vile or cruel language.",
                Title = "The Diamond Ring",
                AreasOfConcern = "Metamorphosis, cycles, growth, fertility.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("7b53cf02-77da-4f3c-ab6b-71e96d94964a"), Type = TextBlockType.Text, Text = "The god Uvuko dances across the land, his body forming the boundary between earth and sky. His twisting tail churns the air into clouds, his creations spreading water to all those who thirst. His sliding scales till the earth, bringing forth plants that are nourished by Uvuko's rains. The worship of Uvuko is widespread in the Mwangi Expanse, found among manylizardfolktribes, Mbe'ke and Taraludwarves, and in the more cosmopolitan cities." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("f9ef48f5-b62b-464a-9e37-2930bba778de"), Spells.Instances.FleetStep.ID);
            builder.GainSpecificSpell(Guid.Parse("358a5f0a-bec4-454b-9472-e4474fc444dc"), Spells.Instances.Haste.ID);
            builder.GainSpecificSpell(Guid.Parse("e5eafad3-a7c4-43b7-a59a-569dcc966a5a"), Spells.Instances.DragonForm.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return MeleeWeapons.Instances.Maul.ID;
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
            yield return Skills.Instances.Athletics.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Strength.ID;
            yield return Stats.Instances.Wisdom.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Change.ID;
            yield return Domains.Instances.Creation.ID;
            yield return Domains.Instances.Healing.ID;
            yield return Domains.Instances.Wyrmkin.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.NeutralGood.ID;
            yield return Alignments.Instances.ChaoticGood.ID;
            yield return Alignments.Instances.TrueNeutral.ID;
            yield return Alignments.Instances.ChaoticNeutral.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("3c8d749a-6822-42ca-ad42-7838c987d2a5"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = 142
            };
        }
    }
}
