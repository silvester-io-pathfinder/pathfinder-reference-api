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
    public class Gogunta : Template
    {
        public static readonly Guid ID = Guid.Parse("fcdb8c57-a3dc-471f-9dfd-32a50025e8f9");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.DemonLords.ID,
                AlignmentId = Alignments.Instances.ChaoticEvil.ID,
                Name = "Gogunta",
                Edicts = "Sacrifice creatures by drowning them, frolic or sing in swamps, feed or aid amphibians.",
                Anathema = "Grant mercy to boggards who worship other gods.",
                Title = "Song of the Swamp",
                AreasOfConcern = "Amphibians, boggards, and swamps.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("ec0bdfaf-0450-43e3-afb5-24f9ce47df95"), Type = TextBlockType.Text, Text = "Gogunta, Song of the Swamp, is the demon lord of amphibians, boggards, and swamps. Gogunta is worshipped as a goddess by boggards, who believe her to be an ascended mobogo, though scholars suspect she was a former hezrou who gained the favor of Dagon. Lending credence to this latter theory, her realm, a stinking salt marsh, is located within Dagon's oceanic realm. Gogunta appears as an enormous, multi-headed frog with dozens of eyes and even more tongues, though boggards typically depict her as a titanic boggard queen." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("e5fa2f8d-f586-422d-a07f-9b4ed9509ac9"), Spells.Instances.Jump.ID);
            builder.GainSpecificSpell(Guid.Parse("b605f747-b3b9-45ab-8878-4fd3c9cfef86"), Spells.Instances.StinkingCloud.ID);
            builder.GainSpecificSpell(Guid.Parse("bf36fd8c-9d0d-4288-8c2b-cd793aaf08ca"), Spells.Instances.BlackTentacles.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return MeleeWeapons.Instances.Whip.ID;
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
            yield return Skills.Instances.Intimidation.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            yield break;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Indulgence.ID;
            yield return Domains.Instances.Might.ID;
            yield return Domains.Instances.Tyranny.ID;
            yield return Domains.Instances.Water.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.ChaoticEvil.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("ad724984-dc60-4a7c-bca6-68af9e9b318b"),
                SourceId = Sources.Instances.Bestiary.ID,
                Page = 45
            };
        }
    }
}
