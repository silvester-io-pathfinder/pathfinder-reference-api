using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class FruitLeshy : Template
    {
        public static readonly Guid ID = Guid.Parse("a7110702-6700-4b4d-9984-04f6a1e6efeb");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Fruit Leshy"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("c4f4fdeb-920d-492b-bc91-beb807eaff88"), Type = TextBlockType.Text, Text = "Your body continually produces small fruits imbued with primal magic. At dawn each day, a new fruit ripens. You or an ally can remove this fruit as an Interact action. If a living creature that can derive sustenance from fruit consumes it as an Interact action within the next hour, they regain 1d8 Hit Points, plus an additional 1d8 Hit Points for every 2 of your levels beyond 1st. This effect has the healing, necromancy, and positive traits." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.Manual(Guid.Parse("8f2d2a2e-2007-45e0-a16b-e5c236f32f83"), "Your body continually produces small fruits imbued with primal magic. At dawn each day, a new fruit ripens. You or an ally can remove this fruit as an Interact action. If a living creature that can derive sustenance from fruit consumes it as an Interact action within the next hour, they regain 1d8 Hit Points, plus an additional 1d8 Hit Points for every 2 of your levels beyond 1st. This effect has the healing, necromancy, and positive traits.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ec7b516a-39f1-41bb-9107-69af99475d51"),
                SourceId = Sources.Instances.AncestryGuide.ID,
                Page = 42
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Leshy.ID;
        }
    }
}
