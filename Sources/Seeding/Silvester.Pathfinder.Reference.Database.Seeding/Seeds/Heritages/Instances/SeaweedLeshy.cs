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
    public class SeaweedLeshy : Template
    {
        public static readonly Guid ID = Guid.Parse("a2e60b6c-1534-448c-8810-1b7bf72fc094");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Seaweed Leshy"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("7baf11a3-cbe7-4361-9424-81dd5d665b21"), Type = TextBlockType.Text, Text = "Your body is made from woven seaweed, and you're just as comfortable underwater as on land. You gain a swim Speed of 20 feet, and you can always breathe underwater. However, your land Speed is reduced by 5 feet (to 20 feet for most seaweed leshys)." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpeed(Guid.Parse("c762f4fa-e4a0-4109-b287-9d960187bd15"), MovementMethod.Swimming, speed: 20);
            builder.Manual(Guid.Parse("784ea644-d8c1-4b9b-846f-0c07a53043f8"), "You can always breathe underwater.");
            builder.ModifySpecificSpeed(Guid.Parse("03766388-eb6c-438c-a4f9-972495030922"), MovementMethod.Walking, ModifierType.Subtract, modifier: 5);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("690a2ef7-14a5-4e97-9983-2333be860fa3"),
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
