using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ParagonBattleMedicine : Template
    {
        public static readonly Guid ID = Guid.Parse("975ac52a-41a5-47da-b26c-0c80e42bfcb1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Paragon Battle Medicine",
                Level = 7,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5cc0f69a-e974-4f57-8db0-662cbbc100d4"), Type = TextBlockType.Text, Text = "Kassi Aziril taught you her techniques that originated the modern use of (feat: Battle Medicine). When you successfully use (feat: Battle Medicine), you can also reduce the target’s sickened, enfeebled, or clumsy condition by 1 (this has no effect if you are subject to an effect continually applying the clumsy condition, like (spell: enlarge))." };
            yield return new TextBlock { Id = Guid.Parse("ad1f604a-4604-4046-8b01-79a08e949fbe"), Type = TextBlockType.Text, Text = "If you are legendary in Medicine, you can choose to reduce the target’s frightened or stunned condition by 1 instead, and if you have the (feat: Godless Healing) feat, you can choose to reduce the target’s stupefied or drained condition by 1 instead. If you have the (feat: Mortal Healing) feat, you can reduce all available conditions by 1 for a target who hasn’t benefited from (trait: positive) or (trait: healing) magic in the last 24 hours, and if you roll a critical success before applying the effects of the feat, you reduce all available conditions by 2 for that target instead." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("8fa3260a-3cc3-49b8-9419-61e7a741af8d"), Feats.Instances.BattleMedicine.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("1ad71d00-86ec-4c36-b2ab-109d79288ef1"), Proficiencies.Instances.Master.ID, Skills.Instances.Medicine.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5e8d948d-c785-40bb-a650-d12f2777e793"),
                SourceId = Sources.Instances.LostOmensLegends.ID,
                Page = -1
            };
        }
    }
}
