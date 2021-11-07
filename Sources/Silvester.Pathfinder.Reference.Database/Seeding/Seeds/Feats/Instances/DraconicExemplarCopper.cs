using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DraconicExemplarCopper : Template
    {
        public static readonly Guid ID = Guid.Parse("27c786f1-1773-417a-9e7e-0156ab3d6f18");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Draconic Exemplar - Copper",
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
            yield return new TextBlock { Id = Guid.Parse("8789d8d6-9a79-48b3-96bd-ce39cd12da41"), Type = TextBlockType.Text, Text = "Your scale color and appearance resembles that of a copper dragon." };
            yield return new TextBlock { Id = Guid.Parse("610e4818-f2f1-4db4-9011-5383d077dbea"), Type = TextBlockType.Text, Text = "~ Breath Weapon Shape: Line" };
            yield return new TextBlock { Id = Guid.Parse("8899a744-0234-4104-82dc-d820d1ef145f"), Type = TextBlockType.Text, Text = "~ Damage Type: Acid" };
            yield return new TextBlock { Id = Guid.Parse("9ac089b2-9834-4259-a1df-81199b21e372"), Type = TextBlockType.Text, Text = "~ Saving Throw: Reflex" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e2aa1823-5eec-48be-8314-830b919c4ddd"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
