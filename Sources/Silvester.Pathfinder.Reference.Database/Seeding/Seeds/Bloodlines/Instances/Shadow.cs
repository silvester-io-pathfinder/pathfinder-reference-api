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

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpellCasting(Guid.Parse(""), MagicTraditions.Instances.Occult.ID);

            builder.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Occultism.ID);
            builder.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Stealth.ID);

            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.DimTheLight.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.ChillTouch.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.GrimTendrils.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Darkness.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.ChillingDarkness.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.PhantasmalKiller.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.ShadowSiphon.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.CollectiveTransposition.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.DuplicateFoe.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Disappearance.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Weird.ID);
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
