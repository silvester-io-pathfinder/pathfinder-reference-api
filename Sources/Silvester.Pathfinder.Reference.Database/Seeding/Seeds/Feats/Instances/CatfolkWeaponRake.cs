using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CatfolkWeaponRake : Template
    {
        public static readonly Guid ID = Guid.Parse("be8068af-44ea-4a8a-83c6-a41282580564");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Catfolk Weapon Rake",
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
            yield return new TextBlock { Id = Guid.Parse("99f07f75-cfcc-438c-a652-b59503906216"), Type = TextBlockType.Text, Text = "You know how to efficiently use weapons that rake across your enemies. Whenever you critically hit using a catfolk weapon or one of the weapons listed in (feat: Catfolk Weapon Familiarity), you apply the weapon&#39;s critical specialization effect." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("94319dd4-4b59-4b61-9da4-32d9dbb98e72"), Feats.Instances.CatfolkWeaponFamiliarity.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f5e91013-26ab-4894-9af1-50c3d7657a50"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
