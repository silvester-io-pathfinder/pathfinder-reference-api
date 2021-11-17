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
    public class Chaldira : Template
    {
        public static readonly Guid ID = Guid.Parse("a7c5893b-ed44-4d9c-82b1-195ef9d8cfb9");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.OtherGods.ID,
                AlignmentId = Alignments.Instances.NeutralGood.ID,
                Name = "Chaldira",
                Edicts = "Seek out and challenge oppressors and tyrants, defend friends and the innocent, engage in mischief that doesn't harm others.",
                Anathema = "Suffer a bully's insults to you or another without retort, abandon a friend in need, attribute a lucky turn of events to your own skill.",
                Title = "The Calamitous Turn",
                AreasOfConcern = "Battle, fortune, mischief.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("3f835ac0-0e3e-416c-9a48-55f32d075f3e"), Type = TextBlockType.Text, Text = "Chaldira Zuzaristan, the Calamitous Turn, is a plucky, impulsive goddess venerated primarily by halflings. She embodies two aspects halflings see in themselves: a strong affinity for luck and bold determination to protect friends. Chaldira is hotheaded and cannot abide bullies in any form, and many of her worshippers are similarly impetuous, spoiling for any opportunity to leap fist-first at oppressors and tyrants. While many people consider this to be more of a vice than a virtue, Chaldira and her followers feel it is far better to run headlong into trouble than it is to meekly concede to evil out of fear or convenience. Chaldira is also the goddess of light-hearted mischief, insisting that harmless fun, even at others' expense, brings joy and strengthens ties within a community. While not all of Chaldira's followers are inveterate pranksters, most at least know some sleight-of-hand tricks. Chaldira is most often depicted as a halfling woman who matches the appearance of the local halfling community, with curly hair, freckles, and a patchwork red-and-green coat held together by several mismatched buttons." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("d5bd59c0-c244-4f46-9f2a-3096cfb91ca4"), Spells.Instances.FleetStep.ID);
            builder.GainSpecificSpell(Guid.Parse("c8abdd36-d3d9-463b-8a11-ef5d30603a4b"), Spells.Instances.Misdirection.ID);
            builder.GainSpecificSpell(Guid.Parse("45550154-3eae-44e8-b281-5ad614d57df4"), Spells.Instances.CloakOfColors.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return MeleeWeapons.Instances.Shortsword.ID;
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
                Id = Guid.Parse("a07d810b-596b-48b7-a5dc-ee658152e458"),
                Description = "The Calamitous Turn’s pleasure most often manifests as improbably good luck, while her displeasure creates startling misfortune. ",
                MinorBoon = "Once, you can choose the result of the next ordinary coin you flip or ordinary die you roll. If this ability is used for personal gain at the expense of someone innocent or less fortunate, Chaldira levies her moderate curse on you as punishment.",
                ModerateBoon = "You gain a lucky impetuousness, allowing you to roll for initiative twice and use the higher result once per day. This is a fortune effect.",
                MajorBoon = "Chaldira's major boon grants truly improbable luck in combat. Your movement doesn't trigger reactions. You always succeed at flat checks you make to hit opponents with attack actions; this is a fortune effect.",
                MinorCurse = "Any time you refuse a request made in good faith, you vomit up a frog, mouse, or other small animal. This deals no damage and causes no conditions, but is obvious to all bystanders.",
                ModerateCurse = "You are plagued with ill luck just when fortune is most needed. You must always roll flat checks twice and use the worse result. This is a misfortune effect.",
                MajorCurse = "Ill luck causes even once-certain aid to fail with frustrating regularity. You cannot benefit from circumstance or status bonuses, or from fortune effects.",
                SourcePage = new SourcePage
                {
                    Id = Guid.Parse("54741e2e-ba3a-44df-a208-97978b1ce84e"),
                    SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                    Page = 5
                }
            };
        }

        protected override IEnumerable<Guid> GetDivineSkills()
        {
            yield return Skills.Instances.Thievery.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Dexterity.ID;
            yield return Stats.Instances.Charisma.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Confidence.ID;
            yield return Domains.Instances.Luck.ID;
            yield return Domains.Instances.Trickery.ID;
            yield return Domains.Instances.Zeal.ID;
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
                Id = Guid.Parse("1d74896e-72d3-4233-a5c9-0f3492eae402"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 58
            };
        }
    }
}
