using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Megavolt : Template
    {
        public static readonly Guid ID = Guid.Parse("42197c3c-49ec-45d1-95de-0b49eb04ab39");

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
            yield return new TextBlock { Id = Guid.Parse("088441bd-d67a-4265-b743-8d158df9ecfd"), Type = TextBlockType.Text, Text = "You bleed off some electric power from your innovation in the shape of a damaging bolt. Creatures in a 20-foot line from your innovation take 3d4 electricity damage, with a basic Reflex save against your class DC." };
            yield return new TextBlock { Id = Guid.Parse("b6ba25fb-0ddd-4dd4-8194-0ed4b623e986"), Type = TextBlockType.Text, Text = "The electricity damage increases by 1d4 at 8th level and every 2 levels thereafter." };
            yield return new TextBlock { Id = Guid.Parse("18ae799c-d1e6-4547-aaf6-21efe9288286"), Type = TextBlockType.Text, Text = "----" };
            yield return new TextBlock { Id = Guid.Parse("5d65fea2-fbb2-4fc6-8917-e42778360ba1"), Type = TextBlockType.Text, Text = "~ Unstable Function: You overload and supercharge the voltage even higher. Add the (trait: unstable) trait to Megavolt. The area increases to a 60-foot line and the damage increases from d4s to d12s." };
            yield return new TextBlock { Id = Guid.Parse("78c200ec-75ef-4828-9e5c-fbd2ad0f33c3"), Type = TextBlockType.Text, Text = ":&gt; If you have the breakthrough innovation class feature, you can choose a 60-foot or 90-foot line for the area when you use an unstable Megavolt; if you also have the revolutionary innovation class feature, you can choose a 60-foot, 90-foot, or 120-foot line." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("20809c79-64d9-47b0-92b9-69a0baf62415"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
