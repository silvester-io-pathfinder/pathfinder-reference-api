using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MischievousTail : Template
    {
        public static readonly Guid ID = Guid.Parse("8428648e-b43d-4ae3-903c-40175aa4527b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mischievous Tail",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d0230cf6-bb0e-468d-98cf-55bb3f605b72"), Type = TextBlockType.Text, Text = "Your tail can bedevil your foes. You can (action: Disarm) and (action: Trip) creatures with your tail, even if you don’t have a free hand. All restrictions of (feat: Skillful Tail) otherwise continue to apply. If you have (feat: Smashing Tail), your tail unarmed attack gains the (trait: disarm) and (trait: trip) traits." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("eddef4dd-7020-4ecd-bc5f-08dcec88703e"), Feats.Instances.SkillfulTail.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("81e3381d-2070-48b8-b780-37bea2e15e65"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
