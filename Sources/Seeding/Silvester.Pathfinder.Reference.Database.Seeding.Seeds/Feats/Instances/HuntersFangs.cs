using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HuntersFangs : Template
    {
        public static readonly Guid ID = Guid.Parse("6f500f03-3f2b-4906-b29b-42a584e7026a");

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
            yield return new TextBlock { Id = Guid.Parse("cc1033ab-bcc8-4157-81af-b3ee5458b13a"), Type = TextBlockType.Text, Text = $"Your fangs are exceptionally painful. Whenever you score a critical hit with your fangs unarmed attack, you apply the unarmed attack's critical specialization effect." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("54f1a4f6-3db1-4a2e-88ef-8c04df35acd4"), Traits.Instances.Anadi.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6884c9ca-535d-4b26-87ab-deaf272108c5"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
