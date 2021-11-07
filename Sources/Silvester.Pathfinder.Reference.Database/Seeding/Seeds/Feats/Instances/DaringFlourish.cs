using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DaringFlourish : Template
    {
        public static readonly Guid ID = Guid.Parse("480c3118-1c70-4827-a9a0-1c5abc3a27d4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Daring Flourish",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7c12f400-0f91-4f53-9b80-6e7c59d718c1"), Type = TextBlockType.Text, Text = "You make quick use of an opening from your daring stunts. At the end of a successful (feat: Daring Act), you can make a melee (action: Strike) against the target or attempt to (action: Disarm) the target. The target is flat-footed against the (action: Strike) you make during (feat: Daring Act) as well as the next melee attack you attempt against it before the end of your turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("12a5e271-b9a4-4994-9553-976d1db89ad6"), Feats.Instances.DaringAct.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7d86c2e6-b5ee-4d47-ae03-58368af1d4f0"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
