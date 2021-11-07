using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Gnaw : Template
    {
        public static readonly Guid ID = Guid.Parse("022ad131-851e-4e2a-b464-4286f7ed3bd9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Gnaw",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("dfb9bbdd-a5a7-4d6c-9719-705508c77040"), Type = TextBlockType.Text, Text = "The (action: Strike)’s target takes 1d6 persistent bleed damage and takes a –10-foot status penalty to its Speed until it removes the bleed damage. If the hyena is a specialized animal companion, the persistent bleed damage increases to 2d6." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d1336121-cd3a-4872-87e0-a2a3e83621ba"),
                SourceId = Sources.Instances.AgeOfAshes.ID,
                Page = -1
            };
        }
    }
}
