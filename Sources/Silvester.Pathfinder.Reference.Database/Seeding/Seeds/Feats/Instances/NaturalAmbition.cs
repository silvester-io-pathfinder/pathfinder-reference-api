using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class NaturalAmbition : Template
    {
        public static readonly Guid ID = Guid.Parse("c049a219-9dfd-449c-a796-05c8bccc531e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Natural Ambition",
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
            yield return new TextBlock { Id = Guid.Parse("d8f6e59d-0714-4f1c-af86-4bc1b04c3478"), Type = TextBlockType.Text, Text = "You were raised to be ambitious and always reach for the stars, leading you to progress quickly in your chosen field. You gain a 1st-level class feat for your class." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e261fb13-1f68-4626-b61d-5289d87f84d5"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
