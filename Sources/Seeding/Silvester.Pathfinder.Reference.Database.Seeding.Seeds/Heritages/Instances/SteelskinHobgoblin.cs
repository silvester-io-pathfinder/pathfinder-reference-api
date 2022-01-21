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
        public static readonly Guid ID = Guid.Parse("e6d3913a-f747-4c03-a31d-8c59c057a3b9");

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
            yield return new TextBlock { Id = Guid.Parse("bcc06f18-297b-400c-ab0a-7463f0a6d3c4"), Type = TextBlockType.Text, Text = "When you are cut or burned, your body responds by forming tough but flexible callouses over the site of the injury. Over time, this makes the most vulnerable sections of your body harder and more resistant to damage. Many steelskin hobgoblins intentionally use blades and flame to scar themselves in intricate patterns, though this isn't universal. Your flat check to recover from persistent physical (including bleed), energy, or poison damage is DC 13 (rather than DC 15), or DC 8 when provided particularly effective assistance." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.Manual(Guid.Parse("522d448b-b0bd-473e-901f-a7c2f757265d"), "Your flat check to recover from persistent physical (including bleed), energy, or poison damage is DC 13 (rather than DC 15), or DC 8 when provided particularly effective assistance.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c557298f-aab9-4582-87e9-514d210f1894"),
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
