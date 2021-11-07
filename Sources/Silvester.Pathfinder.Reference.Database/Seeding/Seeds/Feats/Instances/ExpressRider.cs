using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ExpressRider : Template
    {
        public static readonly Guid ID = Guid.Parse("f3d6b4f6-6e50-4193-9d92-969464dbf013");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Express Rider",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6d9bd27e-edd5-4238-850f-e0dd2e38c349"), Type = TextBlockType.Text, Text = "You know how to encourage your mount to cover ground quickly. When calculating your travel speed (page 479) for the day while mounted, you can attempt a Nature check to (action: Command an Animal) to increase your mount’s travel speed. The DC is determined by the GM, but is typically based on the mount’s level or the difficulty of the environment, whichever is harder. On a success, increase your mount’s travel speed by half. This has no effect on your mount’s movement in encounters." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("e93b388b-7fa3-440d-8713-fced510944b7"), Proficiencies.Instances.Trained.ID, Skills.Instances.Nature.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1da9de9b-6f49-479c-9295-3017a289b43a"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
