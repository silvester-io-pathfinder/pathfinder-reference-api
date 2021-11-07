using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DraconicExemplarGreen : Template
    {
        public static readonly Guid ID = Guid.Parse("90abf11f-dfce-4da4-ab4c-5dcc8a831bae");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Draconic Exemplar - Green",
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
            yield return new TextBlock { Id = Guid.Parse("3318d4f9-97b1-4485-ab18-b81323fa4393"), Type = TextBlockType.Text, Text = "Your scale color and appearance resembles that of a green dragon." };
            yield return new TextBlock { Id = Guid.Parse("e8ff396c-af63-498f-8c4c-894a7321d903"), Type = TextBlockType.Text, Text = "~ Breath Weapon Shape: Cone" };
            yield return new TextBlock { Id = Guid.Parse("8e837a6a-d40c-4cde-b76f-67dc3a02d34f"), Type = TextBlockType.Text, Text = "~ Damage Type: Poison" };
            yield return new TextBlock { Id = Guid.Parse("79e9c49f-9cc8-43a2-9a98-fc336d3600c9"), Type = TextBlockType.Text, Text = "~ Saving Throw: Fortitude" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d253913c-2849-4425-9961-447a424deef7"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
