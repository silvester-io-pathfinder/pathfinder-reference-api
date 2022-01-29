using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TangledForestRake : Template
    {
        public static readonly Guid ID = Guid.Parse("3db0482d-30f6-448d-9038-9598bf306030");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Tangled Forest Rake",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c01b8d9f-2539-4418-925d-93804d7ca6ba"), Type = TextBlockType.Text, Text = $"You reposition foes with raking attacks. Make a lashing branch {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}. If you hit and deal damage, you force the target to move 5 feet into a space within your reach. This follows the forced movement rules found on page 475." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("14f8130c-8e08-48c6-8cc9-ced81df35919"), Feats.Instances.TangledForestStance.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("91967ef0-73b8-46eb-970e-8c03cf1ac5e1"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
