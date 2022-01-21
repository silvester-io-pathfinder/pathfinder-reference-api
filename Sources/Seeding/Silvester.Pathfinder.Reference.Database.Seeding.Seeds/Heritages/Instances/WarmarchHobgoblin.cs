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
    public class WarmarchHobgoblin : Template
    {
        public static readonly Guid ID = Guid.Parse("c93c51f1-a21f-469e-b14e-189afba91bba");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Warmarch Hobgoblin"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("b4561a3f-d8c9-43c1-b953-4a10d3e694eb"), Type = TextBlockType.Text, Text = "You come from a line of wandering mercenaries, constantly on the march and scavenging food on the trail. If you fail, but not critically fail, to Subsist in the wilderness, you can still keep yourself fed with poor meals. When exploring, you can Hustle twice as long before you have to stop." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.Manual(Guid.Parse("164eda0d-304f-4fe2-858e-175d6b214ef1"), "If you fail, but not critically fail, to Subsist in the wilderness, you can still keep yourself fed with poor meals.");
            builder.Manual(Guid.Parse("65f5b79f-0109-4c87-aeba-8a845e91b06e"), "When exploring, you can Hustle twice as long before you have to stop.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("760ff325-5e6f-4ff1-93fd-e4dddfc6b07c"),
                SourceId = Sources.Instances.CharacterGuide.ID,
                Page = 49
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Hobgoblin.ID;
        }
    }
}
