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
    public class FollowersOfFate : Template
    {
        public static readonly Guid ID = Guid.Parse("28eadb76-0f0b-4511-aeae-0263f2d29d56");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.OtherGods.ID,
                AlignmentId = Alignments.Instances.LawfulNeutral.ID,
                Name = "Followers of Fate",
                Edicts = "Make predictions of the future, offer advice and guidance to those in positions of power, provide comfort to the elderly.",
                Anathema = "Apologize for making an incorrect prediction, disrespect mothers, accept payment for fortune-telling.",
                
                AreasOfConcern = "Destiny, fate, and the aging process.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("08fde659-4820-4a01-8609-bae3d89a8c5c"), Type = TextBlockType.Text, Text = "On theMaterial Plane, some mortals worshipnornsas deities, while others, especially witches and bards, admire them as patrons or muses. Those who uphold norns as deities are known as Followers of Fate. Norns do little to discourage this veneration, but neither do they go out of their way to support such worship. Clerics who venerate norns might worship a specific norn or norn triumvirate, or all norns as a whole, but they gain the same benefits regardless of their choice. The religious symbol of Followers of Fate is a pair of shears cutting a golden thread, and their areas of concern are destiny, fate, and the aging process." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("98de469c-cce4-4c85-b817-b158131b696e"), Spells.Instances.Mindlink.ID);
            builder.GainSpecificSpell(Guid.Parse("16ff6c31-32a7-4a99-b57b-347d53fc7688"), Spells.Instances.ThreefoldAspect.ID);
            builder.GainSpecificSpell(Guid.Parse("2f42da23-09fd-4668-b75f-83e1e9aaa3e9"), Spells.Instances.PryingEye.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return Items.MeleeWeapons.Instances.Shears.ID;
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
            yield break;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Family.ID;
            yield return Domains.Instances.Fate.ID;
            yield return Domains.Instances.Knowledge.ID;
            yield return Domains.Instances.Truth.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.LawfulGood.ID;
            yield return Alignments.Instances.LawfulNeutral.ID;
            yield return Alignments.Instances.LawfulEvil.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("2417ed51-8ecd-4a3b-be13-f47f87693144"),
                SourceId = Sources.Instances.Bestiary2.ID,
                Page = 185
            };
        }
    }
}
