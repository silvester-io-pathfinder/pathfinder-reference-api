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
    public class Maestro : Template
    {
        public static readonly Guid ID = Guid.Parse("48972661-ebe3-4b8a-91b8-3938041ff7f1");
        
        protected override Muse GetMuse()
        {
            return new Muse
            {
                Id = ID, 
                Name = "Maestro",
                Description = "Your muse is a virtuoso, inspiring you to greater heights. If it's a creature, it might be a performance-loving creature such as a choral angel or lillend azata; if a deity, it might be Shelyn. As a bard with a maestro muse, you are an inspiration to your allies and confident of your musical and oratorical abilities. You gain the Lingering Composition feat and add soothe to your spell repertoire."
            };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificFeat(Guid.Parse("367aac90-6f3c-49ea-b83c-e4f42f09f868"), Feats.Instances.LingeringComposition.ID);
            builder.GainSpecificSpell(Guid.Parse("085a4ea4-fb54-4b3a-8f38-0b896419415e"), Spells.Instances.Soothe.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("332320c2-05da-4204-bd0b-5f3e60a42e94"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 97
            };
        }
    }
}
