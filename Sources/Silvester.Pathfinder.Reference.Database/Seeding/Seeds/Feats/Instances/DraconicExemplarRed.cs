using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DraconicExemplarRed : Template
    {
        public static readonly Guid ID = Guid.Parse("01d11404-0455-441a-bc12-e8af7e2174ca");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Draconic Exemplar - Red",
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
            yield return new TextBlock { Id = Guid.Parse("0f047727-2adf-4e11-a6c6-60968036930d"), Type = TextBlockType.Text, Text = "Your scale color and appearance resembles that of a red dragon." };
            yield return new TextBlock { Id = Guid.Parse("e1b8000b-0121-4cc0-bf77-fa336ee78d71"), Type = TextBlockType.Text, Text = "~ Breath Weapon Shape: Cone" };
            yield return new TextBlock { Id = Guid.Parse("913ae603-0b16-4352-b555-0c580b50e39e"), Type = TextBlockType.Text, Text = "~ Damage Type: Fire" };
            yield return new TextBlock { Id = Guid.Parse("f27e9be6-fca9-4f14-861d-1e2cf04bbbd0"), Type = TextBlockType.Text, Text = "~ Saving Throw: Reflex" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("294ae7fa-5338-4d4f-ad71-e96295b6309b"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
