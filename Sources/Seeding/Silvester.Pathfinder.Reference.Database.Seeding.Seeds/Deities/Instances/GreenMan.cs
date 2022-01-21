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
    public class GreenMan : Template
    {
        public static readonly Guid ID = Guid.Parse("0b9d3a5e-e87e-4afe-9894-dc3c31d42616");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.OtherGods.ID,
                AlignmentId = Alignments.Instances.TrueNeutral.ID,
                Name = "Green Man",
                Edicts = "Discover or create new forms of plant life, foster the growth and well-being of flora, preserve areas of natural wilderness.",
                Anathema = "Allow flagrant abuse of plant life to go unpunished, damage natural environments, harm plant life except in the pursuit of saving greater plant life.",
                
                
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("6f376846-b89c-4676-b6f7-281b100be702"), Type = TextBlockType.Text, Text = "Individualgreen menare lesser deities, capable of granting spells to those who worship them. Green men typically only allow intelligent plants—such asleshys—to be their clerics. If another creature proves to be a friend of plants, after a thorough personal vetting, a green man wholeheartedly accepts this strange fleshy worshipper into the fold. While individual green men have different edicts and anathema befitting their personalities, and some neutral good or neutral evil green men might have further changes, the following is a baseline most worshippers of green men follow." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("e2e5a5b5-170c-48d8-a3e5-3cc4be788aee"), Spells.Instances.SummonPlantOrFungus.ID);
            builder.GainSpecificSpell(Guid.Parse("18249f70-30e0-4511-ae1a-0a1f89960427"), Spells.Instances.Entangle.ID);
            builder.GainSpecificSpell(Guid.Parse("0774e594-d5dc-4ecd-90af-eeda2b7b6f1b"), Spells.Instances.TanglingCreepers.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return Items.MeleeWeapons.Instances.Sickle.ID;
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
            yield break;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Healing.ID;
            yield return Domains.Instances.Might.ID;
            yield return Domains.Instances.Nature.ID;
            yield return Domains.Instances.Protection.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.NeutralGood.ID;
            yield return Alignments.Instances.TrueNeutral.ID;
            yield return Alignments.Instances.NeutralEvil.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("d6db025d-2591-43a2-955d-3d4a4f8e01e4"),
                SourceId = Sources.Instances.Bestiary3.ID,
                Page = 119
            };
        }
    }
}
