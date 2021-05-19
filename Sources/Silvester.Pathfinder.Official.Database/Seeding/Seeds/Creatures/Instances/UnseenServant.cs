using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Creatures.Instances
{
    public class UnseenServant : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Creature GetCreature()
        {
            return new Creature
            {
                Id = ID,
                Name = "Unseen Servant",
                Level = -1,
                PerceptionModifier = 0,
                StrengthModifier = -4,
                DexterityModifier = 2,
                ConstitutionModifier = 0,
                IntelligenceModifier = -5,
                WisdomModifier = 0,
                CharismaModifier = 0,
                ArmorClass = 13,
                FortitudeModifier = 0,
                ReflexModifier = 4,
                WillModifier = 0,
                LanguageAddendum = "Understands its creator.",
                HitPoints = 4,
                Resistances = "All damage 5 (except force or ghost touch).",
                FlyingSpeed = "30 feet.",
                SizeId = RaceSizes.Instances.Medium.ID,
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<CreatureFlavor> GetFlavors()
        {
            yield return new CreatureFlavor
            {
                Id = Guid.Parse(""),
                Name = "Invisible",
                Details = new TextBlock[]
                {
                    new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "An unseen servant is invisible, though it normally doesn’t Sneak, so it is usually only hidden." }
                }
            };

            yield return new CreatureFlavor
            {
                Id = Guid.Parse(""),
                Name = "Force Body",
                Details = new TextBlock[]
                {
                    new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "An unseen servant’s physical body is made of force. It can’t use attack actions. It can move and use Interact actions to do things such as fetch objects, open unstuck or unlocked doors, hold chairs, and clean. It can’t pass through solid objects." }
                }
            };
        }

        protected override IEnumerable<CreatureAbility> GetAbilities()
        {
            yield break;
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Mindless.ID;
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The Unseen Servant is summoned by the Unseen Servant spell." };
        }

        protected override IEnumerable<Guid> GetImmunities()
        {
            yield return Immunities.Instances.Disease.ID;
            yield return Immunities.Instances.Mental.ID;
            yield return Immunities.Instances.NonMagicalAttacks.ID;
            yield return Immunities.Instances.Paralysis.ID;
            yield return Immunities.Instances.Poison.ID;
            yield return Immunities.Instances.PrecisionDamage.ID;
            yield return Immunities.Instances.Unconscious.ID;
        }

        protected override IEnumerable<Guid> GetLanguages()
        {
            yield break;
        }

        protected override IEnumerable<CreatureSkill> GetSkills()
        {
            yield return new CreatureSkill
            {
                Id = Guid.Parse(""),
                Modifier = 8,
                SkillId = Skills.Instances.Stealth.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 380
            };
        }
    }
}
