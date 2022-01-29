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
    public class PhenomsVerve : Template
    {
        public static readonly Guid ID = Guid.Parse("45ee0299-cb35-49da-a843-fbb5b2fd2d5d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Phenom's Verve",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4ebecf14-b70d-4066-8ada-cd084f7956cd"), Type = TextBlockType.Text, Text = $"You're possessed with an incredibly vivacious spark that separates you not only from ordinary gun users and gunslingers, but even from other phenoms. Using that distinctive verve, when you perform impeccably and control the scene with your abilities, you also manage to set up your foes for disaster and ensure they remain in your sights for any follow-up attacks you want to make against them. If you critically succeed at a Performance check for {ToMarkdownLink<Models.Entities.Feat>("Pistol Twirl", Feats.Instances.PistolTwirl.ID)} or a pistol phenom archetype feat, you gain a +1 status bonus to your attack rolls with one-handed firearms and one-handed melee weapons until the end of your turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("69860846-0366-4faa-9aec-e5661e1dd94a"), Feats.Instances.PistolPhenomDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("983fbab3-502e-4005-a51d-bd3a0e29be57"), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f6641425-f2a6-44d7-a430-ef9ce208396b"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
