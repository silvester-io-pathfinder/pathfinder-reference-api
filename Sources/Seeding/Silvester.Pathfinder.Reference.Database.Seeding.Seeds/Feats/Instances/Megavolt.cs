using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Megavolt : Template
    {
        public static readonly Guid ID = Guid.Parse("bf004e14-7b87-4671-a3d0-2dfa9f6a4749");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Megavolt",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "If your innovation is a minion, it can take this action rather than you.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a8781af2-60ca-461d-8efa-1918d790739e"), Type = TextBlockType.Text, Text = "You bleed off some electric power from your innovation in the shape of a damaging bolt. Creatures in a 20-foot line from your innovation take 3d4 electricity damage, with a basic Reflex save against your class DC." };
            yield return new TextBlock { Id = Guid.Parse("bc0b0c95-fa7f-4817-8a74-b37e98a36651"), Type = TextBlockType.Text, Text = "The electricity damage increases by 1d4 at 8th level and every 2 levels thereafter." };
            yield return new TextBlock { Id = Guid.Parse("e5c9fdd2-eb6d-4bf8-a77b-d77383e1dc23"), Type = TextBlockType.Text, Text = "----" };
            yield return new TextBlock { Id = Guid.Parse("6f13cf0b-134b-43cf-baf1-c53c565706f8"), Type = TextBlockType.Text, Text = "~ Unstable Function: You overload and supercharge the voltage even higher. Add the (trait: unstable) trait to Megavolt. The area increases to a 60-foot line and the damage increases from d4s to d12s." };
            yield return new TextBlock { Id = Guid.Parse("2f5d7436-1d9a-4d81-8924-d3daabfd2e62"), Type = TextBlockType.Text, Text = ":&gt; If you have the breakthrough innovation class feature, you can choose a 60-foot or 90-foot line for the area when you use an unstable Megavolt; if you also have the revolutionary innovation class feature, you can choose a 60-foot, 90-foot, or 120-foot line." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7d0bbc17-09a6-4a7f-83b2-f86dd2b9935c"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
