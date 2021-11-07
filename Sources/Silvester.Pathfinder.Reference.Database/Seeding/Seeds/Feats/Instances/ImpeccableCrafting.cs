using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ImpeccableCrafting : Template
    {
        public static readonly Guid ID = Guid.Parse("fac79b50-4d57-4720-be6b-61c3023aca17");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Impeccable Crafting",
                Level = 7,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a78c7e1d-20f1-43b9-b335-3177b7263e06"), Type = TextBlockType.Text, Text = "You craft flawless creations with great efficiency. Whenever you roll a success at a Crafting check to make an item of the type you chose with (feat: Specialty Crafting), you get a critical success instead." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("bcf94ba7-9218-434e-8fd4-db1e61a7b846"), Proficiencies.Instances.Master.ID, Skills.Instances.Crafting.ID);
            builder.HaveSpecificFeat(Guid.Parse("3e40f212-1e80-4648-903f-71aecebc46ae"), Feats.Instances.SpecialtyCrafting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("33fa16fa-441e-4d23-8313-267966799277"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
