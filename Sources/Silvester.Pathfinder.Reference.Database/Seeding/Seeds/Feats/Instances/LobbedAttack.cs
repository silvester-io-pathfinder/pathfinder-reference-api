using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LobbedAttack : Template
    {
        public static readonly Guid ID = Guid.Parse("c135f385-27e6-43ca-9c81-6ae52a97ba9b");

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
            yield return new TextBlock { Id = Guid.Parse("eb5ced18-5d7b-4dc3-9c0b-ee5851f5d610"), Type = TextBlockType.Text, Text = "You make a thrown ranged (action: Strike) with the required weapon, using the weapon’s normal range increment. This attack doesn’t trigger reactions, and if the target has never seen you use this feat before, the target is flat-footed against this attack." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("0ef5fce8-03f5-49ad-a2fa-484ff603b634"), Proficiencies.Instances.Master.ID, Skills.Instances.Performance.ID);
            builder.HaveSpecificFeat(Guid.Parse("1489ee9a-67b3-4b69-8e86-b481ca5c70e2"), Feats.Instances.JugglerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("48774ce7-6814-4ac9-bd76-618930fa16a3"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
