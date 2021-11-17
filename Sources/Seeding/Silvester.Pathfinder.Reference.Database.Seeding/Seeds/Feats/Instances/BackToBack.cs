using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BackToBack : Template
    {
        public static readonly Guid ID = Guid.Parse("cc647577-5d27-45c6-bdef-780cb34af25c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Back to Back",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6a3c3823-f72c-4107-8209-424b3a234596"), Type = TextBlockType.Text, Text = "You excel at watching your allies’ backs and helping them watch yours. As long as you and an ally are adjacent to each other, neither of you can become flat-footed due to flanking unless both of you are flanked. If you’re adjacent to more than one ally, all eligible allies can benefit at a given time. The benefit is negated for everyone if at least you and any one eligible ally are flanked, but not if your allies are flanked and you aren’t." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("e2b1348b-1387-44e5-8a9e-1886ff36d690"), Feats.Instances.MarshalDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("52a8203a-1aef-4101-a579-1f6113326a5f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
