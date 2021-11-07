using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class OrcWarmask : Template
    {
        public static readonly Guid ID = Guid.Parse("15e4ff9f-a1c4-4c62-a6ed-95ff50bcba1e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Orc Warmask",
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
            yield return new TextBlock { Id = Guid.Parse("d67674f3-c8cc-4d5e-8ee8-90e3c6ae7104"), Type = TextBlockType.Text, Text = "You paint your face to create a warmask, an invested magic item of negligible Bulk with an item level equal to your level and a usage of worn (mask). It has the (trait: divination) trait and a magical tradition trait depending on its type. Donning or removing your warmask requires 1 minute of work, though you don’t need to Invest the mask each time. The warmask is unique to you and might signify your hold, your accomplishments, or your faith. While creating your mask, you must choose the source of your warmask’s power from the options below. This source determines the mask’s associated skill as well as magical tradition. Once you select this source, it can’t be changed. You become trained in the associated skill, and you gain the (feat: Dubious Knowledge) skill feat as a bonus feat. You can spend 1 hour performing a ceremony that costs 50 gp to attune yourself more deeply with your warmask. If you do, you gain a +1 item bonus to the associated skill whenever you wear the warmask." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("aa44d6cd-1982-4e89-92da-a4ccb6d80cb7"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
