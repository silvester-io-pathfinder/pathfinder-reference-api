using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ArmoredRest : Template
    {
        public static readonly Guid ID = Guid.Parse("aaad4e2a-f221-48a8-a73c-62543a7ea568");

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
            yield return new TextBlock { Id = Guid.Parse("dfefb6bc-72a9-4cb6-bb80-b6e19d1730aa"), Type = TextBlockType.Text, Text = $"You've slept many nights in your armor and gotten used to it. You can sleep in armor overnight without being fatigued the next day. If you were already fatigued before sleeping, the armor doesn't prevent you from recovering from being fatigued." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("ed71a091-88cc-4362-bde1-f41d12b8789b"), Feats.Instances.SwordmasterDedication.ID);
            builder.AddOr(Guid.Parse("a2488ded-e9c9-4505-b6b4-049020fd8071"), or => 
            {
                or.HaveSpecificArmorCategorySpecificProficiency(Guid.Parse("2d073326-57dd-4d58-83bc-aef1e504d785"), Proficiencies.Instances.Trained.ID, ArmorCategories.Instances.LightArmor.ID);
                or.HaveSpecificArmorCategorySpecificProficiency(Guid.Parse("d993bcbd-3219-4235-8fde-117f8c42d2e7"), Proficiencies.Instances.Trained.ID, ArmorCategories.Instances.MediumArmor.ID);
                or.HaveSpecificArmorCategorySpecificProficiency(Guid.Parse("f29f0a04-44fc-47a5-8029-ba3c81c60522"), Proficiencies.Instances.Trained.ID, ArmorCategories.Instances.HeavyArmor.ID);
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
                Id = Guid.Parse("7de9072a-fb3e-46dd-81a6-19d239a94570"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
