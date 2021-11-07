using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DraconicExemplarSilver : Template
    {
        public static readonly Guid ID = Guid.Parse("b8e9fb8a-cdae-4b80-81d6-28a2e878f748");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Draconic Exemplar - Silver",
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
            yield return new TextBlock { Id = Guid.Parse("f0ecf6d7-491b-442d-a0e9-b4bc54718d39"), Type = TextBlockType.Text, Text = "Your scale color and appearance resembles that of a silver dragon." };
            yield return new TextBlock { Id = Guid.Parse("f7ae80b1-facc-412f-ad5e-ed62282d46e0"), Type = TextBlockType.Text, Text = "~ Breath Weapon Shape: Cone" };
            yield return new TextBlock { Id = Guid.Parse("dc28dd55-b4c7-48e3-b555-481e4f8d8775"), Type = TextBlockType.Text, Text = "~ Damage Type: Cold" };
            yield return new TextBlock { Id = Guid.Parse("bf0bf73d-9b9f-4942-92c4-45ff1fb4dd0b"), Type = TextBlockType.Text, Text = "~ Saving Throw: Reflex" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4137b565-3df0-4c38-aede-dd47f7b85ace"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
