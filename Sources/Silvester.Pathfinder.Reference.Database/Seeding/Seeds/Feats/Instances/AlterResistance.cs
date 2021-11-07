using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AlterResistance : Template
    {
        public static readonly Guid ID = Guid.Parse("dbecfe32-fe56-4f71-bc4a-5ded51b34ae6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Alter Resistance",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You take acid, electricity, or sonic damage.",
                Frequency = "once per hour"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("84b680b7-ba22-4c02-92bb-80227f47ddca"), Type = TextBlockType.Text, Text = "You focus on your protean forebears to change your energy resistance. The energy resistance you gain from your ganzi heritage changes to match the triggering damage. This change occurs after the damage is dealt." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("583e0641-5729-4fbb-b257-07734b690b09"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
