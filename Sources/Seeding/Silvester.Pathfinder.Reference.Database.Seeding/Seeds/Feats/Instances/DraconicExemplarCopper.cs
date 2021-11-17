using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DraconicExemplarCopper : Template
    {
        public static readonly Guid ID = Guid.Parse("83a6b2a9-db81-4bf1-9639-1d1eb3a89e1e");

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
            yield return new TextBlock { Id = Guid.Parse("8715295a-584b-4680-b372-0540c714f7fc"), Type = TextBlockType.Text, Text = "Your scale color and appearance resembles that of a copper dragon." };
            yield return new TextBlock { Id = Guid.Parse("ce1948c0-3257-4d98-b276-15c7bf611207"), Type = TextBlockType.Text, Text = "~ Breath Weapon Shape: Line" };
            yield return new TextBlock { Id = Guid.Parse("9714c12f-065a-4581-a72e-2ecc1ec9bd4f"), Type = TextBlockType.Text, Text = "~ Damage Type: Acid" };
            yield return new TextBlock { Id = Guid.Parse("53034aea-5cb3-43b2-89cf-53cf181c93f9"), Type = TextBlockType.Text, Text = "~ Saving Throw: Reflex" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("16b0e0a9-e1a4-4c19-ab3b-f4166bdfc5f6"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
