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
    public class BrawlingFocus : Template
    {
        public static readonly Guid ID = Guid.Parse("c3cc9540-b443-4e81-a220-494d9e4d897c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Brawling Focus",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("af947063-fd3b-4bf6-a775-ff97db85f9eb"), Type = TextBlockType.Text, Text = $"You know how to make the most of your attacks when fighting hand-to-hand. You gain access to the critical specialization effects of unarmed strikes in the brawling group and weapons in the brawling group. If you have {ToMarkdownLink<Models.Entities.Feat>("Monastic Weaponry", Feats.Instances.MonasticWeaponry.ID)}, you also gain the critical specialization effects of all monk weapons in which you are trained." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("27e0ff8b-bc4e-46a3-82a1-9c2d6a077f90"), Feats.Instances.BulletDancerDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Monk.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("05c32a2a-6a44-492c-a357-5f2f3a1ede59"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
