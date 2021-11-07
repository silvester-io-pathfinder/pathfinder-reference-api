using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class OrcWeaponCarnage : Template
    {
        public static readonly Guid ID = Guid.Parse("56111709-2839-4bc7-80df-c038becc464e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Orc Weapon Carnage",
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
            yield return new TextBlock { Id = Guid.Parse("a1dc5cbc-97f3-44f2-9d0c-b7048ab918b6"), Type = TextBlockType.Text, Text = "You are brutally efficient with the weapons of your orc ancestors. Whenever you critically hit using a falchion, a greataxe, or an orc weapon, you apply the weapon’s critical specialization effect." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("683fe803-bdc7-4870-ba28-2e7477199480"), Feats.Instances.OrcWeaponFamiliarity.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f118717e-638f-4efc-b8a5-eb5606408566"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
