using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TenguWeaponStudy : Template
    {
        public static readonly Guid ID = Guid.Parse("a07ee14e-efb7-4b60-a062-6e0429fdc936");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Tengu Weapon Study",
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
            yield return new TextBlock { Id = Guid.Parse("745ba5fe-769d-4083-b693-70e50e01bee9"), Type = TextBlockType.Text, Text = "You&#39;ve learned techniques for using blades and other tengu weapons. Whenever you critically hit using one of the weapons from your (feat: Tengu Weapon Familiarity), you apply the weapon&#39;s critical specialization effect." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("f97478af-f156-41ec-bf86-3db8645296c2"), Feats.Instances.TenguWeaponFamiliarity.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("44b6d474-48ef-4b7e-9d90-74c730b93220"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
