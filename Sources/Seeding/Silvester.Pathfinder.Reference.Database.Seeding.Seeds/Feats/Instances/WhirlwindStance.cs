using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WhirlwindStance : Template
    {
        public static readonly Guid ID = Guid.Parse("207fe5f8-4b23-4e93-b95b-8d9fece38c46");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Whirlwind Stance",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f75f7c16-ecc9-4f43-95da-8b0c6d000189"), Type = TextBlockType.Text, Text = $"You use your staff as a defensive implement as well as an offensive one. You gain a +2 circumstance bonus to AC as long as you remain in this stance." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("d025e311-8f0a-4714-ad2b-878abf74a494"), Feats.Instances.StaffAcrobatDedication.ID);
            builder.AddOr(Guid.Parse("deca6e6b-6dde-4ab8-b4a1-f6734281f19d"), or => 
            {
                or.HaveSpecificWeaponGroupSpecificProficiency(Guid.Parse("b226fbc8-72ef-4b33-88de-e3c517565453"), Proficiencies.Instances.Expert.ID, WeaponGroups.Instances.Spear.ID);
                or.HaveSpecificWeaponGroupSpecificProficiency(Guid.Parse("52675ae3-d5ae-4641-97a4-88ee0db36027"), Proficiencies.Instances.Expert.ID, WeaponGroups.Instances.Polearm.ID);
                //TODO: Add prerequisites.
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
                Id = Guid.Parse("cade36c5-a01c-4fd4-84e6-432495beef6f"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
