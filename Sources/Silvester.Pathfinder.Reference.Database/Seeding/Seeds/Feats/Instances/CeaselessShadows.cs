using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CeaselessShadows : Template
    {
        public static readonly Guid ID = Guid.Parse("2f5639ca-65d1-4722-9261-7d897898cc54");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ceaseless Shadows",
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
            yield return new TextBlock { Id = Guid.Parse("cffc937f-0659-44f3-950b-e6cda158c4b4"), Type = TextBlockType.Text, Text = "You excel at going unnoticed, especially among a crowd. You no longer need to have cover or be concealed to (Action: Hide) or (Action: Sneak). If you would have lesser cover from creatures, you gain cover and can (Action: Take Cover), and if you would have cover from creatures, you gain greater cover." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("1380f2fa-108e-4322-8b28-ae2e642b6c31"), Feats.Instances.DistractingShadows.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("694b643f-bd54-49b6-906a-793e0e3a5b77"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
