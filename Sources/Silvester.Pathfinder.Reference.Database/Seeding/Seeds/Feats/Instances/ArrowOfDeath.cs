using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ArrowOfDeath : Template
    {
        public static readonly Guid ID = Guid.Parse("2d56d99e-a4fa-4287-b25f-348ee0124a44");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Arrow of Death",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e0a04cee-1423-4d86-9920-5fd398e1b70a"), Type = TextBlockType.Text, Text = "You modify an arrow or bolt to bring death to your target in a single potent hit. Make a bow (action: Strike). On a hit, you deal an additional 10d10 precision damage. On a critical hit, the target must also succeed at a Fortitude saving throw against your class DC or spell DC, whichever is higher, or be immediately slain; this save has the (trait: death) and (trait: incapacitation) traits." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("49acfbc1-913c-41d3-834b-1c39ee8e4f5c"), Feats.Instances.EldritchArcherDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8f2528af-04c3-47ea-bee8-24a74e423814"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
