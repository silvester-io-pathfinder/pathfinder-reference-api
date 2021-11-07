using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PerformanceWeaponExpert : Template
    {
        public static readonly Guid ID = Guid.Parse("89ab2cf2-ffc7-4483-9359-204f22dbfd35");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Performance Weapon Expert",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("529335db-61fc-44e2-91bd-4e3ca159fe00"), Type = TextBlockType.Text, Text = "Your experience has made you better with a wide variety of weapons. Your proficiency ranks for simple weapons and martial weapons increase to expert, as does your proficiency rank for your chosen advanced weapon." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("1cc9cc5b-baa0-4a75-8a27-2cdb710e61db"), Feats.Instances.ProvocatorDedication.ID);
            builder.AddOr(Guid.Parse("d35323fd-517d-4243-a7e9-2ec47cc4104a"), or => 
            {
                or.HaveAnyMeleeWeaponSpecificProficiency(Guid.Parse("54266e58-126d-43a3-81ad-9e66c57ce1f8"), Proficiencies.Instances.Expert.ID);
                or.HaveAnyRangedWeaponSpecificProficiency(Guid.Parse("73e7d916-98c7-4fc7-9b99-5b22d22d1c9f"), Proficiencies.Instances.Expert.ID);
                or.HaveAnyWeaponCategorySpecificProficiency(Guid.Parse("bdb459aa-bd21-4150-ab12-e45ea6df106c"), Proficiencies.Instances.Expert.ID);
                or.HaveAnyWeaponGroupSpecificProficiency(Guid.Parse("92e7e106-4df9-496d-884b-9cc6e505586b"), Proficiencies.Instances.Expert.ID);
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
                Id = Guid.Parse("4ab9bf0a-ab91-4c08-b20e-e55df172c211"),
                SourceId = Sources.Instances.AgentsOfEdgewatch.ID,
                Page = -1
            };
        }
    }
}
