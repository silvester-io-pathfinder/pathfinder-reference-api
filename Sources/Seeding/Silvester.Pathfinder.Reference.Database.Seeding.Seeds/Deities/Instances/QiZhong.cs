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
    public class QiZhong : Template
    {
        public static readonly Guid ID = Guid.Parse("537dd737-3618-40a2-a402-32d5c95741c3");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.TianGods.ID,
                AlignmentId = Alignments.Instances.NeutralGood.ID,
                Name = "Qi Zhong",
                Edicts = "Teach knowledge to others, relieve suffering despite personal difficulty, heal sickness and injuries.",
                Anathema = "Deal lethal damage to another living creature (unless as part of a necessary medical treatment).",
                Title = "Master of Medicine",
                
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield break;
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("d0a44f67-d006-4378-8487-da311f6c43ac"), Spells.Instances.Soothe.ID);
            builder.GainSpecificSpell(Guid.Parse("63635375-ceca-4fa1-a1ce-98772aeb1c2c"), Spells.Instances.FalseLife.ID);
            builder.GainSpecificSpell(Guid.Parse("fd38c7a0-08ef-496b-8703-1616c7f19a75"), Spells.Instances.ResilientSphere.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return Items.MeleeWeapons.Instances.Mace.ID;
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
            yield return Skills.Instances.Medicine.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Intelligence.ID;
            yield return Stats.Instances.Wisdom.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Healing.ID;
            yield return Domains.Instances.Knowledge.ID;
            yield return Domains.Instances.Magic.ID;
            yield return Domains.Instances.Protection.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.LawfulGood.ID;
            yield return Alignments.Instances.NeutralGood.ID;
            yield return Alignments.Instances.ChaoticGood.ID;
            yield return Alignments.Instances.TrueNeutral.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("4718652e-57f2-4241-8a4a-117fb8c990c7"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 132
            };
        }
    }
}
