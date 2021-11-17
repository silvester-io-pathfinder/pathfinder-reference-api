using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Alchemists
{
    public class PerpetualPotency : Template
    {
        public static readonly Guid ID = Guid.Parse("8cb4d7e9-8f43-44f4-bcd5-6dc22ea33f2a");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 11,
                Name = "Perpetual Potency", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("9ab3fecb-5990-431c-9ea9-fab7b752eaf0"), Type = TextBlockType.Text, Text = "Your perpetual infusions improve, allowing you to use Quick Alchemy to create more powerful items with no cost. The items you can select depend on your research field and must be in your formula book." };
            yield return new TextBlock { Id = Guid.Parse("a4fed4c5-4bf7-4191-988c-3ead31a0ba74"), Type = TextBlockType.Enumeration, Text = "Bomber - The moderate versions of the bombs you chose for perpetual infusions." };
            yield return new TextBlock { Id = Guid.Parse("3a9a55a3-1e5b-4fb6-9c0b-af593ad345ad"), Type = TextBlockType.Enumeration, Text = "Chirurgeon - Moderate antidote and antiplague." };
            yield return new TextBlock { Id = Guid.Parse("0d30dbd3-e6ce-404e-a27a-95c77708eba8"), Type = TextBlockType.Enumeration, Text = "Mutagenist - The moderate versions of the mutagens you chose for perpetual infusions." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //TODO: Add effects.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("00a4e27a-1bf4-47dd-8efe-76bc2295e4bd"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 75
            };
        }
    }
}
