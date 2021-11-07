using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BrutalCritical : Template
    {
        public static readonly Guid ID = Guid.Parse("f49ff32a-adc2-4cb1-8ccc-125103c14233");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Brutal Critical",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("bd98c5c5-b7c6-4c6a-be50-441bb6edcf96"), Type = TextBlockType.Text, Text = "Your critical hits are particularly devastating. On a critical hit with a melee (action: Strike), add one extra damage die. This is in addition to any extra dice you gain if the weapon is (trait: deadly) or (trait: fatal). The target also takes persistent bleed damage equal to two damage dice." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("edf18609-8d64-4ac4-b72a-b6ee0a5c7103"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
