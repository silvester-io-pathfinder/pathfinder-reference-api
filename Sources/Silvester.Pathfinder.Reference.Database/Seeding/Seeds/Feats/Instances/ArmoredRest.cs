using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ArmoredRest : Template
    {
        public static readonly Guid ID = Guid.Parse("1a6f6293-96a9-4518-b89f-0e90967b9bcf");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Armored Rest",
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
            yield return new TextBlock { Id = Guid.Parse("416e052c-861e-4adf-9acf-76d1961980af"), Type = TextBlockType.Text, Text = "You&#39;ve slept many nights in your armor and gotten used to it. You can sleep in armor overnight without being fatigued the next day. If you were already fatigued before sleeping, the armor doesn&#39;t prevent you from recovering from being fatigued." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("3e34fdc4-d86f-4627-b5d1-98145667f699"), Feats.Instances.SwordmasterDedication.ID);
            builder.AddOr(Guid.Parse("aa6ff64c-90c8-4bb2-a0f4-7a54c0e81eb1"), or => 
            {
                or.HaveSpecificArmorCategorySpecificProficiency(Guid.Parse("533671cc-06df-439b-b198-6631ad0f0af0"), Proficiencies.Instances.Trained.ID, ArmorCategories.Instances.Light.ID);
                or.HaveSpecificArmorCategorySpecificProficiency(Guid.Parse("374f24ac-633e-4b9b-9dd5-0b56ca045334"), Proficiencies.Instances.Trained.ID, ArmorCategories.Instances.Medium.ID);
                or.HaveSpecificArmorCategorySpecificProficiency(Guid.Parse("874e627a-5a5a-4ec7-93b9-a940d5369f07"), Proficiencies.Instances.Trained.ID, ArmorCategories.Instances.Heavy.ID);
            });
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("72a73beb-c720-4ec2-b313-3821f7b81894"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
