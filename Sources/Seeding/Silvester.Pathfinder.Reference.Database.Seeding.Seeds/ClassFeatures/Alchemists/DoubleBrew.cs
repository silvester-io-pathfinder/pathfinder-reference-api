using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Alchemists
{
    public class DoubleBrew : Template
    {
        public static readonly Guid ID = Guid.Parse("8dba6459-9b68-4419-b98f-ae061aecfe36");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 9,
                Name = "Double Brew", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("5957a412-a9b5-494b-a575-1a92c2756a25"), Type = TextBlockType.Text, Text = "You know your formulas so well that you can concoct two items at once. When using the Quick Alchemy action, instead of spending one batch of infused reagents to create a single item, you can spend up to two batches of infused reagents to make up to two alchemical items as described in that action. These items do not have to be the same." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //TODO: Add effects.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6bbdf704-c096-4b54-8a21-c6e9a5607016"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 75
            };
        }
    }
}
