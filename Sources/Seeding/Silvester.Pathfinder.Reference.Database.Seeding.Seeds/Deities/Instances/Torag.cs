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
    public class Torag : Template
    {
        public static readonly Guid ID = Guid.Parse("835c984a-f1d0-4303-a5de-38b164df12eb");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.GodsOfTheInnerSea.ID,
                AlignmentId = Alignments.Instances.LawfulGood.ID,
                Name = "Torag",
                Edicts = "Be honorable and forthright, keep your word, respect the forge, serve your people.",
                Anathema = "Tell lies or cheat someone, intentionally create inferior works, show mercy to the enemies of your people.",
                Title = "The Forge Father",
                AreasOfConcern = "Forge, protection, and strategy.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("c9967788-161c-40bb-9832-384aa779db9d"), Type = TextBlockType.Text, Text = "The head of the dwarven pantheon is the most visible of the dwarven deities, to the extent that Torag is the only dwarven deity most non-dwarves know of. While the other dwarven gods represent specific areas of dwarven life and culture, thus forming an expansive and comprehensive dwarven pantheon, Torag's areas of concern are those most central to dwarven society. In his own family, Torag models the values of community and protection that have cemented deep-rooted relationships among dwarven clans. His focus on strategy and tactical acumen centers on protection, reflected in dwarves' impenetrable fortresses and conservative military tactics, including their willingness to use offensive maneuvers as a form of defense. He also represents the forge: the creation of fine works from raw materials, practice and mastery of a craft, and pride in one's work. His purview extends even to those activities that feed the forge and dwarven artisanship, such as mining the earth for raw ore and gemstones. Torag's oversight over these core concepts has secured his place at the head of the dwarven pantheon for ages. It was Torag who sent the dwarves on their legendary Quest for Sky during the Age of Darkness, and his worship was long-established even then. Indeed, among dwarves, Torag is often called the Father of Creation." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("8cb686d9-7485-444e-bcf7-0ed5d6536cc6"), Spells.Instances.Mindlink.ID);
            builder.GainSpecificSpell(Guid.Parse("4dd6933e-8719-41b6-a76e-8e69661d5ba0"), Spells.Instances.Earthbind.ID);
            builder.GainSpecificSpell(Guid.Parse("00656ab4-88a8-4862-bc3a-c97b4843d670"), Spells.Instances.Creation.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return Items.MeleeWeapons.Instances.Warhammer.ID;
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
                Id = Guid.Parse("1cd539ae-9e39-479f-93c5-7bdef843a1fe"),
                Description = "Torag makes his pleasure or displeasure known through unsubtle signs.",
                MinorBoon = "Torag repairs your equipment so you may continue your vigil. Once, a shield, weapon, or other item you hold or are wearing recovers all of its Hit Points. The item's Hardness doubles for 1 minute. Torag can grant this boon just as the item would have been destroyed, preventing the item's destruction. Occasionally, he grants this boon to restore an item important to dwarven history that has already been fully destroyed.",
                ModerateBoon = "You are counted as family among Torag and his followers. You gain the effects of a single dwarf ancestry feat of Torag's choice, even if you are not a dwarf, as long as you maintain Torag's blessing.",
                MajorBoon = "Standing watch or guarding a location counts as resting for you, preventing you from being fatigued due to lack of rest as long as you stand watch for at least 6 hours a day. You can recover your Focus Points (if you have them) by standing guard in addition to any other options you have available. When on guard, you gain a +4 status bonus to Perception to notice ambushes and other dangers approaching. As long as you are holding a shield, you are always Defending during exploration without needing to move at half your travel speed, and you can perform another exploration activity as well. While you are using a shield, its Hardness increases by 5.",
                MinorCurse = "Shoddy artisanship makes itself known. Whenever an item you're using takes damage, it is broken.",
                ModerateCurse = "You must prove your skills at a craft by providing your own equipment. You gain item bonuses only from items you make yourself.",
                MajorCurse = "You are forever cast out from your home. Members of your community have their attitudes towards you shift two steps worse, meaning those who used to be helpful are now indifferent, those who were friendly are now unfriendly, and all others are now hostile. This doesn't necessarily result in violence, but hostile community members generally seek your permanent exile.",
                SourcePage = new SourcePage
                {
                    Id = Guid.Parse("5a67fdc0-096b-4795-9e31-dab52daa5925"),
                    SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                    Page = 47
                }
            };
        }

        protected override IEnumerable<Guid> GetDivineSkills()
        {
            yield return Skills.Instances.Crafting.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Constitution.ID;
            yield return Stats.Instances.Wisdom.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Creation.ID;
            yield return Domains.Instances.Earth.ID;
            yield return Domains.Instances.Family.ID;
            yield return Domains.Instances.Protection.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.LawfulGood.ID;
            yield return Alignments.Instances.LawfulNeutral.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("3cc31394-16f1-4445-b6a8-64cc71ecdcde"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 440
            };
        }
    }
}
