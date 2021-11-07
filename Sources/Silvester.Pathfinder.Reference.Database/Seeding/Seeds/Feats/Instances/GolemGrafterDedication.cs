using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GolemGrafterDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("fc8be830-fef8-47bf-83f6-901440e9cef6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Golem Grafter Dedication",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You cannot select another dedication feat until you have gained two other feats from the golem grafter archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e3b42dee-e573-4f89-9ea1-fa684f907d09"), Type = TextBlockType.Text, Text = "Your flesh has been specially treated with the same arcane and alchemical processes used to toughen the skin of flesh golems. Increase your maximum Hit Points by an amount equal to your level. You gain resistance to physical damage (except adamantine) equal to your number of class feats from the golem grafter archetype." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("7cef30d7-1e76-456d-9f88-60de7ba63954"), or => 
            {
                or.AddAnd(Guid.Parse("3b493432-4454-4047-bee5-5b92f06b4fa4"), and => 
                {
                    and.HaveSpecificSkillProficiency(Guid.Parse("b0ffa153-2914-4920-b075-6ef70d817cfc"), Proficiencies.Instances.Expert.ID, Skills.Instances.Arcana.ID);
                    and.HaveSpecificSkillProficiency(Guid.Parse("c46d68e8-9366-438a-bdb7-50099aebb865"), Proficiencies.Instances.Expert.ID, Skills.Instances.Crafting.ID);
                });
                //TODO: Add prerequisites.
            });
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("aeb505c8-a86d-42da-9670-891e6b77f5a6"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
