using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LoyalEmpath : Template
    {
        public static readonly Guid ID = Guid.Parse("1c6b67fe-29e7-4bc8-9e8f-6b43e008d413");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Loyal Empath",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0f0f6130-dce7-4cff-927c-191baec59385"), Type = TextBlockType.Text, Text = "You have incredible empathy for your friends and family, and you have an innate timing for helping others in distress. You can use the (Action: Aid) reaction to grant a bonus to another creature’s Will saving throw. As usual for (Action: Aid), you need to prepare by using an action on your turn to encourage the creature to bravely withstand the effect." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("42eb77ef-0dc5-483f-99b6-715f1ae5a0a8"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
