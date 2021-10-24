using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Bloodlines.Instances
{
    public class Nymph : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override Bloodline GetBloodline()
        {
            return new Bloodline
            {
                Id = ID, 
                Name = "Nymph",
                BloodMagic = "Nymph grace accentuates your movements and distracts your foes, either granting you a +1 status bonus to Diplomacy checks for 1 round or imposing a –1 status penalty on one target's Will saves for 1 round.",
                RarityId = Rarities.Instances.Common.ID,
                InitialBloodlineSpellId = Spells.Instances.NymphsToken.ID,
                AdvancedBloodlineSpellId = Spells.Instances.BlindingBeauty.ID,
                GreaterBloodlineSpellId = Spells.Instances.EstablishWard.ID,
                SpellListTraditionId = MagicTraditions.Instances.Primal.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "One of your ancestors was inspired by a nymph, or perhaps was a nymph themself, and now the beauty of nature lives in you." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Diplomacy.ID);
            builder.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Nature.ID);

            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.NymphsToken.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Tanglefoot.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Charm.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.CalmEmotions.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.AnimalVision.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.VitalBeacon.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.CrushingDespair.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Repulsion.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.UnfetteredPack.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.MomentOfRenewal.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.OverwhelmingPresence.ID);
        }

        protected override IEnumerable<Guid> GetSkills()
        {
            yield return Skills.Instances.Diplomacy.ID;
            yield return Skills.Instances.Nature.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 138
            };
        }
    }
}
