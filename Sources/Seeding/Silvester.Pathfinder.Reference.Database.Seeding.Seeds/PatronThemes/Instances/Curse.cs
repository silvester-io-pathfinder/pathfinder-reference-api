using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PatronThemes.Instances
{
    public class Curse : Template
    {
        public static readonly Guid ID = Guid.Parse("65fceb38-a25d-4297-a1b4-3f080995ab83");
        
        protected override PatronTheme GetPatronTheme()
        {
            return new PatronTheme
            {
                Id = ID, 
                Name = "Curse",
                Description = "Foiling foes and undermining those who stand in your way are the tools of the curse patrons.",
                RarityId = Rarities.Instances.Common.ID,
                PatronSkillId = Skills.Instances.Occultism.ID,
                MagicTraditionId = MagicTraditions.Instances.Occult.ID,
            };
        }

        protected override IEnumerable<Guid> GetGrantedSpellOptions()
        {
            yield return Spells.Instances.RayOfEnfeeblement.ID;
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpellCasting(Guid.Parse("b02b7adf-0793-4d7c-9e1b-1c68212760e0"), MagicTraditions.Instances.Occult.ID);
            builder.GainSpecificSkillProficiency(Guid.Parse("d9d1b66f-6155-4010-aa43-3ad287e2d5b1"), Proficiencies.Instances.Trained.ID, Skills.Instances.Occultism.ID);
            builder.GainSpecificSpell(Guid.Parse("095f1e44-2ead-40c2-924f-949edde85638"), Spells.Instances.EvilEye.ID);
            builder.GainSpecificSpell(Guid.Parse("7c82a3b7-8ef3-4d0e-accf-e21bf7099596"), Spells.Instances.RayOfEnfeeblement.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2f1e917a-05f3-4d11-81d9-1a59314c5957"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 99
            };
        }
    }
}
