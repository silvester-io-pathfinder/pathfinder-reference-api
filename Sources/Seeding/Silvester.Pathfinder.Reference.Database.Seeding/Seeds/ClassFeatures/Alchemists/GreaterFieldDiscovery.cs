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
    public class GreaterFieldDiscovery : Template
    {
        public static readonly Guid ID = Guid.Parse("88892695-7750-4c72-9700-0fa99d554257");

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
            yield return new TextBlock { Id = Guid.Parse("5c3c5dc7-545a-4f65-9d58-84c5700ad970"), Type = TextBlockType.Text, Text = "You learn an incredible discovery that advances your understanding of your field." };
            yield return new TextBlock { Id = Guid.Parse("82690e79-a9f0-47d5-8cd4-4bf8fd3e32ac"), Type = TextBlockType.Enumeration, Text = "Bomber - You can increase the splash on your bombs to damage creatures within 10 feet, or 15 feet if you have Expanded Splash." };
            yield return new TextBlock { Id = Guid.Parse("4afe8273-12c2-4a5d-a55e-ca234853a271"), Type = TextBlockType.Enumeration, Text = "Chirurgeon - When you use Quick Alchemy to create any type of elixir of life, the creature drinking the elixir gains the maximum Hit Points possible for that elixir, instead of rolling to determine the number of Hit Points regained." };
            yield return new TextBlock { Id = Guid.Parse("198a9925-d55b-41bf-bce9-2569bdd637da"), Type = TextBlockType.Enumeration, Text = "Mutagenist - If you imbibe another mutagen while you are under the effects of a mutagen, you can gain the benefits and the drawbacks of both mutagens at once, despite the fact that they both have the polymorph trait and would not normally function together. If you come under the effects of any further mutagens while benefiting from two mutagens, you lose the benefit of one of the former mutagens of your choice, while retaining the drawbacks of all the mutagens. If you are under the effects of two mutagens and you come under the effect of a non-mutagen polymorph effect, you lose the benefits of the mutagens while retaining the drawbacks of both." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //TODO: Add effects.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("712caffc-2ec0-4f11-a699-7b50aa605bed"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 75
            };
        }
    }
}