using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PelagicAptitude : Template
    {
        public static readonly Guid ID = Guid.Parse("03b21bc0-7eef-457c-858b-ee3f010fed26");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Pelagic Aptitude",
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
            yield return new TextBlock { Id = Guid.Parse("bb77e089-ee99-4210-a502-4fb66a031591"), Type = TextBlockType.Text, Text = "You’ve learned special tricks to survive underwater. You gain the trained proficiency rank in Survival. When in an aquatic environment, if you roll a critical failure on a Survival skill check to (action: Sense Direction) or (action: Subsist | Subsist - Survival), you get a failure instead." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("75b0739d-feef-4354-bd06-58fc8f8bb901"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
