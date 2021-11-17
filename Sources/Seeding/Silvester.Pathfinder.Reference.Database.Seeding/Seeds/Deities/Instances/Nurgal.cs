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
    public class Nurgal : Template
    {
        public static readonly Guid ID = Guid.Parse("6879b83a-3b80-4c18-99fc-91bd9ba7459b");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.DemonLords.ID,
                AlignmentId = Alignments.Instances.ChaoticEvil.ID,
                Name = "Nurgal",
                Edicts = "Wage war in the desert, deny water to your foes.",
                Anathema = "Heal a sunburn, change your name.",
                Title = "The Shining Scourge",
                AreasOfConcern = "Deserts, senseless warfare, and the sun.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("666ba58a-4f5e-4b9e-bb40-4bf71e7b5a87"), Type = TextBlockType.Text, Text = "Nurgal, the Shining Scourge, is the demon lord of deserts, senseless warfare, and the sun. He was formerly a fully fledged deity of ancient Azlant, but fell to demigodhood after being defeated in combat. Nurgal represents the sun's potential for devastation, and his followers venerate him out of cowed awe. The demon lord appears as a muscular, tanned man with the head and lower body of a golden lion and a dragon's tail. He is almost always depicted as wielding a mace in the form of a miniature sun, held in a taloned hand. Nurgal's worshippers are primarily found in the deserts of Garund, Ninshabur, and Qadira." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("a798eeac-1f3f-4558-bc8b-c8c61b865eee"), Spells.Instances.BurningHands.ID);
            builder.GainSpecificSpell(Guid.Parse("8104805d-9a41-42ca-ba6e-f4dab8932998"), Spells.Instances.FlamingSphere.ID);
            builder.GainSpecificSpell(Guid.Parse("74dc93c1-784a-4f9f-a240-b95694dd6b8d"), Spells.Instances.CupOfDust.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return MeleeWeapons.Instances.Mace.ID;
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
            yield return Skills.Instances.Survival.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Constitution.ID;
            yield return Stats.Instances.Charisma.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Destruction.ID;
            yield return Domains.Instances.Dust.ID;
            yield return Domains.Instances.Fire.ID;
            yield return Domains.Instances.Sun.ID;
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
                Id = Guid.Parse("b6e75629-5340-4b81-81d3-69ea7f2f2e81"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 126
            };
        }
    }
}
