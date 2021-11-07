using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DraconicExemplarRed : Template
    {
        public static readonly Guid ID = Guid.Parse("f025b508-a846-46ed-b603-11ddc2cfdc16");

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
            yield return new TextBlock { Id = Guid.Parse("8061d792-14b6-4d76-a1e4-b8f82a2c294a"), Type = TextBlockType.Text, Text = "Your scale color and appearance resembles that of a red dragon." };
            yield return new TextBlock { Id = Guid.Parse("e775e34b-6fe6-40a2-869f-b1138d05abc6"), Type = TextBlockType.Text, Text = "~ Breath Weapon Shape: Cone" };
            yield return new TextBlock { Id = Guid.Parse("5a83a7bb-ab03-45a0-ada7-22171eb8cdb2"), Type = TextBlockType.Text, Text = "~ Damage Type: Fire" };
            yield return new TextBlock { Id = Guid.Parse("ae90f898-0d79-4996-857e-b9788ded2721"), Type = TextBlockType.Text, Text = "~ Saving Throw: Reflex" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d4d65c67-06d5-4571-bbf4-f4354fa89802"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
