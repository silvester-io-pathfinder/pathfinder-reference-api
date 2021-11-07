using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DraconicExemplarGold : Template
    {
        public static readonly Guid ID = Guid.Parse("95b962f4-546a-4b64-907e-f6577ae01fa4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Draconic Exemplar - Gold",
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
            yield return new TextBlock { Id = Guid.Parse("ddc11e2a-136a-47a3-9e9e-bd79464dbfa8"), Type = TextBlockType.Text, Text = "Your scale color and appearance resembles that of a gold dragon." };
            yield return new TextBlock { Id = Guid.Parse("3b77ed70-c19d-4313-965d-bdcd38ef8dc2"), Type = TextBlockType.Text, Text = "~ Breath Weapon Shape: Cone" };
            yield return new TextBlock { Id = Guid.Parse("7b895ae3-4c8d-4789-bbd9-538b0d15c502"), Type = TextBlockType.Text, Text = "~ Damage Type: Fire" };
            yield return new TextBlock { Id = Guid.Parse("cd2d0de6-1ea4-49c0-a366-c4dafbc462f4"), Type = TextBlockType.Text, Text = "~ Saving Throw: Reflex" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9b9fb242-cf86-486e-8b10-13b045db2717"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
