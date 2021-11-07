using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DanceOfThunder : Template
    {
        public static readonly Guid ID = Guid.Parse("766d37dc-1bc7-4168-866b-c0ee827c5125");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dance of Thunder",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per minute"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a4ae2ef6-e5ac-48df-83b5-421555a79c9e"), Type = TextBlockType.Text, Text = "Your steps echo with the thunderous retort of exploding black powder as you dance a dance of death. Take any of the following actions you choose in any order: (action: Step), (action: Strike) against a target within your firearm’s first range increment, and (action: Interact) to reload. If you attempted a (action: Strike) and it succeeded, you can repeat these three actions again in any order. If you attempted a (action: Strike) in the second set and succeeded, you can repeat the actions one last time." };
            yield return new TextBlock { Id = Guid.Parse("733f6ab6-361b-415a-b5bf-12f9dcc247fa"), Type = TextBlockType.Text, Text = "After using Dance of Thunder, you become fatigued for 1 minute." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("910ad8d4-fd76-4757-a8b9-250e05f32faf"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
