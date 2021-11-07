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
    public class MotherVulture : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.MonitorDemigods.ID,
                AlignmentId = Alignments.Instances.TrueNeutral.ID,
                Name = "Mother Vulture",
                Edicts = "Recycle rot and waste into useful creations, eat the flesh of your own people, kill without mercy if it benefits your community, help to raise children.",
                Anathema = "Poison insects or scavengers, waste food or good materials, allow rot to poison an area, create undead.",
                Title = "The Flesheater",
                AreasOfConcern = "Consumption, renewal, and transformation.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Though she usually appears as a blind young woman, in her natural form the Flesheater is an enormous, bloated creature with four wings and two long necks topped with masked heads and gaping maws. Mother Vulture reflects the dualistic process of decay. She is a vicious killer whose feasts stain the ground, representing the death inherent in decay, but also a thoughtful mother, representing the new life that can take root in the fertile soil left in the wake of destruction. Mother Vulture's mortal worshippers, who often dwell in deserts and swamps, revere her as the patron of consumption, renewal, and transformation. In this last aspect, she judges those souls who sought redemption in life, deciding whether their atonement was sufficient to avoid an undesired afterlife." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Soothe.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.AerialForm.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.BalefulPolymorph.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return MeleeWeapons.Instances.Sickle.ID;
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
            yield return Skills.Instances.Survival.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Constitution.ID;
            yield return Stats.Instances.Wisdom.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Change.ID;
            yield return Domains.Instances.Death.ID;
            yield return Domains.Instances.Decay.ID;
            yield return Domains.Instances.Nature.ID;
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
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 130
            };
        }
    }
}
