using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HuntersFangs : Template
    {
        public static readonly Guid ID = Guid.Parse("a71e0d59-7af4-4feb-90c9-eef16c3118ab");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Hunter's Fangs",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("094b2444-f13e-45a8-9e00-ee9f9c8cb5d1"), Type = TextBlockType.Text, Text = "Your fangs are exceptionally painful. Whenever you score a critical hit with your fangs unarmed attack, you apply the unarmed attack’s critical specialization effect." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8f43854b-e5a2-4fd6-8e9d-61ac6b56ba77"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
