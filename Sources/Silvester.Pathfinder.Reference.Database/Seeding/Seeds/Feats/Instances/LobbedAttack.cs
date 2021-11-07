using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LobbedAttack : Template
    {
        public static readonly Guid ID = Guid.Parse("83fbca84-c89d-4adb-b14a-5e3ade168a58");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Lobbed Attack",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6602295f-6a86-4ce8-8b91-56f337b0578a"), Type = TextBlockType.Text, Text = "You make a thrown ranged (action: Strike) with the required weapon, using the weapon’s normal range increment. This attack doesn’t trigger reactions, and if the target has never seen you use this feat before, the target is flat-footed against this attack." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("a4e42bd0-34e5-48a6-bcc7-20282414aa38"), Proficiencies.Instances.Master.ID, Skills.Instances.Performance.ID);
            builder.HaveSpecificFeat(Guid.Parse("d8facf5c-56ee-40de-960c-7f393dd6db73"), Feats.Instances.JugglerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("276ac8f8-7fa7-40c0-bf63-8a74ee262496"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
