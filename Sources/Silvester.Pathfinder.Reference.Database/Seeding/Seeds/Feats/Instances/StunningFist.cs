using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class StunningFist : Template
    {
        public static readonly Guid ID = Guid.Parse("045f9c18-d283-4f8b-9635-9c803f85dae9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Stunning Fist",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("93a613ab-2114-4550-90c6-5912d1ff18ed"), Type = TextBlockType.Text, Text = "The focused power of your flurry threatens to overwhelm your opponent. When you target the same creature with two (action: Strikes | Strike) from your (feat: Flurry of Blows), you can try to stun the creature. If either (action: Strike) hits and deals damage, the target must succeed at a Fortitude save against your class DC or be stunned 1 (or stunned 3 on a critical failure). This is an (trait: incapacitation) effect." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificClassFeature(Guid.Parse("c41f3594-db9b-462f-b98f-c9ce17a06cc7"), ClassFeatures.Monks.FlurryOfBlows.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6b6ce5ec-6bc5-4c96-b47f-f3eaf7a04fba"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
