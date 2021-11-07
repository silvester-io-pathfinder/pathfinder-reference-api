using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WhirlwindStance : Template
    {
        public static readonly Guid ID = Guid.Parse("c7f93da2-7d44-4d87-9fa1-18e91d7d7d3a");

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
            yield return new TextBlock { Id = Guid.Parse("5a3e7ffd-aa54-434c-bff3-2603ba4db7d5"), Type = TextBlockType.Text, Text = "You use your staff as a defensive implement as well as an offensive one. You gain a +2 circumstance bonus to AC as long as you remain in this stance." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("0fccddd7-5403-40e6-a42b-d8c9de85b0fa"), Feats.Instances.StaffAcrobatDedication.ID);
            builder.AddOr(Guid.Parse("fa09ba14-db24-4987-9e0d-e2f570281a63"), or => 
            {
                or.HaveSpecificWeaponGroupSpecificProficiency(Guid.Parse("9f076c81-5b89-4aae-8332-fdefb8c2221f"), Proficiencies.Instances.Expert.ID, WeaponGroups.Instances.Spear.ID);
                or.HaveSpecificWeaponGroupSpecificProficiency(Guid.Parse("d7c0ba8a-960f-46bd-ab06-cc818721439e"), Proficiencies.Instances.Expert.ID, WeaponGroups.Instances.Polearm.ID);
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
                Id = Guid.Parse("e3f7c14a-8135-47ca-a3d3-8c06550e218c"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
