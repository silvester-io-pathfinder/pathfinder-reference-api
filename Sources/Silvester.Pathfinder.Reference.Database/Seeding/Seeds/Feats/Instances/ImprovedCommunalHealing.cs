using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ImprovedCommunalHealing : Template
    {
        public static readonly Guid ID = Guid.Parse("330a303a-aad4-44e6-91f0-bc88c4584892");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Improved Communal Healing",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a5ab35b8-f927-4804-973e-406f4f70e148"), Type = TextBlockType.Text, Text = "You can direct excess channeled energy outward to benefit an ally. You can grant the Hit Points you would regain from (feat: Communal Healing) to any one creature within the range of your (spell: heal) spell instead of yourself. You can also use (feat: Communal Healing) when you target only yourself with a (spell: heal) spell, though if you do, you must grant the additional healing to someone other than yourself." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("e7d184f3-98a5-40b7-9aee-80c3fe28b9f7"), Feats.Instances.CommunalHealing.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3c54072c-658f-4ed0-afee-5245d7f6e5ad"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
