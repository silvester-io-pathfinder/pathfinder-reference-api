using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EnvenomedEdges : Template
    {
        public static readonly Guid ID = Guid.Parse("393ecd1d-d8cf-4ab6-807f-4a0c0f411634");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Envenomed Edges",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("13c55185-a261-4a95-aaa8-1695f776f951"), Type = TextBlockType.Text, Text = "With a combination of your poison glands and herbal concoctions, you can consistently deliver venomous attacks when you hit an enemy’s weak points. When you critically hit using a (action: Strike) with a weapon or unarmed attack and deal slashing or piercing damage with that (action: Strike), you deal an additional 1d4 persistent poison damage to your target." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("df5c446b-09aa-4a50-904a-2e94b55de7b7"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
