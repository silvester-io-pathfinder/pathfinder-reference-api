using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Bloodlines.Instances
{
    public class Shadow : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override Bloodline GetBloodline()
        {
            return new Bloodline
            {
                Id = ID, 
                Name = "Shadow",
                BloodMagic = "Shadows grow deeper around you or one target, either granting a +1 status bonus to Stealth or imposing a –1 status penalty to Perception for 1 round.",
                RarityId = Rarities.Instances.Common.ID,
                InitialBloodlineSpellId = Spells.Instances.DimTheLight.ID,
                AdvancedBloodlineSpellId = Spells.Instances.StealShadow.ID,
                GreaterBloodlineSpellId = Spells.Instances.ConsumingDarkness.ID,
                SpellListTraditionId = MagicTraditions.Instances.Occult.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Whether due to a velstrac's manipulations or a planar jaunt gone horribly wrong, your bloodline was infused with a vein of shadow." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new GainSpecificSkillProficiencyEffect { Id = Guid.Parse(""), SkillId = Skills.Instances.Occultism.ID, ProficiencyId = Proficiencies.Instances.Trained.ID };
            yield return new GainSpecificSkillProficiencyEffect { Id = Guid.Parse(""), SkillId = Skills.Instances.Stealth.ID, ProficiencyId = Proficiencies.Instances.Trained.ID };
            yield return new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.DimTheLight.ID };
            yield return new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.ChillTouch.ID };
            yield return new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.GrimTendrils.ID };
            yield return new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.Darkness.ID };
            yield return new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.ChillingDarkness.ID };
            yield return new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.PhantasmalKiller.ID };
            yield return new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.ShadowSiphon.ID };
            yield return new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.CollectiveTransposition.ID };
            yield return new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.DuplicateFoe.ID };
            yield return new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.Disappearance.ID };
            yield return new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.Weird.ID };
        }

        protected override IEnumerable<Guid> GetSkills()
        {
            yield return Skills.Instances.Occultism.ID;
            yield return Skills.Instances.Stealth.ID;
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
