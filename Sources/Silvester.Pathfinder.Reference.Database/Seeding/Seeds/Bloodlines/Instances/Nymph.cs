using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
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

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new GainSpecificSkillProficiencyEffect { Id = Guid.Parse(""), SkillId = Skills.Instances.Diplomacy.ID, ProficiencyId = Proficiencies.Instances.Trained.ID };
            yield return new GainSpecificSkillProficiencyEffect { Id = Guid.Parse(""), SkillId = Skills.Instances.Nature.ID, ProficiencyId = Proficiencies.Instances.Trained.ID };
            yield return new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.NymphsToken.ID };
            yield return new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.Tanglefoot.ID };
            yield return new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.Charm.ID };
            yield return new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.CalmEmotions.ID };
            yield return new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.AnimalVision.ID };
            yield return new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.VitalBeacon.ID };
            yield return new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.CrushingDespair.ID };
            yield return new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.Repulsion.ID };
            yield return new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.UnfetteredPack.ID };
            yield return new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.MomentOfRenewal.ID };
            yield return new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.OverwhelmingPresence.ID };
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
