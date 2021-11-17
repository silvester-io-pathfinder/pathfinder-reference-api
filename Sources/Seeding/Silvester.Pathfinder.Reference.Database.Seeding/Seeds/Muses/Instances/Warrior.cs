using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Muses.Instances
{
    public class Warrior : Template
    {
        public static readonly Guid ID = Guid.Parse("00383b02-e9ee-45b2-b7c7-062fb48b4e86");
        
        protected override Muse GetMuse()
        {
            return new Muse
            {
                Id = ID, 
                Name = "Warrior",
                Description = "The battlefield is your stage, the clang of steel, your song. Your muse engages in countless battles, whether reveling in combat or resigned to its necessity. If your muse is a creature, it might be an otherworldly soldier, such as a planetar, archon, cornugon, or purrodaemon. If it's a deity, it might be Gorum. As a bard with a warrior muse, you train for battle in addition to performance, and you prepare your allies for the dangers of battle. You might even wade into the thick of things with them. You gain the Martial Performance feat and add fear to your spell repertoire."
            };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificFeat(Guid.Parse("ff74efb4-72aa-4f53-be7b-605f986d90c5"), Feats.Instances.MartialPerformance.ID);
            builder.GainSpecificSpell(Guid.Parse("db2f0923-6f54-4336-ab26-5def8e43df6d"), Spells.Instances.Fear.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("32c0f0a6-5ffb-49ee-bd3c-5fa92592fabb"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 112
            };
        }
    }
}
