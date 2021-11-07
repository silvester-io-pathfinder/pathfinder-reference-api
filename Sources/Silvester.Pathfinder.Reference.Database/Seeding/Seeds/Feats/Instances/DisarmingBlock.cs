using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DisarmingBlock : Template
    {
        public static readonly Guid ID = Guid.Parse("933ec6e3-0442-4612-9026-134c79f1b4b1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Disarming Block",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You Shield Block a melee Strike made with a held weapon.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7cceae12-9ac2-40ab-8106-c70eeac82143"), Type = TextBlockType.Text, Text = "You attempt to (action: Disarm) the creature whose attack you blocked of the weapon they attacked you with. You can do so even if you don’t have a hand free." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("aa74bb7b-9783-43df-b861-af4e5e5d2b81"), Feats.Instances.BastionDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("357080fa-679e-49b1-898e-07a34042bad7"), Proficiencies.Instances.Trained.ID, Skills.Instances.Athletics.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("24958bd9-73c8-4e88-95d7-2d0d266a41ce"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
