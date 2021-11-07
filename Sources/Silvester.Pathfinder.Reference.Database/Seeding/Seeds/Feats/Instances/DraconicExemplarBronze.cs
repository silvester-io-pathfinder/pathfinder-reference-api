using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DraconicExemplarBronze : Template
    {
        public static readonly Guid ID = Guid.Parse("631d14af-ec2f-419a-b952-3e66095e9bc3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Draconic Exemplar - Bronze",
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
            yield return new TextBlock { Id = Guid.Parse("8758b98d-2205-4b11-bd67-9dea2d071655"), Type = TextBlockType.Text, Text = "Your scale color and appearance resembles that of a bronze dragon." };
            yield return new TextBlock { Id = Guid.Parse("78397f7b-8d99-4c2e-b8f5-536764a67c90"), Type = TextBlockType.Text, Text = "~ Breath Weapon Shape: Line" };
            yield return new TextBlock { Id = Guid.Parse("c4da1c93-97e1-4f45-ac44-6625db05a9b3"), Type = TextBlockType.Text, Text = "~ Damage Type: Electricity" };
            yield return new TextBlock { Id = Guid.Parse("adb87e6d-cdcf-47d3-8026-4bb67f5cafbc"), Type = TextBlockType.Text, Text = "~ Saving Throw: Reflex" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3a1301ae-cd13-436f-8b96-c18e8d62adcd"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
