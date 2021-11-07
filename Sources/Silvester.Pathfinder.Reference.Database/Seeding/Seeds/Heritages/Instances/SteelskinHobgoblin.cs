using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Ancestries.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class SteelskinHobgoblin : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Steelskin Hobgoblin"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "When you are cut or burned, your body responds by forming tough but flexible callouses over the site of the injury. Over time, this makes the most vulnerable sections of your body harder and more resistant to damage. Many steelskin hobgoblins intentionally use blades and flame to scar themselves in intricate patterns, though this isn't universal. Your flat check to recover from persistent physical (including bleed), energy, or poison damage is DC 13 (rather than DC 15), or DC 8 when provided particularly effective assistance." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.Manual(Guid.Parse(""), "Your flat check to recover from persistent physical (including bleed), energy, or poison damage is DC 13 (rather than DC 15), or DC 8 when provided particularly effective assistance.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AncestryGuide.ID,
                Page = 33
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Hobgoblin.ID;
        }
    }
}
