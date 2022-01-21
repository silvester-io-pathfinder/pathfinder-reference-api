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
    public class YogSothoth : Template
    {
        public static readonly Guid ID = Guid.Parse("dbb405b9-164f-4aed-9a8c-594a7b787076");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.OuterGodsAndGreatOldOnes.ID,
                AlignmentId = Alignments.Instances.ChaoticNeutral.ID,
                Name = "Yog-Sothoth",
                Edicts = "Gather knowledge of gates through space and time, curse or mutate unborn children.",
                Anathema = "None.",
                Title = "Lurker at the Threshold",
                
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("15d18c0e-7e4b-4006-b3fa-fed887d12a05"), Type = TextBlockType.Text, Text = "Yog-Sothoth is, along with Azathoth, one of the greatest of the Outer Gods. In appearance, he is said to be a congeries of iridescent spheres—brilliant, foaming bubbles that constantly expand and collapse in upon themselves. He has other manifestations, however, including the Lurker on the Threshold, a mass of black tentacles that endlessly writhe, reach, and grow, and a mysterious humanoid figure hidden behind a shimmering veil." };
            yield return new TextBlock { Id = Guid.Parse("9bee215b-3e41-4039-b21e-dcf3ddab8eb6"), Type = TextBlockType.Text, Text = "Yog-Sothoth embodies all of space and time; he exists in all places and in all moments simultaneously. Paradoxically, however, he is unable to manifest in the mortal universe unless summoned, a magical act that almost always results in untold destruction. He is known as the Key and the Gate, and magicians and cults research him in an effort to master time and space. Fortunately, his worship is not widespread, but some of those who have delved deep into his secrets describe him as an ambivalent figure, rather than a malevolent one, who guards cosmic secrets and makes them accessible to those who dare to ask for them. Yog-Sothoth reveals the true nature of the universe, but this is a thing that once seen cannot be unseen, and wise mortals turn aside from Yog-Sothoth's offer of cosmic knowledge in favor of a more mundane existence." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("70e87ecf-f7e0-4c63-9e77-61299a3d5793"), Spells.Instances.FleetStep.ID);
            builder.GainSpecificSpell(Guid.Parse("1dbf02ba-e704-4103-9c61-920844a434f6"), Spells.Instances.BlackTentacles.ID);
            builder.GainSpecificSpell(Guid.Parse("8bb6cbae-476b-4e23-b618-29286c7176ea"), Spells.Instances.TimeBeacon.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return Items.MeleeWeapons.Instances.Dagger.ID;
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
            yield return Skills.Instances.Occultism.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Intelligence.ID;
            yield return Stats.Instances.Charisma.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Knowledge.ID;
            yield return Domains.Instances.Time.ID;
            yield return Domains.Instances.Travel.ID;
            yield return Domains.Instances.Void.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.ChaoticNeutral.ID;
            yield return Alignments.Instances.ChaoticEvil.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("d7bc5554-c525-4169-bd3f-e59f04797986"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 132
            };
        }
    }
}
