using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CastDown : Template
    {
        public static readonly Guid ID = Guid.Parse("dabd96e0-34e8-4528-b761-76477d8589be");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cast Down",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9d54339e-4b11-4ae8-9372-a182e1e13fbc"), Type = TextBlockType.Text, Text = "The sheer force of your faith can bring a foe crashing down. If the next action you use is to cast (spell: harm) or (spell: heal) to damage one creature, the target is knocked prone if it takes any damage from the spell. If the target critically fails its save against the spell, it also takes a -10-foot status penalty to its Speed for 1 minute." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("62357bb3-9e09-46cf-adfc-e50f46a80d95"), or => 
            {
                or.HaveSpecificDivineFont(Guid.Parse("b386a004-ac61-476d-917b-2215f3f9f470"), DivineFonts.Instances.Heal.ID);
                or.HaveSpecificDivineFont(Guid.Parse("584b12c2-c4dd-421a-8d56-90f768adc1d6"), DivineFonts.Instances.Harm.ID);
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
                Id = Guid.Parse("2c84367a-01c0-48dd-8b76-d9260052f7c1"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
