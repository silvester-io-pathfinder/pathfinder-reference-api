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
    public class Chamidu : Template
    {
        public static readonly Guid ID = Guid.Parse("2718b9d6-f7a8-4cf8-8235-a04d1472dfbb");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.VudraniGods.ID,
                AlignmentId = Alignments.Instances.TrueNeutral.ID,
                Name = "Chamidu",
                Edicts = "Destroy aberrant creatures and fiends, live free of social or materialistic chains, cause destruction when angered.",
                Anathema = "Harm a child, pollute the wilds, refuse to treat an illness.",
                Title = "The Roar of the Storm",
                
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield break;
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("6c11320d-bce3-42dd-b660-5eef10b117b1"), Spells.Instances.SummonAnimal.ID);
            builder.GainSpecificSpell(Guid.Parse("5ea6d6fc-81a7-4a2b-817a-743e309abee0"), Spells.Instances.LightningBolt.ID);
            builder.GainSpecificSpell(Guid.Parse("a1e8295d-f63e-4b7c-8511-dead6a3be91e"), Spells.Instances.MoonFrenzy.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return Items.MeleeWeapons.Instances.Spear.ID;
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
            
            yield return Stats.Instances.Strength.ID;
            yield return Stats.Instances.Constitution.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Healing.ID;
            yield return Domains.Instances.Lightning.ID;
            yield return Domains.Instances.Nature.ID;
            yield return Domains.Instances.Nightmares.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.NeutralGood.ID;
            yield return Alignments.Instances.TrueNeutral.ID;
            yield return Alignments.Instances.NeutralEvil.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("79ea5776-a59a-4f3b-b5e4-3caa8454b349"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 132
            };
        }
    }
}
