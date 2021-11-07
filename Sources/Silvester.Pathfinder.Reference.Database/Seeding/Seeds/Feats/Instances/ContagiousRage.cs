using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ContagiousRage : Template
    {
        public static readonly Guid ID = Guid.Parse("d69ee178-ba1c-4369-b05a-cc6683a21bdc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Contagious Rage",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("457d478e-ba39-45d6-8009-5fe3647f739b"), Type = TextBlockType.Text, Text = "You can drive your allies into a frenzy, granting them incredible benefits. You can ignore the requirements on (feat: Share Rage), using it multiple times in a (feat: Rage). Allies affected by (feat: Share Rage) who accept your anathema for the duration of the (feat: Rage) gain your instinct ability and the specialization ability it gains from weapon specialization, but not greater weapon specialization." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("56e0fc62-1fc2-4835-aab2-d7711776c051"), Feats.Instances.ShareRage.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a77d57cc-dcc7-4186-83a3-e7c10aa5e69a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
