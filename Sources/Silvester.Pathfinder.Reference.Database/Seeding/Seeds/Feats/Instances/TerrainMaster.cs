using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TerrainMaster : Template
    {
        public static readonly Guid ID = Guid.Parse("e954ab79-f4de-40fd-a379-e2ac2435e500");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Terrain Master",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6aa92156-4356-4972-b30f-a4ec3c371793"), Type = TextBlockType.Text, Text = "You adapt to your surroundings in any natural terrain. You can spend 1 hour practicing in your current terrain in order to make it your favored terrain, replacing your current favored terrain temporarily. If you spend a full day out of the new favored terrain, your favored terrain reverts back to your original choice when you took the (feat: Favored Terrain) feat." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("886770bf-7efc-4835-99f1-035f60486d32"), Feats.Instances.HorizonWalkerDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("65d8348a-71ec-424a-b16c-142223e2034c"), Proficiencies.Instances.Master.ID, Skills.Instances.Survival.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3429c867-4820-458e-b5ec-98cacf0715b6"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
