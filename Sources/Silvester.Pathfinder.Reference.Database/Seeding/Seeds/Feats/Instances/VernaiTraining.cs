using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class VernaiTraining : Template
    {
        public static readonly Guid ID = Guid.Parse("f130e2af-2b84-45a7-9f3e-93be868a3449");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Vernai Training",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("30c4e12c-a7b2-4325-b9d8-e3c95c3b0143"), Type = TextBlockType.Text, Text = "To resurrect a creature you’ve slain, a spellcaster must counteract your influence on its death. The DC of this check is equal to your class DC or spell DC, whichever is higher." };
            yield return new TextBlock { Id = Guid.Parse("3250d427-9e08-457a-8686-5007c17f595d"), Type = TextBlockType.Text, Text = "In addition, add two 5th-level spells to your Red Mantis assassin spellbook – both spells must be chosen from the following options: (spell: death ward), (spell: drop dead), (spell: false vision), (spell: hallucination), (spell: illusory scene), (spell: mind probe), or (spell: sending). You gain a 5th-level spell slot that you can use to prepare a spell from your Red Mantis assassin spellbook." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("945663cb-cf53-48e0-ad18-08938ef4606e"), Feats.Instances.AchaekeksGrip.ID);
            builder.HaveSpecificFeat(Guid.Parse("dcc33b6c-1338-41cf-98ef-755014f110e6"), Feats.Instances.AdvancedRedMantisMagic.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a5e9daa2-478b-47e5-9d8d-d00142aedc93"),
                SourceId = Sources.Instances.LostOmensLegends.ID,
                Page = -1
            };
        }
    }
}
