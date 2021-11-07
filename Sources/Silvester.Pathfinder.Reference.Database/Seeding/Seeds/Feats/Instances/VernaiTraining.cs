using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class VernaiTraining : Template
    {
        public static readonly Guid ID = Guid.Parse("cf1fe40c-8eca-4734-ac0a-0af6adcdc0e9");

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
            yield return new TextBlock { Id = Guid.Parse("89375c75-75a5-424d-82c6-e47ad9a6bf5c"), Type = TextBlockType.Text, Text = "To resurrect a creature you’ve slain, a spellcaster must counteract your influence on its death. The DC of this check is equal to your class DC or spell DC, whichever is higher." };
            yield return new TextBlock { Id = Guid.Parse("df0ef7fc-b48f-446a-bd2c-62b48057084b"), Type = TextBlockType.Text, Text = "In addition, add two 5th-level spells to your Red Mantis assassin spellbook – both spells must be chosen from the following options: (spell: death ward), (spell: drop dead), (spell: false vision), (spell: hallucination), (spell: illusory scene), (spell: mind probe), or (spell: sending). You gain a 5th-level spell slot that you can use to prepare a spell from your Red Mantis assassin spellbook." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("1e69011a-3007-495e-b5b0-2fca34ee4f10"), Feats.Instances.AchaekeksGrip.ID);
            builder.HaveSpecificFeat(Guid.Parse("d622401b-6306-4c3e-9838-7c2860d13588"), Feats.Instances.AdvancedRedMantisMagic.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d027d6bf-885f-4bee-9824-04cfd381ecad"),
                SourceId = Sources.Instances.LostOmensLegends.ID,
                Page = -1
            };
        }
    }
}
