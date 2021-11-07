using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AssassinDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("d1582a37-7801-4023-b901-d611e6d2aca8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Assassin Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you've gained two other feats from the assassin archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1eece488-4108-4bdc-90eb-a80bd2890454"), Type = TextBlockType.Text, Text = "You’ve trained to assassinate your foes, and you do so with tenacity and precision. You gain the (feat: Mark for Death) activity." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("57d3f13e-8b1c-495b-9b3c-581a35b1f95d"), Feats.Instances.AlchemicalCrafting.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("03d19754-ee3b-4ee6-bcfa-fb6e8dda9967"), Proficiencies.Instances.Trained.ID, Skills.Instances.Crafting.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("8dd5c743-63a4-4bc2-bcce-6eb049efa8c9"), Proficiencies.Instances.Trained.ID, Skills.Instances.Deception.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("8f5fb4c8-9813-4b64-851d-4ffc9047598a"), Proficiencies.Instances.Trained.ID, Skills.Instances.Stealth.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8db4a5ca-f908-4b5e-9788-04f27bb8bcef"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
