using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CremateUndead : Template
    {
        public static readonly Guid ID = Guid.Parse("ba806a18-833b-4c2c-a580-b5e71c78e65a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cremate Undead",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("32757078-740f-4cf3-8ed3-9e43185c63a0"), Type = TextBlockType.Text, Text = "Your positive energy sets undead alight. When you use a (spell: heal) spell to damage undead, each undead that takes damage also takes persistent fire damage equal to the spell’s level." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cf55d407-2a19-47fd-8965-688cf28d36c1"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
