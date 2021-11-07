using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HastedAssault : Template
    {
        public static readonly Guid ID = Guid.Parse("92d52d74-6669-42e0-a3c3-d601f8467786");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Hasted Assault",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f3bfff9a-5c91-44fa-948e-10a8604973d7"), Type = TextBlockType.Text, Text = "You can speed yourself up to move and attack more swiftly. You learn the (spell: hasted assault) conflux spell. Increase the number of Focus Points in your focus pool by 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveFocusPool(Guid.Parse("6b337312-cafb-44ae-aef4-1317c333dbf3"));
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e7f60b2b-e373-4d38-9361-d2a8734da685"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
