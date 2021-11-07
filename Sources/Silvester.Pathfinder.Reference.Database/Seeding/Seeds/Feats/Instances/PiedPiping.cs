using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PiedPiping : Template
    {
        public static readonly Guid ID = Guid.Parse("4ca2144e-4aea-48b9-b24f-35868f78b8a5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Pied Piping",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("09cd66b5-f69e-454a-859e-7e48558f9e82"), Type = TextBlockType.Text, Text = "You learn the (spell: pied piping) composition spell, which enables you to control the actions of weak-minded individuals." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d60b67bf-424a-4d2a-823c-b605a55407d9"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
