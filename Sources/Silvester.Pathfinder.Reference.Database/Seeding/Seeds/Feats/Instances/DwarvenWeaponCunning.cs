using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DwarvenWeaponCunning : Template
    {
        public static readonly Guid ID = Guid.Parse("cd153362-b24e-41c9-8ba2-54100f632803");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dwarven Weapon Cunning",
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
            yield return new TextBlock { Id = Guid.Parse("99d87798-000f-47a6-9ce7-120a85aba480"), Type = TextBlockType.Text, Text = "You’ve learned cunning techniques to get the best effects out of your dwarven weapons. Whenever you critically hit using a battle axe, pick, warhammer, or a dwarf weapon, you apply the weapon’s critical specialization effect." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("0ce9a0b3-b51d-4f37-ad04-86509d4f4ddd"), Feats.Instances.DwarvenWeaponFamiliarity.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dd84433b-348c-4da7-8671-824e0062efbd"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
