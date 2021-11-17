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
    public class ElvenPantheon : Template
    {
        public static readonly Guid ID = Guid.Parse("15c67d9d-aef5-41d5-9674-0e1d8836511c");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.Pantheons.ID,
                AlignmentId = Alignments.Instances.ChaoticGood.ID,
                Name = "Elven Pantheon",
                Edicts = "Learn and appreciate traditional elven arts, crafts, and magic, explore the worlds outside and within.",
                Anathema = "Irreparably damage the natural environment (such as by overhunting or strip mining), have an unhealthy obsession or attachment.",
                
                AreasOfConcern = "Elves, magic, nature, tradition.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("92e91c26-5cd6-4a4e-9f8e-c99af8911f94"), Type = TextBlockType.Text, Text = "The traditional deities of the elven pantheon areCalistria,Desna,Findeladlara(goddess of twilight and traditional art and architecture),Ketephys(god of hunting and the moon), andYuelral(goddess of gems, craft, and magic). Elves have also adoptedAlseta, a minor goddess of doors and transitions, as their patron of teleportation and aiudara (commonly known as elf gates). Most elves value magic, beauty, freedom, and friendship as part of a fulfilling life and tend to worship all of the deities together as exemplars of these values. Alongside full-blooded elves, many half-elves—whether raised by elves or seeking a closer connection to their elven heritage— worship the elven pantheon." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("8df40d11-b3c9-455a-af18-d5152af68e64"), Spells.Instances.Shillelagh.ID);
            builder.GainSpecificSpell(Guid.Parse("0c034e78-a197-4f5d-ae5f-b6904f4964db"), Spells.Instances.ShapeWood.ID);
            builder.GainSpecificSpell(Guid.Parse("5f718f62-9e67-439a-93c9-11657d1133e3"), Spells.Instances.TreeStride.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            yield break;
        }

        protected override IEnumerable<Guid> GetFavoredRangedWeapons()
        {
            
            yield return RangedWeapons.Instances.Longbow.ID;
            yield return RangedWeapons.Instances.Shortbow.ID;
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
            yield return Skills.Instances.Survival.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Dexterity.ID;
            yield return Stats.Instances.Intelligence.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Creation.ID;
            yield return Domains.Instances.Magic.ID;
            yield return Domains.Instances.Moon.ID;
            yield return Domains.Instances.Nature.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.NeutralGood.ID;
            yield return Alignments.Instances.ChaoticGood.ID;
            yield return Alignments.Instances.ChaoticNeutral.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("295f9a65-1c1c-4625-88a1-7e1b51254235"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 93
            };
        }
    }
}