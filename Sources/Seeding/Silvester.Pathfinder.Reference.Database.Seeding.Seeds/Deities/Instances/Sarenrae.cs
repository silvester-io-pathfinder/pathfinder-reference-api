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
    public class Sarenrae : Template
    {
        public static readonly Guid ID = Guid.Parse("eb99869c-27f8-43e2-a27d-364321d39669");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.GodsOfTheInnerSea.ID,
                AlignmentId = Alignments.Instances.NeutralGood.ID,
                Name = "Sarenrae",
                Edicts = "Destroy the Spawn of Rovagug, protect allies, provide aid to the sick and wounded, seek and allow redemption.",
                Anathema = "Create undead, lie, deny a repentant creature an opportunity for redemption, fail to strike down evil.",
                Title = "The Dawnflower",
                AreasOfConcern = "Healing, honesty, redemption, and the sun.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("2de42619-3774-40fc-8d51-1c368fcd1d53"), Type = TextBlockType.Text, Text = "Sarenrae is one of the most popular deities on Golarion by virtue of her association with the life-giving sun and her perpetual offer to help anyone be their best, even when they have made mistakes. Most people thank her for her kind work to channel the sun's power for everyone's safety and livelihood, and thank her clergy for granting her healing power to all who need it. Mortals look to the Dawnflower as an example of boundless love, exquisite kindness, and true patience. They pray to her to heal the sick, lift up the downtrodden, and illuminate darkness of circumstance as well as darkness of spirit. Her followers aspire to emulate her through generosity, nurturing, truthfulness, and selfless courage. They oppose evil everywhere with words first, and when necessary, with scimitar and flame." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("164769e3-60d3-49c9-9739-e14b9f88d8df"), Spells.Instances.BurningHands.ID);
            builder.GainSpecificSpell(Guid.Parse("f457b04e-79c3-49ff-a5d9-c96a44075941"), Spells.Instances.Fireball.ID);
            builder.GainSpecificSpell(Guid.Parse("3dd14e5d-d0d7-4260-9553-a861d2711e3c"), Spells.Instances.WallOfFire.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return Items.MeleeWeapons.Instances.Scimitar.ID;
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
                Id = Guid.Parse("c9014922-90ad-4030-b4fd-fd7282ee6aa9"),
                Description = "Sarenrae often bestows boons for making a sacrifice to do better or taking a risk to redeem another. She typically curses those who betray her mercy.",
                MinorBoon = "Your healing hands are blessed with a warm flame. Once, when you heal another creature, instead of healing it for the normal amount, you heal the creature to full Hit Points, no matter how much damage it has taken. Sarenrae typically grants this boon in extremely consequential circumstances.",
                ModerateBoon = "Your blade burns the irredeemable. Your attacks deal an additional 1d6 fire damage that ignores fire resistance.",
                MajorBoon = "You are a voice of peace and rehabilitation. When you roll a success at a check to Request something, you get a critical success instead. In addition, all creatures other than fiends, undead, and mindless creatures allow you one chance to speak your piece and make requests before entering combat. If you or an ally ever use the time from the request to gain an advantage in an ensuing combat (for example, by casting preparatory spells, positioning for combat, or waiting out your opponent's preparatory spells), Sarenrae immediately revokes this boon, or possibly curses your ally.",
                MinorCurse = "The sun burns you for your transgression. You receive a sunburn that causes you to become permanently clumsy 1.",
                ModerateCurse = "The sun shines its light on everything you say. You become unable to tell lies, and if you attempt to do so, you instead compulsively blurt out the truth on the matter in question. You are still able to withhold information or lie by omission.",
                MajorCurse = "Sarenrae restricts your ability to harm others. All attacks you make, spells you cast, and other sources of damage you deal are nonlethal except against fiends and undead, and you can't ever make them lethal. You deal minimum damage except against fiends and undead. All creatures except fiends and undead gain a +4 status bonus to their AC and saving throws against your attacks and other effects.",
                SourcePage = new SourcePage
                {
                    Id = Guid.Parse("c224b9c3-50db-4219-8ced-64299ecd3c19"),
                    SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                    Page = 43
                }
            };
        }

        protected override IEnumerable<Guid> GetDivineSkills()
        {
            yield return Skills.Instances.Medicine.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Constitution.ID;
            yield return Stats.Instances.Wisdom.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Fire.ID;
            yield return Domains.Instances.Healing.ID;
            yield return Domains.Instances.Sun.ID;
            yield return Domains.Instances.Truth.ID;
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
                Id = Guid.Parse("d232b02f-240f-4c53-a1bf-61c4dc602ac9"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 439
            };
        }
    }
}
