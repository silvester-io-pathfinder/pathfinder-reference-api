using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ResoundingCascade : Template
    {
        public static readonly Guid ID = Guid.Parse("b6f0a1ee-cb2a-42d1-ad58-88e9d4324187");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Resounding Cascade",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You use Arcane Cascade.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("94ad2175-19bc-4776-a2b1-70736d6eefd2"), Type = TextBlockType.Text, Text = "When you enter your (feat: Arcane Cascade), you disperse the magical reinforcement to nearby allies. You grant the extra damage of (feat: Arcane Cascade) in an aura affecting all allies in a 5-foot emanation. This uses only the base damage of the stance, based on the ally’s weapon specialization; it doesn’t use any increase you get from bonuses, the laughing shadow hybrid study, or the like. As normal for duplicate effects, multiple (feat: Arcane Cascades | Arcane Cascade) affecting the same creature aren’t cumulative." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("9470a4be-8c44-42f4-8017-0bf2fb5e53d6"), Feats.Instances.ArcaneCascade.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("eba4eed0-faf4-410f-a593-fe1e3b2cf793"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
