using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PelagicAptitude : Template
    {
        public static readonly Guid ID = Guid.Parse("276060b5-afef-47c6-85b2-a48048398034");

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
            yield return new TextBlock { Id = Guid.Parse("e576e9b3-5752-4558-a010-366108a5c760"), Type = TextBlockType.Text, Text = "You’ve learned special tricks to survive underwater. You gain the trained proficiency rank in Survival. When in an aquatic environment, if you roll a critical failure on a Survival skill check to (action: Sense Direction) or (action: Subsist | Subsist - Survival), you get a failure instead." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9740f851-ce80-42d5-a06b-bbfd5d69046b"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
