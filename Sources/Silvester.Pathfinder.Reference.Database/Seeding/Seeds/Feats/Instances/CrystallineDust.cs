using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CrystallineDust : Template
    {
        public static readonly Guid ID = Guid.Parse("0d844bc4-8893-4ac6-b591-32e7a8702264");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Crystalline Dust",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e9d1e327-da70-4918-9dfa-dab8eff2dfb2"), Type = TextBlockType.Text, Text = "You’ve learned to disperse the crystalline motes coating your body as a haze. You become concealed, though you can’t use this concealment to (action: Hide) or (action: Sneak), as normal for concealment where your position is still obvious. The motes stay within an inch of your skin, move with you, and last for a number of rounds equal to half your level." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f7e132ce-c7aa-4a0b-afcd-8a7127f8ba9e"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
