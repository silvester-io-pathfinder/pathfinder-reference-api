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
    public class Desna : Template
    {
        public static readonly Guid ID = Guid.Parse("ac2b975f-8dae-4a58-8162-ae66ac44341b");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.GodsOfTheInnerSea.ID,
                AlignmentId = Alignments.Instances.ChaoticGood.ID,
                Name = "Desna",
                Edicts = "Aid fellow travelers, explore new places, express yourself through art and song, find what life has to offer.",
                Anathema = "Cause fear or despair, cast.",
                Title = "The Song of the Spheres",
                AreasOfConcern = "Dreams, luck, stars, and travelers.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("8513f4aa-7450-4fca-8a1d-5de60ac70525"), Type = TextBlockType.Text, Text = "The night didn't know beauty until Desna came into existence. While the other gods toiled away to create the world, she set her sights on the heavens, placing each star in the sky. After surveying her artistry, she hung the brightest star high in the north and made it her home. Her first gift to mortals was this beacon of hope, a twinkling sign in the dark sky that they could turn to when lost or unsure of themselves. Desna provides safe passage through the darkness to all, should they choose to follow." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("53091fc5-7c21-4429-80c1-f471bb7565b2"), Spells.Instances.Sleep.ID);
            builder.GainSpecificSpell(Guid.Parse("3596b48d-428b-463d-a3c1-0bfe5fdd8fc3"), Spells.Instances.Fly.ID);
            builder.GainSpecificSpell(Guid.Parse("a04e9277-fba9-4c1c-982d-8e347542f968"), Spells.Instances.DreamingPotential.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return MeleeWeapons.Instances.Starknife.ID;
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
            
            return new DivineIntercession
            {
                Id = Guid.Parse("7d6b0dc1-7bd4-451f-bfd2-24588751e3cb"),
                Description = "Desna favors those who follow their hearts and whims without bringing harm to others.",
                MinorBoon = "For those at the end of a journey, Desna gifts a deep sleep. Once, after you rest, you completely recover all Hit Points, remove all negative conditions, and become free of any curses or diseases.",
                ModerateBoon = "Desna twists fortune in your favor. Once per day, after determining the result of a check, you can reroll the check and take the new result.",
                MajorBoon = "Desna bestows you with a swirling cloud of lights that forms a pair of wondrous butterfly wings. These wings grant you a fly Speed of 40 feet and shine dim light to a range of 20 feet.",
                MinorCurse = "You always seem to lose your way or have strange mishaps on the road that delay your travel. You (and thus any group that travels with you) travel at only 3/4 normal exploration Speed, before taking into account the terrain and other features that might slow you down further.",
                ModerateCurse = "Misfortune follows you in your travels and requires acts of contrition or benevolence to keep at bay. You must always roll twice and take the worst result when attempting a check. This is a misfortune effect. You can express your remorse and ignore this effect for 1d4 rounds by spending an action, which has the concentrate trait. If you perform a truly selfless act of compassion, you ignore this effect for 1 day.",
                MajorCurse = "The stars rebuke you for your ways. You are sickened 4 and slowed 1 whenever you are exposed to starlight.",
                SourcePage = new SourcePage
                {
                    Id = Guid.Parse("4a9a4173-f5a5-4e7a-badd-bc53b803e55f"),
                    SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                    Page = 21
                }
            };
        }

        protected override IEnumerable<Guid> GetDivineSkills()
        {
            yield return Skills.Instances.Acrobatics.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Dexterity.ID;
            yield return Stats.Instances.Charisma.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Dreams.ID;
            yield return Domains.Instances.Luck.ID;
            yield return Domains.Instances.Moon.ID;
            yield return Domains.Instances.Travel.ID;
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
                Id = Guid.Parse("cc2d6b96-4787-4e1c-94b6-4b3a822049b5"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 438
            };
        }
    }
}
