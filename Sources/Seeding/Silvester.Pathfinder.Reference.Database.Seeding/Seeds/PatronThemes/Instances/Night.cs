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
    public class Night : Template
    {
        public static readonly Guid ID = Guid.Parse("1ffe0f3e-0484-433a-b293-2826ce5b838d");
        
        protected override PatronTheme GetPatronTheme()
        {
            return new PatronTheme
            {
                Id = ID, 
                Name = "Night",
                Description = "Your patron speaks from the shadows, granting you power over darkness and dreams.",
                RarityId = Rarities.Instances.Common.ID,
                PatronSkillId = Skills.Instances.Occultism.ID,
                MagicTraditionId = MagicTraditions.Instances.Occult.ID,
            };
        }

        protected override IEnumerable<Guid> GetGrantedSpellOptions()
        {
            yield return Spells.Instances.Sleep.ID;
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpellCasting(Guid.Parse("59b9719a-54c0-4065-9252-9f26cedf4c1d"), MagicTraditions.Instances.Occult.ID);
            builder.GainSpecificSkillProficiency(Guid.Parse("fcd8cb1d-3861-438e-a429-afbcba704577"), Proficiencies.Instances.Trained.ID, Skills.Instances.Occultism.ID);
            builder.GainSpecificSpell(Guid.Parse("b96e9c33-8e30-4cab-8e37-0bcda0b79eec"), Spells.Instances.ShroudOfNight.ID);
            builder.GainSpecificSpell(Guid.Parse("a12e5f39-925b-472c-ab9e-1da7a55cfa07"), Spells.Instances.Sleep.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("13980425-f4ff-4539-9c05-cc64abb8807c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 99
            };
        }
    }
}
