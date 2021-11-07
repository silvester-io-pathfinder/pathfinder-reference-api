using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class StormsLash : Template
    {
        public static readonly Guid ID = Guid.Parse("1cb6f755-df4e-4aa7-b78f-92973fa3570e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Storm's Lash",
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
            yield return new TextBlock { Id = Guid.Parse("33995557-844f-493a-861d-96aae48bec88"), Type = TextBlockType.Text, Text = "Wind and lightning have always been close friends to you. You can cast the (spell: electric arc) cantrip as a primal innate spell at will. A cantrip is heightened to a spell level equal to half your level rounded up." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("26841ebf-ed8d-432b-8b18-174ff008fb4f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
