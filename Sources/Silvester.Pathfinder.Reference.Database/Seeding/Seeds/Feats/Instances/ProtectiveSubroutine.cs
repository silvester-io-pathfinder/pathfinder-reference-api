using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ProtectiveSubroutine : Template
    {
        public static readonly Guid ID = Guid.Parse("efc30e80-75ee-4b7d-9567-8af736bd4d95");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Protective Subroutine",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("16c2fa9d-b7a6-4ac4-b341-0c0ae50c4ad9"), Type = TextBlockType.Text, Text = "Your nanites can augment your defenses. You can choose to activate (feat: Nanite Surge) when you attempt a saving throw, instead of when you attempt a skill check. If you do, you gain a +2 status bonus to the triggering saving throw." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("80840071-e142-41d2-a120-4b76cb90faef"), Feats.Instances.NaniteSurge.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("96835ecb-569a-423d-a51a-4b4855850bb5"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
