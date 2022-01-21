using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class VerdantPresence : Template
    {
        public static readonly Guid ID = Guid.Parse("0edcc40b-2aea-478f-ba64-c15662d07a5f");

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
            yield return new TextBlock { Id = Guid.Parse("e7ee8dea-f64a-43ef-8beb-8760ac9b9916"), Type = TextBlockType.Text, Text = "The life-giving properties of the aeon orbs flourish within you. Small plants or fungi magically appear on all surfaces in a 60-foot emanation around you. This life withers after 1 day unless the environment can support it. You can choose one of the following options each time you use this feat." };
            yield return new TextBlock { Id = Guid.Parse("84c4401d-46be-4f90-a752-b2a251363bad"), Type = TextBlockType.Enumeration, Text = " : You can cause any number of 5-foot squares in the area to be light undergrowth, which is difficult terrain and provides lesser cover." };
            yield return new TextBlock { Id = Guid.Parse("74f2b9a0-c601-4c51-8ef0-bc712ec11579"), Type = TextBlockType.Enumeration, Text = " : You can cause a tree or giant mushroom to appear in any unoccupied location in the area; it occupies an entire 5-foot square and provides standard cover. The tree or mushroom has 5 Hardness and 50 Hit Points." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4f6082c0-2acb-4f20-a1c1-b0d5b5f9b102"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
