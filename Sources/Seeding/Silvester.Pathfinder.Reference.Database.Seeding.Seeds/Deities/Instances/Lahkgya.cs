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
    public class Lahkgya : Template
    {
        public static readonly Guid ID = Guid.Parse("f136c0b8-acce-43d1-b47e-0c7819f76b45");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.VudraniGods.ID,
                AlignmentId = Alignments.Instances.ChaoticEvil.ID,
                Name = "Lahkgya",
                Edicts = "Steal luxuries for yourself, destroy property for fun, demand bribes to spare creatures from your torments.",
                Anathema = "Work honestly for something you could steal instead, kill a monkey.",
                Title = "Patron of Monkeys",
                
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield break;
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("c42a3457-b5bd-4346-a322-bbf6437e2a90"), Spells.Instances.FleetStep.ID);
            builder.GainSpecificSpell(Guid.Parse("dbe8b889-945d-4a21-a0df-a2c2989e7df5"), Spells.Instances.MadMonkeys.ID);
            builder.GainSpecificSpell(Guid.Parse("bbe784c2-32b3-47e7-9ab2-b616d3298538"), Spells.Instances.Confusion.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return Items.MeleeWeapons.Instances.BattleAxe.ID;
        }

        protected override IEnumerable<Guid> GetFavoredRangedWeapons()
        {
            yield break;
        }

        protected override IEnumerable<Guid> GetFavoredUnarmedWeapons()
        {
            
            yield return UnarmedWeapons.Instances.Jaws.ID;
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
            
            yield return Stats.Instances.Dexterity.ID;
            yield return Stats.Instances.Intelligence.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Indulgence.ID;
            yield return Domains.Instances.Nature.ID;
            yield return Domains.Instances.Swarm.ID;
            yield return Domains.Instances.Trickery.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.ChaoticEvil.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("a51338d2-b17d-498d-97c5-c957e29000eb"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 132
            };
        }
    }
}
