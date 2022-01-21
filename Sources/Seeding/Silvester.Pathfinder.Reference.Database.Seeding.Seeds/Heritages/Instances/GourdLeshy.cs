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
    public class GourdLeshy : Template
    {
        public static readonly Guid ID = Guid.Parse("ee8aadd4-9fc1-4dab-ad82-b2ac4314b19c");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Gourd Leshy"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("5568850a-70cf-4d19-8891-3e6a25cecab6"), Type = TextBlockType.Text, Text = "You have a large gourd for a skull. Your knowledge comes from within your spirit, rather than a physical brain, and you have found a handier use for the space inside your head. You can store a collection of up to 1 Bulk of objects within your head. The DC of checks to Steal objects from inside your head increases by 4. Additionally, if you store only one object within your head, you can draw it effortlessly into your hand as part of another action to use the object. Drawing the item grants this other action the manipulate trait." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.Manual(Guid.Parse("1d2648e4-5d6b-438f-95d9-428c303f40c7"), "You can store a collection of up to 1 Bulk of objects within your head. The DC of checks to Steal objects from inside your head increases by 4. Additionally, if you store only one object within your head, you can draw it effortlessly into your hand as part of another action to use the object. Drawing the item grants this other action the manipulate trait.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0c79d541-980c-4f81-90ac-b4c8858a82da"),
                SourceId = Sources.Instances.CharacterGuide.ID,
                Page = 53
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Leshy.ID;
        }
    }
}
