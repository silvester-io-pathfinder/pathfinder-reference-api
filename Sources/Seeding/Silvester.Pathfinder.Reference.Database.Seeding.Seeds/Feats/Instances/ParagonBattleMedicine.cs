using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ParagonBattleMedicine : Template
    {
        public static readonly Guid ID = Guid.Parse("b0947cb9-5c2e-469f-867e-aae604812c8f");

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
            yield return new TextBlock { Id = Guid.Parse("3bd3db41-fa08-4b9f-bea2-bc2de13c20ac"), Type = TextBlockType.Text, Text = "Kassi Aziril taught you her techniques that originated the modern use of (feat: Battle Medicine). When you successfully use (feat: Battle Medicine), you can also reduce the target's sickened, enfeebled, or clumsy condition by 1 (this has no effect if you are subject to an effect continually applying the clumsy condition, like (spell: enlarge))." };
            yield return new TextBlock { Id = Guid.Parse("95fd0e3f-d421-4ea1-a3ed-40d9bb975faf"), Type = TextBlockType.Text, Text = "If you are legendary in Medicine, you can choose to reduce the target's frightened or stunned condition by 1 instead, and if you have the (feat: Godless Healing) feat, you can choose to reduce the target's stupefied or drained condition by 1 instead. If you have the (feat: Mortal Healing) feat, you can reduce all available conditions by 1 for a target who hasn't benefited from (trait: positive) or (trait: healing) magic in the last 24 hours, and if you roll a critical success before applying the effects of the feat, you reduce all available conditions by 2 for that target instead." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("60e76a76-d8fb-42ae-9860-4174b13da38e"), Feats.Instances.BattleMedicine.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("a5413c9d-1d8a-4b5e-abcf-549cdf8a762e"), Proficiencies.Instances.Master.ID, Skills.Instances.Medicine.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d06b1759-4051-4eef-88e5-673f7aa5c816"),
                SourceId = Sources.Instances.LostOmensLegends.ID,
                Page = -1
            };
        }
    }
}
