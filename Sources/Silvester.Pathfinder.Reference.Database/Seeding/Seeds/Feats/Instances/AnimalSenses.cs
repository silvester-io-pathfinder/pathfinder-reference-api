using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AnimalSenses : Template
    {
        public static readonly Guid ID = Guid.Parse("d909c6c4-7ff1-4cd3-a21f-0cff801c00ef");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Animal Senses",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = true,
                Special = "You can select this feat multiple times, choosing a different sense each time.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("142fbc6c-4f8b-4157-9c83-0cb5dc266e17"), Type = TextBlockType.Text, Text = "You gain one of the following senses available to your inherent animal: darkvision, low-light vision, or scent (imprecise) 30 feet. You must have low-light vision before you can gain darkvision with this feat. If your inherent animal doesn’t typically have a specific type of sense, you can’t gain that sense with this feat." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c073c3ab-1d32-48e2-8ef0-62ef78f0c0c2"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
