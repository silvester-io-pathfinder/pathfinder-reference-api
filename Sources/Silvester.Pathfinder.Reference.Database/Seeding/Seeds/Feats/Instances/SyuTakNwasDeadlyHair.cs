using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SyuTakNwasDeadlyHair : Template
    {
        public static readonly Guid ID = Guid.Parse("3f4ab2d3-0f34-4952-9a79-9762d962dec3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Syu Tak-Nwa's Deadly Hair",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("524a6db3-5928-4f9f-8723-0733253cf90f"), Type = TextBlockType.Text, Text = "Your hair unarmed attack deals 1d6 bludgeoning damage and gains the (trait: grapple) trait." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("8c487761-5611-4881-b181-f2bb06d6c5f1"), Feats.Instances.LivingHair.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("07d85469-ba2a-4aaa-ae4d-5487afbc280f"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
