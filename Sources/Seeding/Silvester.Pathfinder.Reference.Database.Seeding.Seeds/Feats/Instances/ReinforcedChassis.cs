using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ReinforcedChassis : Template
    {
        public static readonly Guid ID = Guid.Parse("b5748a1c-5706-4fd8-88a8-92c2122f1ea8");

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
            yield return new TextBlock { Id = Guid.Parse("21a6b2e6-506f-4224-8127-6d8c54fbd7f4"), Type = TextBlockType.Text, Text = "Your body is designed to be particularly resilient. Your chassis is medium armor in the plate armor group that grants a +4 item bonus to AC, a Dex cap of +1, a check penalty of –2, a speed penalty of –5 feet, and a Strength value of 16. You can never wear other armor or remove your chassis; however, you still don't become fatigued from sleeping. Finally, you can etch armor runes onto your chassis as normal." };
            yield return new TextBlock { Id = Guid.Parse("0ab77452-8a00-47b8-9566-9db4d709a9e7"), Type = TextBlockType.Text, Text = "__Add (item: automaton chassis) to your inventory and equip it.__" };
            yield return new TextBlock { Id = Guid.Parse("c736be00-04d3-4183-bafe-28aba712c855"), Type = TextBlockType.Text, Text = "----" };
            yield return new TextBlock { Id = Guid.Parse("e70bfbc7-0389-4e83-a6fb-cc72789a915e"), Type = TextBlockType.Text, Text = "~ Enhancement: Your chassis becomes difficult to overcome. You gain the (feat: Chassis Deflection) reaction." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ead03a27-5e98-4d24-88a5-8c0701ce5f77"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
