using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PenetratingFire : Template
    {
        public static readonly Guid ID = Guid.Parse("f631436f-7dc6-4a17-b30e-7a5f319933c0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Penetrating Fire",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3adb60ac-b4fa-48a7-b8f6-1f4e361d4c97"), Type = TextBlockType.Text, Text = "You blast a bullet through one foe and into another. Choose two targets, one of which would give the other lesser cover against your ranged attacks. Make a single ranged (action: Strike) with the required weapon against both targets. This attack ignores any lesser cover the nearer target provides the other. Roll damage only once and apply it to each creature you hit. Penetrating Fire counts as two attacks for your multiple attack penalty." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("79f7b4d7-fa38-4325-8ee3-e3f579775a95"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
