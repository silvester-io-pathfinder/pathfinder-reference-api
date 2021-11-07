using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class OverlookedMastermind : Template
    {
        public static readonly Guid ID = Guid.Parse("acf9034a-182a-472c-8d78-b754d9af9491");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Overlooked Mastermind",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3bf7c096-1e1d-45e5-885b-b6982a71bd1a"), Type = TextBlockType.Text, Text = "Many consider half-orcs little more than dumb brutes. This is offensive to you, but it can occasionally be useful. You are trained in Deception (or another skill of your choice if you were already trained in Deception), and you gain a +2 circumstance bonus to Deception checks to (action: Lie) when specifically claiming ignorance and to Deception DCs against (action: Sense Motive) checks to uncover such lies." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8c3abf88-1abf-4c17-848c-9d3d495938e0"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
