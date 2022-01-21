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
    public class Shelyn : Template
    {
        public static readonly Guid ID = Guid.Parse("c35550f5-501b-4ce5-9a84-3c93e48d87dc");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.GodsOfTheInnerSea.ID,
                AlignmentId = Alignments.Instances.NeutralGood.ID,
                Name = "Shelyn",
                Edicts = "Be peaceful, choose and perfect an art, lead by example, see the beauty in all things.",
                Anathema = "Destroy art or allow it to be destroyed, unless saving a life or pursuing greater art; refuse to accept surrender.",
                Title = "The Eternal Rose",
                AreasOfConcern = "Art, beauty, love, and music.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("d4d40025-c2c2-44eb-b353-9f27564d6175"), Type = TextBlockType.Text, Text = "Shelyn watches over existence with a kind and loving eye, encouraging mortals to make the best of their lives by spreading love, art, and beauty as best they can. Even the crudest artistic awakenings are worthy of praise in the goddess's eyes, as they represent an individual's expression of life's trials and triumphs. She believes every creature is worthy of love and capable of creating art in their own way. Shelyn's religion does not require chastity, fidelity, or a particular relationship structure, as the passion of early romance is a facet of love just as important and valid as the comfortable trust between a long-married couple. However, she does make the distinction between courtship and pure carnal desire, and she prefers that trysts blossom into more meaningful relationships along the way." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("c09f4dcb-0a3e-406e-98e3-c6be9a5951c4"), Spells.Instances.ColorSpray.ID);
            builder.GainSpecificSpell(Guid.Parse("653d3765-3d67-47af-9a98-ca0edd7e626a"), Spells.Instances.Enthrall.ID);
            builder.GainSpecificSpell(Guid.Parse("aa970a11-d337-4477-878f-ef3fbeec3c52"), Spells.Instances.Creation.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return Items.MeleeWeapons.Instances.Glaive.ID;
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
                Id = Guid.Parse("5749079c-6927-4bf1-b534-26c92c9bfb96"),
                Description = "When creatures perform pleasing acts, such as spreading beauty, or displeasing actions, such as betraying loved ones, Shelyn may respond accordingly.",
                MinorBoon = "Once, when you roll a failure on a Diplomacy check, you get a critical success instead. Shelyn typically grants this boon only when the Diplomacy check would serve to increase love or offer a chance of redemption.",
                ModerateBoon = "You are inspired to create great works and become a virtuoso at all arts. You gain the Specialty Crafting feat and the Virtuoso Performer feat in all categories of Crafting and Performance.",
                MajorBoon = "Your inner beauty and love surround you in an aura. As long as you bear them no ill will, all creatures other than fiends, undead, and mindless creatures start with an attitude of friendly toward you, unless they would have been helpful instead. This doesn't mean they are willing to change their life or plans for you, and this boon does not prevent their attitudes from worsening if you try to thwart them. This effect doesn't work against deities and similarly powerful creatures. Additionally, the love you share with your friends inspires them. You and your allies gain a +3 status bonus to saving throws and skill checks as long as you can see each other.",
                MinorCurse = "You heart churns with remorse. Each day, you are sickened 1 as a specific misdeed plays out in your mind over and over in guilt. You can't remove this condition, though it abates enough for you to quickly eat and drink when necessary. If you make amends or otherwise earnestly pursue redemption for the misdeed, the sickened condition fades completely that day.",
                ModerateCurse = "Others subconsciously recognize your past betrayals. Whenever you attempt a Diplomacy check and roll a failure, you get a critical failure instead, and if you roll a critical success, you get a success instead.",
                MajorCurse = "Those who spread misery via false love face Shelyn's greatest curse. You lose the ability to distinguish any living being from another through appearance, voice, scent, or similar sensory means. You can make out physical size (so you wouldn't mistake an ant for a horse), but nothing further. If you were merely shallow, every creature you see has generic, bland features, but if your deeds were vile, you see only the faces of those you have wronged.",
                SourcePage = new SourcePage
                {
                    Id = Guid.Parse("5be44387-1255-42ad-a7ab-71439b45cc5c"),
                    SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                    Page = 45
                }
            };
        }

        protected override IEnumerable<Guid> GetDivineSkills()
        {
            yield return Skills.Instances.Crafting.ID;
            yield return Skills.Instances.Performance.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Wisdom.ID;
            yield return Stats.Instances.Charisma.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Creation.ID;
            yield return Domains.Instances.Family.ID;
            yield return Domains.Instances.Passion.ID;
            yield return Domains.Instances.Protection.ID;
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
                Id = Guid.Parse("3ffff40a-9e34-43eb-a1e6-739e3da1b712"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 440
            };
        }
    }
}
