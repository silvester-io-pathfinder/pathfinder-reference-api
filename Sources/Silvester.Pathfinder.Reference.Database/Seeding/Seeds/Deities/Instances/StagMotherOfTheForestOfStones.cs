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
    public class StagMotherOfTheForestOfStones : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.SarkorianGods.ID,
                AlignmentId = Alignments.Instances.TrueNeutral.ID,
                Name = "Stag Mother of the Forest of Stones",
                Edicts = "Provide shelter and succor for women and children in need, act as a responsible steward of your environment.",
                Anathema = "Harm a pregnant mother or innocent child, including animals.",
                Title = "She Who Listens",
                
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield break;
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.PhantomPain.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.AnimalForm.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.FleshToStone.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return MeleeWeapons.Instances.Ranseur.ID;
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
            
            yield return Stats.Instances.Constitution.ID;
            yield return Stats.Instances.Intelligence.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Family.ID;
            yield return Domains.Instances.Healing.ID;
            yield return Domains.Instances.Nature.ID;
            yield return Domains.Instances.Pain.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.LawfulGood.ID;
            yield return Alignments.Instances.NeutralGood.ID;
            yield return Alignments.Instances.ChaoticGood.ID;
            yield return Alignments.Instances.LawfulNeutral.ID;
            yield return Alignments.Instances.TrueNeutral.ID;
            yield return Alignments.Instances.ChaoticNeutral.ID;
            yield return Alignments.Instances.LawfulEvil.ID;
            yield return Alignments.Instances.NeutralEvil.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 132
            };
        }
    }
}
