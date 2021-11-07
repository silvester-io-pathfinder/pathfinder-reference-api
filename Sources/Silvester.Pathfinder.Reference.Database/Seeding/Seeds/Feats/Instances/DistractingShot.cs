using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DistractingShot : Template
    {
        public static readonly Guid ID = Guid.Parse("a7bcad82-4fa2-454e-b255-3f7509604503");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Distracting Shot",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e72c0bf8-baec-4788-8eef-cb9093e70bc4"), Type = TextBlockType.Text, Text = "The sheer power of your attacks, or the overwhelming number of them, leaves an enemy flustered. If you critically hit your hunted prey with a ranged weapon, or hit it at least twice on the same turn with a ranged weapon, it’s flat-footed until the start of your next turn." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("115f395d-5fd3-4201-942f-c7faeb2e006a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
