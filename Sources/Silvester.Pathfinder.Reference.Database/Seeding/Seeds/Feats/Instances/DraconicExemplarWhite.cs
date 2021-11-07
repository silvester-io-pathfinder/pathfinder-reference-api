using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DraconicExemplarWhite : Template
    {
        public static readonly Guid ID = Guid.Parse("7a642cc6-204e-4d4f-97ae-06115d35f87a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Draconic Exemplar - White",
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
            yield return new TextBlock { Id = Guid.Parse("653b383e-798a-4cd0-9c32-ac36bce42d5e"), Type = TextBlockType.Text, Text = "Your scale color and appearance resembles that of a white dragon." };
            yield return new TextBlock { Id = Guid.Parse("7b145c27-4828-4bd2-873c-3ba8fb9b7f39"), Type = TextBlockType.Text, Text = "~ Breath Weapon Shape: Cone" };
            yield return new TextBlock { Id = Guid.Parse("fdfb4f69-512b-40e9-a9d8-f0916a640a36"), Type = TextBlockType.Text, Text = "~ Damage Type: Cold" };
            yield return new TextBlock { Id = Guid.Parse("05afceb2-bf79-4b5c-92a1-85ab074381e1"), Type = TextBlockType.Text, Text = "~ Saving Throw: Reflex" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2cd92abb-2508-4f37-b590-d0fcdedf499e"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
