using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ModificationTangleLine : Template
    {
        public static readonly Guid ID = Guid.Parse("3efbfd2e-11a7-4d19-989f-f4ce2a835a85");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Modification - Tangle Line",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a82c851c-6e51-4a13-92e8-64ce875a8bcf"), Type = TextBlockType.Enumeration, Text = "*Thrown Only**" };
            yield return new TextBlock { Id = Guid.Parse("330482ae-817a-4613-95d4-e1615a5a7183"), Type = TextBlockType.Text, Text = "Your weapon has an extensible line that you can use to knock your enemies over and quickly recall the weapon back to your hand. Your innovation gains the (trait: ranged trip) trait and the (trait: tethered) trait." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("868a624c-c6b0-48e2-9c2e-20b61105be22"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
