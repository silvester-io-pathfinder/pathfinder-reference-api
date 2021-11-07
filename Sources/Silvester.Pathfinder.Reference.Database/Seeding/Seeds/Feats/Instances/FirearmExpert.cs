using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FirearmExpert : Template
    {
        public static readonly Guid ID = Guid.Parse("33b714de-c58c-4dd6-80a6-7aafb36351a6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Firearm Expert",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("27fa4687-b5cb-4629-9107-867742e0799b"), Type = TextBlockType.Text, Text = "You’ve become an expert with your chosen weapons. Your proficiency ranks for simple and martial crossbows and simple and martial firearms increase to expert." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("40753bb3-305f-4d1c-91ed-549ab3c86fb3"), Feats.Instances.GunslingerDedication.ID);
            builder.AddOr(Guid.Parse("5a5f4131-6b6a-4800-9f53-86e8463cb983"), or => 
            {
                or.HaveAnyWeaponCategorySpecificProficiency(Guid.Parse("a7b2a059-9331-437d-804c-459a9c160963"), Proficiencies.Instances.Expert.ID);
                or.HaveAnyWeaponGroupSpecificProficiency(Guid.Parse("0cf479eb-146d-4f41-9d46-c980613b582e"), Proficiencies.Instances.Expert.ID);
                or.HaveAnyMeleeWeaponSpecificProficiency(Guid.Parse("e4db46b2-e0ef-49e0-90d8-a924632f0111"), Proficiencies.Instances.Expert.ID);
                or.HaveAnyRangedWeaponSpecificProficiency(Guid.Parse("3b9e7e41-8423-48e4-9cb8-ea7a47341490"), Proficiencies.Instances.Expert.ID);
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
                Id = Guid.Parse("c93e7751-7b44-480c-85b1-185a81f87c45"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
