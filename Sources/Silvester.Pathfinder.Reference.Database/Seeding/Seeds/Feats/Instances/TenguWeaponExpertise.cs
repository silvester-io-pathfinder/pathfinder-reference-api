using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TenguWeaponExpertise : Template
    {
        public static readonly Guid ID = Guid.Parse("bdf00740-dcaf-4120-84d8-daffd76ab413");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Tengu Weapon Expertise",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5d52a47a-6047-4cce-ac76-1045e928fa4b"), Type = TextBlockType.Text, Text = "Study has made you an expert with tengu weapons. Whenever you gain a class feature that grants you expert or greater proficiency in a given weapon or weapons, you also gain that proficiency for the weapons from your (feat: Tengu Weapon Familiarity)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("6365d25f-bbd1-4f9f-8270-de50bff0aecb"), Feats.Instances.TenguWeaponFamiliarity.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("34c02155-1429-44bd-ac47-0d53c2046578"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
