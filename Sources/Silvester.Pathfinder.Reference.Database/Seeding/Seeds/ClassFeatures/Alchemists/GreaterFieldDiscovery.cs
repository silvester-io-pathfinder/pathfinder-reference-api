using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Instances
{
    public class GreaterFieldDiscovery : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 13,
                Name = "Greater Field Discovery", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You learn an incredible discovery that advances your understanding of your field." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Bomber - You can increase the splash on your bombs to damage creatures within 10 feet, or 15 feet if you have Expanded Splash." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Chirurgeon - When you use Quick Alchemy to create any type of elixir of life, the creature drinking the elixir gains the maximum Hit Points possible for that elixir, instead of rolling to determine the number of Hit Points regained." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Mutagenist - If you imbibe another mutagen while you are under the effects of a mutagen, you can gain the benefits and the drawbacks of both mutagens at once, despite the fact that they both have the polymorph trait and would not normally function together. If you come under the effects of any further mutagens while benefiting from two mutagens, you lose the benefit of one of the former mutagens of your choice, while retaining the drawbacks of all the mutagens. If you are under the effects of two mutagens and you come under the effect of a non-mutagen polymorph effect, you lose the benefits of the mutagens while retaining the drawbacks of both." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            //TODO: Add effects.
            yield break;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 75
            };
        }
    }
}
