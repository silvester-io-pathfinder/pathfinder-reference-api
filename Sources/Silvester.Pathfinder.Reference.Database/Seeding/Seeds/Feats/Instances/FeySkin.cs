using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FeySkin : Template
    {
        public static readonly Guid ID = Guid.Parse("896d764d-8e2a-41f8-bc44-f68146e9ab14");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fey Skin",
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
            yield return new TextBlock { Id = Guid.Parse("5cc45c0a-e17e-4352-80a2-a074e7c69825"), Type = TextBlockType.Text, Text = "While you are more susceptible to cold iron than most of the Wingless, you also have an incredible resilience and a deeper connection to the healing energies of the First World. Increase your maximum Hit Points by an amount equal to your level. If you rest for 10 minutes, brilliant light from the First World seeps into your form from your wings (or the spot where your wings would be), causing you to regain a number of Hit Points equal to your level; this is cumulative with any Hit Points you regain from (action: Treat Wounds). However, you gain weakness 5 to cold iron." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7c7ae1b7-d756-4fd2-8929-29bb5434b3eb"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
