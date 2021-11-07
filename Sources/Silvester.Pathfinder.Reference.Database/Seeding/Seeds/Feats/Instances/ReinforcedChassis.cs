using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ReinforcedChassis : Template
    {
        public static readonly Guid ID = Guid.Parse("17f311e6-4a1a-4e3d-8ca2-463cdd184a3c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Reinforced Chassis",
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
            yield return new TextBlock { Id = Guid.Parse("59c896b9-356f-410b-9b4a-ad50d3a9a06a"), Type = TextBlockType.Text, Text = "Your body is designed to be particularly resilient. Your chassis is medium armor in the plate armor group that grants a +4 item bonus to AC, a Dex cap of +1, a check penalty of –2, a speed penalty of –5 feet, and a Strength value of 16. You can never wear other armor or remove your chassis; however, you still don’t become fatigued from sleeping. Finally, you can etch armor runes onto your chassis as normal." };
            yield return new TextBlock { Id = Guid.Parse("75d80b2d-35d4-4a81-bb9e-fff49db6cfd4"), Type = TextBlockType.Text, Text = "__Add (item: automaton chassis) to your inventory and equip it.__" };
            yield return new TextBlock { Id = Guid.Parse("d797b890-4558-4982-8229-962c4628f207"), Type = TextBlockType.Text, Text = "----" };
            yield return new TextBlock { Id = Guid.Parse("c18c704d-a753-449a-93b6-786c7764891b"), Type = TextBlockType.Text, Text = "~ Enhancement: Your chassis becomes difficult to overcome. You gain the (feat: Chassis Deflection) reaction." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("de43a33e-214b-45ae-a2c3-8b1d05330ba1"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
