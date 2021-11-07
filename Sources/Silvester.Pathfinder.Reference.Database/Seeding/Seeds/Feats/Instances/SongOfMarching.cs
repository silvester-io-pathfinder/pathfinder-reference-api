using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SongOfMarching : Template
    {
        public static readonly Guid ID = Guid.Parse("38fd3491-94fe-4683-a3bf-b124e26199a1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Song of Marching",
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
            yield return new TextBlock { Id = Guid.Parse("b36bc705-1164-47b2-97d6-d968535afabf"), Type = TextBlockType.Text, Text = "You learn the (spell: song of marching) composition cantrip, which enables you and your allies to cross vast distances without strain." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0a04c662-9b57-460e-bc69-1b467ed4b8a3"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
