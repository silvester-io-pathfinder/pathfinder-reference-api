using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DerringDo : Template
    {
        public static readonly Guid ID = Guid.Parse("74c8a75b-04ac-42ba-9faf-e9f5a36cf623");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Derring-Do",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e5146efc-b17d-43f0-a877-6448f93f685f"), Type = TextBlockType.Text, Text = "When you compound panache with even more derring-do, it somehow tends to work out. When you already have panache, you can roll twice and use the higher result on checks to which the circumstance bonus for having panache applies ((action: Tumble Through) and any skill actions listed in your swashbuckler’s style)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4fa88c18-d7a7-48c0-ae96-4696fd33a9d9"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
