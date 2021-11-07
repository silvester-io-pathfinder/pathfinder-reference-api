using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class VerdantPresence : Template
    {
        public static readonly Guid ID = Guid.Parse("a7e70dd7-f873-41fc-a3ba-c8f5d7dc1c74");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Verdant Presence",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You take damage or cast a primal spell.",
                Frequency = "once per hour"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4702dc8f-19c1-4214-844f-eb8e8e6963dd"), Type = TextBlockType.Text, Text = "The life-giving properties of the aeon orbs flourish within you. Small plants or fungi magically appear on all surfaces in a 60-foot emanation around you. This life withers after 1 day unless the environment can support it. You can choose one of the following options each time you use this feat." };
            yield return new TextBlock { Id = Guid.Parse("e65ee685-69f2-44c2-815e-044c0e79e486"), Type = TextBlockType.Enumeration, Text = " : You can cause any number of 5-foot squares in the area to be light undergrowth, which is difficult terrain and provides lesser cover." };
            yield return new TextBlock { Id = Guid.Parse("84bb21f1-ac87-4790-a9d6-0be82b6f0943"), Type = TextBlockType.Enumeration, Text = " : You can cause a tree or giant mushroom to appear in any unoccupied location in the area; it occupies an entire 5-foot square and provides standard cover. The tree or mushroom has 5 Hardness and 50 Hit Points." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a4305dfe-1fba-4206-be58-5fe1391805e3"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
