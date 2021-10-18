using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Muses.Instances
{
    public class Warrior : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override Muse GetMuse()
        {
            return new Muse
            {
                Id = ID, 
                Name = "Warrior",
                Description = "The battlefield is your stage, the clang of steel, your song. Your muse engages in countless battles, whether reveling in combat or resigned to its necessity. If your muse is a creature, it might be an otherworldly soldier, such as a planetar, archon, cornugon, or purrodaemon. If it's a deity, it might be Gorum. As a bard with a warrior muse, you train for battle in addition to performance, and you prepare your allies for the dangers of battle. You might even wade into the thick of things with them. You gain the Martial Performance feat and add fear to your spell repertoire."
            };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new GainSpecificFeatEffect
            {
                Id = Guid.Parse(""),
                FeatId = Feats.Instances.MartialPerformance.ID
            };

            yield return new GainSpecificSpellEffect
            {
                Id = Guid.Parse(""),
                SpellId = Spells.Instances.Fear.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 112
            };
        }
    }
}
