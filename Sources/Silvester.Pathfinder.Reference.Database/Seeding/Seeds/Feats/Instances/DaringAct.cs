using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DaringAct : Template
    {
        public static readonly Guid ID = Guid.Parse("ee83f53c-1363-4dae-9d69-0f8612a41f95");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Daring Act",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("45a59ce7-d9c2-475a-8313-2ee71f4d40cf"), Type = TextBlockType.Text, Text = "You attempt a death-defying maneuver to distract your enemies. Select one foe within reach and attempt either an Acrobatics or Athletics check against your target’s Reflex DC. If you succeed, you can (action: Stride) up to half your Speed (or up to your full Speed if you critically succeed) without triggering reactions from the target due to your movement, and the target is flat-footed against the next melee attack you attempt against it before the end of your turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("2180343c-0f96-40e6-bd9a-a33b197add5d"), or => 
            {
                or.HaveSpecificSkillProficiency(Guid.Parse("c420c152-edeb-44bc-952e-7a2ac13e5bff"), Proficiencies.Instances.Trained.ID, Skills.Instances.Acrobatics.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("050a1b81-f117-44bc-ac43-4ebda1a4da54"), Proficiencies.Instances.Trained.ID, Skills.Instances.Athletics.ID);
            });
            builder.HaveSpecificFeat(Guid.Parse("2cf71956-1ab4-457c-9b67-1e424a755660"), Feats.Instances.FirebrandBraggartDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b178de92-0760-4637-8c90-d67175f4269e"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
