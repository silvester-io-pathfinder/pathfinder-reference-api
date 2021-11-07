using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HagMagicClairaudience : Template
    {
        public static readonly Guid ID = Guid.Parse("6a42bfd3-e38c-426c-bbbf-8f84a780c985");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Hag Magic - Clairaudience",
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
            yield return new TextBlock { Id = Guid.Parse("2b48481a-9742-4e97-ae5f-d34012caf733"), Type = TextBlockType.Text, Text = "You can cast (spell: clairaudience) once per day as a 4th-level occult innate spell." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("319bbfec-8386-4d61-96dd-6e3606b293da"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
